using Certweb.Entities;
using Certweb.Services;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Certweb
{
    public partial class Links : UserControl
    {
        private Link LinkEmEdicao { get; set; }

        public Links()
        {
            InitializeComponent();
            CarregarLinks();
        }

        private void CarregarLinks()
        {
            var fonte = new Font("Century Gothic", 8);
            List<Link> listaLinks = GerenciadorDeLinks.LerLinks();
            flpLinks.Controls.Clear();

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

                llbEditar.Click += delegate
                {
                    EditarAction(link);
                };

                llbExcluir.Click += delegate
                {
                    ExcluirAction(link);
                };
            }
        }

        private void EditarAction(Link link)
        {
            LinkEmEdicao = link;
            txtDescricao.Text = link.Descricao;
            txtLink.Text = link.Url;
        }

        private void ExcluirAction(Link link)
        {
            GerenciadorDeLinks.RemoverLink(link);
            CarregarLinks();
        }

        private void BtnSalvar_Click(object sender, System.EventArgs e)
        {
            if(LinkEmEdicao is null)
            {
                GerenciadorDeLinks.AdicionarLink(new Link(txtDescricao.Text, txtLink.Text));
            }
            else
            {
                LinkEmEdicao.Descricao = txtDescricao.Text;
                LinkEmEdicao.Url = txtLink.Text;
            }

            txtDescricao.Clear();
            txtLink.Clear();
            CarregarLinks();
        }

        private void TxtDescricao_Enter(object sender, System.EventArgs e)
        {
            if(txtDescricao.Text == "Descrição")
            {
                txtDescricao.Clear();
                txtDescricao.ForeColor = Color.Black;
            }
        }

        private void TxtDescricao_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                txtDescricao.Text = "Descrição";
                txtDescricao.ForeColor = Color.FromArgb(68,68,68);
            }
        }

        private void TxtLink_Enter(object sender, System.EventArgs e)
        {
            if (txtLink.Text == "Link")
            {
                txtLink.Clear();
                txtLink.ForeColor = Color.Black;
            }
        }

        private void TxtLink_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLink.Text))
            {
                txtLink.Text = "Link";
                txtLink.ForeColor = Color.FromArgb(68, 68, 68);
            }
        }
    }
}