namespace BusinessDataFetcher
{
    using System.Configuration;

    internal class Preferences
    {
        #region Fields

        public static readonly bool DEBUG = ConfigurationManager.AppSettings["debug"] == "true";
        public static readonly string[,] GOOD_HEADERS = {{"User-Agent", "Mozilla/5.0 (Windows; U; Windows NT 6.1; en-GB; rv:1.9.2.12) Gecko/20101026 Firefox/3.6.12"},
                                    {"Accept", "*/*"},{"Accept-Language", "en-gb,en;q=0.5"},{"Accept-Charset", "ISO-8859-1,utf-8;q=0.7,*;q=0.7"}
                                 };
        public static readonly bool LOG = ConfigurationManager.AppSettings["log"] == "true";

        #endregion Fields
    }
}