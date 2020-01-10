using Certweb.Entities;
using Certweb.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Certweb
{
    public partial class Tarefas : UserControl
    {
        private readonly Painel _painel;

        public Tarefas(Painel painel)
        {
            InitializeComponent();
            _painel = painel;
            CarregarLinks();
        }

        public void CarregarLinks()
        {
            var fonte = new Font("Century Gothic", 8);
            List<Link> listaLinks = GerenciadorDeLinks.LerLinks();
            flpLinks.Controls.Clear();

            if (listaLinks is null)
            {
                return;
            }

            foreach (Link link in listaLinks)
            {
                var flpLinha = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.LeftToRight,
                    Size = new Size(flpLinks.Width, 20)
                };

                var txtDescricao = new Label
                {
                    Text = link.Descricao,
                    Font = fonte,
                    ForeColor = Color.FromArgb(68, 68, 68)
                };
                var txtEndereco = new Label
                {
                    Text = link.Url,
                    Font = fonte,
                    ForeColor = Color.FromArgb(68, 68, 68)
                };

                flpLinha.Controls.Add(txtDescricao);
                flpLinha.Controls.Add(txtEndereco);
                flpLinks.Controls.Add(flpLinha);
            }
        }

        private void Executar()
        {

            var sw = new Stopwatch();
            sw.Start();

            List<Link> Lista = GerenciadorDeLinks.LerLinks();
            int TotalLinks = Lista.Count;
            int LinkProcessamentoAtual = 0;
            
            foreach (Link link in Lista)
            {
                GerenciadorDeAcesso.AcessarLink(link.Url);
                LinkProcessamentoAtual++;
                //int Porcentagem = LinkProcessamentoAtual / TotalLinks * 100;

                if (InvokeRequired)
                {
                    Invoke(new Action(() => prgProgressBar.Value = LinkProcessamentoAtual / TotalLinks * 100));
                     
                }
            }
            sw.Stop();

            Painel.Modelo.TempoDecorrido = sw.Elapsed;
            Painel.Modelo.UltimaExecucao = DateTime.Now;

            if (_painel.InvokeRequired)
            {
                Invoke(new Action(() => _painel.AtualizarTextoTela()));

            }
            MessageBox.Show("Sucesso!");
        }

        private void BtnExecutar_Click(object sender, System.EventArgs e)
        {
            new Thread(Executar).Start();
        }
    }
}