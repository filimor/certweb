using Certweb.Entities;
using Certweb.Services;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Certweb
{
    public partial class Painel : UserControl
    {
        public static PainelModel Modelo { get; set; }

        public Painel()
        {
            InitializeComponent();
            Modelo = GerenciadorTelaPainel.LerDados() ?? new PainelModel();
            AtualizarTextoTela();
        }

        public void QuantidadeLinks()
        {
            List<Link> lista = GerenciadorDeLinks.LerLinks();
            lblQuantidade.Text = lista.Count.ToString();
        }

        public void AtualizarTextoTela()
        {
            lblErros.Text = Painel.Modelo.QuantidadeErros.ToString();
            lblTempoDecorrido.Text = Painel.Modelo.TempoDecorrido.ToString("ss") + "s";
            lblUltimaExecucao.Text = Painel.Modelo.UltimaExecucao.ToString("HH:mm");
        }
    }
}