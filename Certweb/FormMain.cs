using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Certweb
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
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
    }
}
