using System;
using System.Net;

namespace Certweb.Services
{
    public static class GerenciadorDeAcesso
    {
        public static string AcessarLink(string link)
        {
            try
            {
                var client = new WebClient();
                return client.DownloadString(link);
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception)
            {
                Painel.Modelo.QuantidadeErros++;
                return null;
            }
#pragma warning restore CA1031 // Do not catch general exception types
        }
    }
}