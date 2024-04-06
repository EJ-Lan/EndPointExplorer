namespace EndPointExplorer.Models
{
    internal class RequestModel
    {
        public string Url { get; set; }
        public string Method { get; set; }
        public string Body { get; set; }
        public Dictionary<string, string> Headers { get; set; } = new Dictionary<string, string>;
    }
}
