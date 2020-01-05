using Certweb.Entities;
using Newtonsoft.Json;

namespace Certweb.Services
{
    public static class GerenciadorTelaPainel
    {
        private const string NomeArquivo = "links.txt";

        public static PainelModel LerDados()
        {
            string conteudoArquivo = GerenciadorDeArquivos.Ler(NomeArquivo);
            return conteudoArquivo != null ?
                JsonConvert.DeserializeObject<PainelModel>(conteudoArquivo) :
                null;
        }

        public static void SalvarDados(PainelModel painelModel)
        {
            string jsonLink = JsonConvert.SerializeObject(painelModel);
            GerenciadorDeArquivos.Escrever(NomeArquivo, jsonLink);
        }
    }
}