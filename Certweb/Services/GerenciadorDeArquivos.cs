﻿using System;
using System.IO;

namespace Certweb.Services
{
    public class GerenciadorDeArquivos
    {
        private readonly string _diretorioProjeto = AppDomain.CurrentDomain.BaseDirectory;

        public string Ler(string arquivo)
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

        public void Escrever(string arquivo, string conteudo)
        {
            string caminho = $@"{_diretorioProjeto}\{arquivo}";

            using (var sw = new StreamWriter(caminho))
            {
                sw.Write(conteudo);
            }
        }
    }
}