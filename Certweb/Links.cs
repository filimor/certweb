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
        private Tarefas _tarefas;
        private Painel _painel;

        public Links()
        {
            InitializeComponent();
        }

        public void SetPanels(Tarefas tarefas, Painel painel)
        {
            _tarefas = tarefas;
            _painel = painel;
            CarregarLinks();
        }

        private void CarregarLinks()
        {
            _tarefas.CarregarLinks();
            _painel.QuantidadeLinks();

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
                    AutoSize = true,
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
            if (LinkEmEdicao is null)
            {
                GerenciadorDeLinks.AdicionarLink(new Link(txtDescricao.Text, txtLink.Text));
            }
            else
            {
                LinkEmEdicao.Descricao = txtDescricao.Text;
                LinkEmEdicao.Url = txtLink.Text;
                LinkEmEdicao = null;
            }

            txtDescricao.Text = Resource.TXT_DESCRICAO;
            txtLink.Text = Resource.TXT_LINK;
            CarregarLinks();
        }

        private void TxtDescricao_Enter(object sender, System.EventArgs e)
        {
            if (txtDescricao.Text == Resource.TXT_DESCRICAO)
            {
                txtDescricao.Clear();
                txtDescricao.ForeColor = Color.Black;
            }
        }

        private void TxtDescricao_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                txtDescricao.Text = Resource.TXT_DESCRICAO;
                txtDescricao.ForeColor = Color.FromArgb(68, 68, 68);
            }
        }

        private void TxtLink_Enter(object sender, System.EventArgs e)
        {
            if (txtLink.Text == Resource.TXT_LINK)
            {
                txtLink.Clear();
                txtLink.ForeColor = Color.Black;
            }
        }

        private void TxtLink_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLink.Text))
            {
                txtLink.Text = Resource.TXT_LINK;
                txtLink.ForeColor = Color.FromArgb(68, 68, 68);
            }
        }
    }
}