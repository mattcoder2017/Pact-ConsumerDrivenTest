namespace Consumer.Models
{
    public class HypermediaLink
    {
        public string Href { get; set; }

        public HypermediaLink(string href)
        {
            Href = href;
        }
    }
}