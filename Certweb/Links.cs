using Certweb.Entities;
using Certweb.Services;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Certweb
{
    public partial class Links : UserControl
    {
        public Links()
        {
            InitializeComponent();
            CarregarLinks();
        }

        private void CarregarLinks()
        {
            var fonte = new Font("Century Gothic", 8);
            List<Link> listaLinks = GerenciadorDeLinks.LerLinks();
            foreach (Link link in listaLinks)
            {
                var flpLinha = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.LeftToRight,
                    Size = new Size(flpLinks.Width, 40)
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
                var llbEditar = new LinkLabel
                {
                    Text = "Editar",
                    Font = fonte,
                    ForeColor = Color.FromArgb(68, 68, 68)
                };
                var llbExcluir = new LinkLabel
                {
                    Text = "Excluir",
                    Font = fonte,
                    ForeColor = Color.FromArgb(68, 68, 68)
                };

                flpLinha.Controls.Add(txtDescricao);
                flpLinha.Controls.Add(txtEndereco);
                flpLinha.Controls.Add(llbEditar);
                flpLinha.Controls.Add(llbExcluir);

                flpLinks.Controls.Add(flpLinha);
            }
        }

        private void BtnSalvar_Click(object sender, System.EventArgs e)
        {
            GerenciadorDeLinks.AdicionarLink(new Link(txtDescricao.Text, txtLink.Text));
            txtDescricao.Clear();
            txtLink.Clear();
        }
    }
}