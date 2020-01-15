using Certweb.Entities;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Certweb.Services
{
    public static class GerenciadorDeLinks
    {
        private static List<Link> ListaLinks { get; set; }
        private const string NomeArquivo = "links.txt";

        public static void AdicionarLink(Link link)
        {
            ListaLinks.Add(link);
        }

        public static void RemoverLink(Link link)
        {
            ListaLinks.Remove(link);
        }

        public static List<Link> LerLinks()
        {
            if (ListaLinks == null)
            {
                string conteudoArquivo = GerenciadorDeArquivos.Ler(NomeArquivo);
                ListaLinks = conteudoArquivo != null
                    ? JsonConvert.DeserializeObject<List<Link>>(conteudoArquivo)
                    : new List<Link>
                    {
                        new Link("Google", "www.google.com")
                    };
            }
            return ListaLinks;
        }

        public static void SalvarLinks()
        {
            string jsonLink = JsonConvert.SerializeObject(ListaLinks);
            GerenciadorDeArquivos.Escrever(NomeArquivo, jsonLink);
        }
    }
}