using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace Certweb.Services
{
    public static class GerenciadorDeAcesso
    {
        public static string AcessarLink(string link)
        {
            var client = new WebClient();
            return client.DownloadString(link);
        }
    }
}
