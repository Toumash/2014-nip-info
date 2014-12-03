using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using BusinessDataFetcher.model;

namespace BusinessDataFetcher
{
    internal class HTMLHelper
    {
        public static readonly string[,] GOOD_HEADERS = Preferences.GOOD_HEADERS;

        public static void AddHeadersTo(ref WebClient wc)
        {
            Logger.WriteLine("Adding Custor perfect headers...", ConsoleColor.Red);
            for (int i = 0; i < GOOD_HEADERS.GetLength(0); i++)
            {
                wc.Headers.Add(GOOD_HEADERS[i, 0], GOOD_HEADERS[i, 1]);
                Logger.WriteLine(GOOD_HEADERS[i, 0] + ":" + GOOD_HEADERS[i, 1], ConsoleColor.Yellow);
            }
        }

        public static string[] GetFirmsHTMLCollection(string html)
        {
            string pattern = "<p>(.*?)</p>";
            List<string> list = new List<string>();
            MatchCollection col = Regex.Matches(html, pattern, RegexOptions.Singleline);
            foreach (Match m in col)
            {
                list.Add(m.Groups[1].Value);
            }
            return list.ToArray();
        }

        public static string GetFirmsListHTML(string html)
        {
            string rStart = "<div id=\"pager_bot\"></div>.*</div>";
            string rEnd = "<div class=\"clear\"></div>.*<div class=\"adsense_bottom\">";
            Match match = Regex.Match(html, rStart + "(.*?)" + rEnd, RegexOptions.Singleline);
            string output = match.Success ? match.Groups[1].Value : String.Empty;
            GetFirmsHTMLCollection(output);
            return output;
        }

        public static List<FirmRequest> GetFirmsRequest(string[] data)
        {
            List<FirmRequest> list = new List<FirmRequest>();
            string urlPattern = "<a href=\"(.*?)\">";
            string namePattern = "<b>(.*?)</b>";
            int i = 0;
            foreach (string f in data)
            {
                Logger.WriteLine(i.ToString(), ConsoleColor.Red);

                // LINK
                Match m = Regex.Match(f, urlPattern, RegexOptions.Singleline);
                string url = String.Empty;
                if (m.Success)
                {
                    url = m.Groups[1].Value;
                    Logger.WriteLine(url, ConsoleColor.DarkGreen);
                }

                //NAME
                m = Regex.Match(f, namePattern, RegexOptions.Singleline);
                string name = String.Empty;
                if (m.Success)
                {
                    name = m.Groups[1].Value;
                    Logger.WriteLine(name, ConsoleColor.DarkGreen);
                }

                list.Add(new FirmRequest(url, name));

                i++;
            }
            return list;
        }

        public static string TrimScript(string htmlDocText)
        {
            string pattern = @"(?s)<script.*?(/>|</script>)";
            return Regex.Replace(htmlDocText, pattern, "", RegexOptions.Singleline);
        }
    }
}