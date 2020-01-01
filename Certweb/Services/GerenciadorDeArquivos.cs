using System;
using System.IO;

namespace Certweb.Services
{
    public static class GerenciadorDeArquivos
    {
        private static readonly string _diretorioProjeto = AppDomain.CurrentDomain.BaseDirectory;

        public static string Ler(string arquivo)
        {
            string caminho = $@"{_diretorioProjeto}\{arquivo}";

            if (File.Exists(caminho))
            {
                using (var sr = new StreamReader(caminho))
                {
                    return sr.ReadToEnd();
                }
            }
            else
            {
                return null;
            }
        }

        public static void Escrever(string arquivo, string conteudo)
        {
            string caminho = $@"{_diretorioProjeto}\{arquivo}";

            using (var sw = new StreamWriter(caminho))
            {
                sw.Write(conteudo);
            }
        }
    }
}