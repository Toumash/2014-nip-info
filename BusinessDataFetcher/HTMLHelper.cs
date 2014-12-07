namespace BusinessDataFetcher
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Text.RegularExpressions;

    using BusinessDataFetcher.Model;

    internal class HTMLHelper
    {
        #region Fields

        public static readonly string[,] GOOD_HEADERS = Preferences.GOOD_HEADERS;

        #endregion Fields

        #region Methods

        public static void AddHeadersTo(ref WebClient wc)
        {
            Logger.WriteLine("Adding Custor perfect headers...", ConsoleColor.Red);
            for (int i = 0; i < GOOD_HEADERS.GetLength(0); i++)
            {
                wc.Headers.Add(GOOD_HEADERS[i, 0], GOOD_HEADERS[i, 1]);
                Logger.WriteLine(GOOD_HEADERS[i, 0] + ":" + GOOD_HEADERS[i, 1], ConsoleColor.Yellow);
            }
        }

        public static List<BasicFirm> GetBasicFirms(List<String> data)
        {
            List<BasicFirm> list = new List<BasicFirm>();
            string urlPattern = "<a href=\"(.*?)\".*?>";
            string namePattern = "<b>(.*?)</b>";
            string addressPattern = "</a>.*?(<br.*?>)?(.*?)<br.*?>(.*)";
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

                //ADDRESS
                m = Regex.Match(f, addressPattern, RegexOptions.Singleline);
                string address = String.Empty;
                string description = String.Empty;
                if (m.Success)
                {
                    description = m.Groups[2].Value.Trim();
                    description = (description == String.Empty) ? "BRAK" : description;
                    address = m.Groups[3].Value.Trim();

                    Logger.WriteLine(address, ConsoleColor.DarkGreen);
                    Logger.WriteLine(description, ConsoleColor.DarkGreen);
                }

                list.Add(new BasicFirm(url, name, Address.FromString(address), description));

                i++;
            }
            return list;
        }

        public static string GetCAPTCHAForm(string html)
        {
            string pattern = "<div id=\"all\">.*?(<form action.*? id=\"cf\".*?>.*?</form>)";
            Match m = Regex.Match(html, pattern, RegexOptions.Singleline);

            return m.Success ? m.Groups[1].Value : null;
        }

        public static List<String> GetFirmsHTMLCollection(string html)
        {
            string pattern = "<p>(.*?)</p>";
            List<string> list = new List<string>();
            MatchCollection col = Regex.Matches(html, pattern, RegexOptions.Singleline);
            foreach (Match m in col)
            {
                list.Add(m.Groups[1].Value);
            }
            return list;
        }

        public static string GetFirmsListHTML(string html)
        {
            string pattern = "<div id=\"main\">.*?<div.*?>.*?<p class=\"nag\">.*?</p>.*?<p>(.*?)<div.*?>";
            Match match = Regex.Match(html, pattern, RegexOptions.Singleline);
            string output = match.Success ? match.Groups[1].Value : String.Empty;
            output = RemoveNewLines(output);
            //add paragraph tag, cause the pattern strips one
            return "<p>" + output;
        }

        public static string RemoveNewLines(string x)
        {
            return x.Replace("\r", string.Empty).Replace("\n", string.Empty);
        }

        public static string TrimJS(string htmlDocText)
        {
            string pattern = @"(?s)<script.*?(/>|</script>)";
            return Regex.Replace(htmlDocText, pattern, "", RegexOptions.Singleline);
        }

        #endregion Methods
    }
}