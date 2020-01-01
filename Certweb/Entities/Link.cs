namespace Certweb.Entities
{
    public class Link
    {
        public string Descricao { get; set; }
        public string Url { get; set; }

        public Link(string descricao, string url)
        {
            Descricao = descricao;
            Url = url;
        }
    }
}