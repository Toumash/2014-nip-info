using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using BusinessDataFetcher.Model;

namespace BusinessDataFetcher
{
    public partial class MainForm : Form
    {
        public static readonly bool DEBUG = Preferences.DEBUG;
        public readonly static Encoding ENCODING = Encoding.GetEncoding("iso-8859-2");
        public static readonly bool LOG = Preferences.LOG;
        private const string BASE_URL = "http://www.krs-online.com.pl/";
        private const string SEARCH_URL = "http://www.krs-online.com.pl/?p=6&look=";
        private List<BasicFirm> BasicList = new List<BasicFirm>();
        private string NIP = String.Empty;
        private WebClient Wc;

        public MainForm()
        {
            InitializeComponent();

            if (LOG) Logger.Init();

            Wc = new WebClient();

            ShowNoItems(false);
            //if (DEBUG)
            //{
            //    string input = File.ReadAllText("input.txt", ENCODING);
            //    ParseListDownload(input);
            //}
        }

        public void DownloadFullData(List<BasicFirm> list)
        {
            new Thread(() =>
            {
                foreach (BasicFirm request in list)
                {
                    try
                    {
                        WebClient wc = new WebClient();
                        Wc.Encoding = ENCODING;
                        HTMLHelper.AddHeadersTo(ref wc);

                        Logger.WriteLine("Downloading for:" + request.Name + " Started", ConsoleColor.DarkCyan);
                        string result = wc.DownloadString(new Uri(BASE_URL + request.Url));
                        string withoutJS = HTMLHelper.TrimJS(result);
                        string html = Regex.Match(withoutJS,
                            "<p class=\"nag\">(.*?)<div class=\"adsense_bottom\">(.*?)<div id=\"bottom\">",
                            RegexOptions.Singleline).Groups[1].Value;

                        Logger.WriteLine("Downloading for:" + request.Name + " FINISHED" + html, ConsoleColor.Green);
                    }
                    catch (Exception e)
                    {
                        Logger.WriteLine("Exception thrown" + e.ToString());
                    }
                    if (LOG) Thread.Sleep(5000);
                }
            }).Start();
        }

        public void DownloadListStart(string url)
        {
            ShowNoItems(false);
            Wc.CancelAsync();
            Wc = new WebClient();
            InitWebClient(ref Wc);
            Wc.DownloadDataCompleted += webClient_ListDownloadCompleted;
            Wc.DownloadDataAsync(new Uri(url));
            SetToWaitState(true);
            Logger.WriteLine("Downloading started. Url: " + url);
        }

        public void InitWebClient(ref WebClient wc)
        {
            Wc.Encoding = ENCODING;
            HTMLHelper.AddHeadersTo(ref Wc);
        }

        public void ParseListDownload(string input)
        {
            Logger.WriteLine("Page Fetched.");
            string html = HTMLHelper.TrimJS(input);
            string form = HTMLHelper.GetCAPTCHAForm(html);
            if (form != null)
            {
                new CaptchaUnlockerForm().ShowDialog();
            }
            else
            {
                List<BasicFirm> col = HTMLHelper.GetBasicFirms(HTMLHelper.GetFirmsHTMLCollection(HTMLHelper.GetFirmsListHTML(html)));

                tb_OUT.Enabled = true;

                if (col.Count > 0)
                {
                    ShowNoItems(false);
                    BasicList.AddRange(col);
                    PopulateListView(col);
                }
                else
                {
                    ShowNoItems(true);
                }
            }
        }

        public void PopulateListView(List<BasicFirm> list)
        {
            foreach (BasicFirm b in list)
            {
                string[] row = { b.Description, b.Address.SeparateBy(","), b.Url };
                lv_MAIN.Items.Add(b.Name).SubItems.AddRange(row);
            }
        }

        public void SetToWaitState(bool x)
        {
            UseWaitCursor = x;
        }

        public void ShowNoItems(bool x)
        {
            lb_NO_ENTRIES.Visible = x;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (LOG)
            {
                Logger.WriteLine("CLOSING APPLICATION...", ConsoleColor.Red);
                Thread.Sleep(300);
                Logger.Dispose();
            }
            base.OnClosing(e);
        }

        private void bt_CLEAR_Click(object sender, EventArgs e)
        {
            BasicList.Clear();
            lv_MAIN.Items.Clear();
            tb_OUT.Enabled = false;
            tb_OUT.Clear();
        }

        private void bt_serach_Click(object sender, EventArgs e)
        {
            string url = SEARCH_URL + this.tb_NIP.Text;
            NIP = tb_NIP.Text.Trim();
            DownloadListStart(url);
        }

        /// <summary>
        /// Creates new CSV Represenation in the TextBox
        /// </summary>
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string output = String.Empty;

            foreach (ListViewItem x in lv_MAIN.SelectedItems)
            {
                int i = x.Index;
                if (i >= 0 && i < BasicList.Count)
                {
                    BasicFirm item = BasicList[i];
                    string[] fields = { NIP, item.Name, item.Description, item.Address.SeparateBy(";") };
                    output += string.Join(";", fields) + Environment.NewLine;
                }
            }
            tb_OUT.Text = output;
        }

        private void tb_NIP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_SEARCH.PerformClick();
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

        private void webClient_ListDownloadCompleted(object sender, DownloadDataCompletedEventArgs e)
        {
            SetToWaitState(false);
            if (!e.Cancelled && e.Error == null)
            {
                string result = ENCODING.GetString(e.Result);
                Logger.WriteLine(result, ConsoleColor.DarkCyan);
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
    }
}