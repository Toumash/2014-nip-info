using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using BusinessDataFetcher.model;

namespace BusinessDataFetcher
{
    public partial class MainForm : Form
    {
        public static readonly bool DEBUG = ConfigurationManager.AppSettings["logging"] == "true";
        private const string BASE_URL = "http://www.krs-online.com.pl/";
        private const string SEARCH_URL = "http://www.krs-online.com.pl/?p=6&look=";
        private List<Firm> FinalList = new List<Firm>();
        private WebClient Wc;

        public MainForm()
        {
            InitializeComponent();

            if (DEBUG) Logger.Init();

            Wc = new WebClient();
            HTMLHelper.AddHeadersTo(ref Wc);

            if (DEBUG)
            {
                string input = File.ReadAllText("input.txt");
                ParseListDownload(input);
            }
        }

        public void DownloadFullData(List<FirmRequest> list)
        {
            new Thread(() =>
            {
                foreach (FirmRequest request in list)
                {
                    try
                    {
                        WebClient wc = new WebClient();
                        HTMLHelper.AddHeadersTo(ref wc);

                        Logger.WriteLine("Downloading for:" + request.Name + " Started", ConsoleColor.DarkCyan);
                        string result = wc.DownloadString(new Uri(BASE_URL + request.Url));
                        string withoutJS = HTMLHelper.TrimScript(result);
                        string html = Regex.Match(withoutJS, "<p class=\"nag\">(.*?)<div class=\"adsense_bottom\">(.*?)<div id=\"bottom\">", RegexOptions.Singleline).Groups[1].Value;

                        Logger.WriteLine("Downloading for:" + request.Name + " FINISHED" + html, ConsoleColor.Green);
                    }
                    catch (Exception e)
                    {
                        Logger.WriteLine("Exception thrown" + e.ToString());
                    }
                    if (DEBUG) Thread.Sleep(5000);
                }
            }).Start();
        }

        public void DownloadListStart(string url)
        {
            Wc.DownloadStringCompleted += webClient_FirstDownloadCompleted;
            Wc.DownloadStringAsync(new Uri(url));
            Logger.WriteLine("Downloading started. Url: " + url);
        }

        public void ParseListDownload(string input)
        {
            Logger.WriteLine("Page Fetched.");
            string html = HTMLHelper.TrimScript(input);
            this.wb_MAIN.DocumentText = html;

            List<FirmRequest> col = HTMLHelper.GetFirmsRequest(HTMLHelper.GetFirmsHTMLCollection(HTMLHelper.GetFirmsListHTML(html)));
            DownloadFullData(col);
        }

        private void bt_serach_Click(object sender, EventArgs e)
        {
            string url = BASE_URL + this.tb_NIP.Text;
            DownloadListStart(url);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (DEBUG)
            {
                Logger.WriteLine("CLOSING APPLICATION...", ConsoleColor.Red);
                Thread.Sleep(300);
                Logger.Dispose();
            }
            base.OnClosing(e);
        }

        private void webClient_FirstDownloadCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error == null)
            {
                string result = (string)e.Result;
                ParseListDownload(result);
            }
            else
            {
                MessageBox.Show(e.Error.Message, "Błąd przy pobiereaniu danych");
            }
        }

        private void webClient_SecondDownloadCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error == null)
            {
                string result = (string)e.Result;
            }
            else
            {
                MessageBox.Show(e.Error.Message, "Błąd przy pobiereaniu danych");
            }
        }

        private void ts_About_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        private void ts_CloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}