namespace BusinessDataFetcher.model
{
    public class FirmRequest
    {
        public string Url;
        public string Name;

        public FirmRequest(string url, string name)
        {
            this.Url = url;
            this.Name = name;
        }
    }
}