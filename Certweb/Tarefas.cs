using Certweb.Services;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Certweb.Entities;

namespace Certweb
{
    public partial class Tarefas : UserControl
    {
        public Tarefas()
        {
            InitializeComponent();
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

        private void BtnExecutar_Click(object sender, System.EventArgs e)
        {
            foreach (Link link in GerenciadorDeLinks.LerLinks())
            {
                GerenciadorDeAcesso.AcessarLink(link.Url);
            }
            MessageBox.Show("Sucesso!");
        }
    }
}