using Certweb.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Certweb
{
    public partial class FormMain : Form
    {
        private bool _botaoMousePressionado;
        private Point _pontoInicialFormulario;
        private Point _pontoInicialCursor;

        public FormMain()
        {
            GerenciadorDeLinks.LerLinks();
            InitializeComponent();
            pnTarefas.SetPanels(this, pnPainel);
            pnLinks.SetPanels(pnTarefas, pnPainel);
            SelecionarPainel(pnPainel);
        }

        private void SelecionarPainel(UserControl painel)
        {
            pnPainel.Visible = false;
            pnLinks.Visible = false;
            pnSobre.Visible = false;
            pnTarefas.Visible = false;
            painel.Visible = true;
        }

        private void MoverIndicador(object obj)
        {
            var button = obj as Button;
            pnlIndicador.Location = new Point(pnlIndicador.Location.X,
                button.Location.Y - 15);
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            GerenciadorDeLinks.SalvarLinks();
            GerenciadorTelaPainel.SalvarDados(Painel.Modelo);
            Application.Exit();
        }

        private void BtnTarefas_Click(object sender, EventArgs e)
        {
            SelecionarPainel(pnTarefas);
            MoverIndicador(sender);
        }

        private void BtnPainel_Click(object sender, EventArgs e)
        {
            SelecionarPainel(pnPainel);
            MoverIndicador(sender);
        }

        private void BtnLink_Click(object sender, EventArgs e)
        {
            SelecionarPainel(pnLinks);
            MoverIndicador(sender);
        }

        private void BtnSobre_Click(object sender, EventArgs e)
        {
            SelecionarPainel(pnSobre);
            MoverIndicador(sender);
        }

        private void PnlSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            _botaoMousePressionado = true;
            _pontoInicialFormulario = Location;
            _pontoInicialCursor = Cursor.Position;
        }

        private void PnlSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            _botaoMousePressionado = false;
        }

        private void PnlSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (_botaoMousePressionado)
            {
                var dif = Point.Subtract(Cursor.Position, new Size(_pontoInicialCursor));
                Location = Point.Add(_pontoInicialFormulario, new Size(dif));
            }
        }

        private void ExecutarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnTarefas.BtnExecutar_Click(this, EventArgs.Empty);
        }
    }
}