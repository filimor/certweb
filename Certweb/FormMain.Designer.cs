namespace Certweb
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.pnlEsquerdo = new System.Windows.Forms.Panel();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnLink = new System.Windows.Forms.Button();
            this.btnTarefas = new System.Windows.Forms.Button();
            this.btnPainel = new System.Windows.Forms.Button();
            this.pnlIndicador = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.icnCertwebSystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsContentMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.executarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnLinks = new Certweb.Links();
            this.pnTarefas = new Certweb.Tarefas();
            this.pnPainel = new Certweb.Painel();
            this.pnSobre = new Certweb.Sobre();
            this.pnlEsquerdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.cmsContentMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            resources.ApplyResources(this.pnlSuperior, "pnlSuperior");
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlSuperior_MouseDown);
            this.pnlSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlSuperior_MouseMove);
            this.pnlSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlSuperior_MouseUp);
            // 
            // pnlEsquerdo
            // 
            resources.ApplyResources(this.pnlEsquerdo, "pnlEsquerdo");
            this.pnlEsquerdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pnlEsquerdo.Controls.Add(this.btnSobre);
            this.pnlEsquerdo.Controls.Add(this.btnLink);
            this.pnlEsquerdo.Controls.Add(this.btnTarefas);
            this.pnlEsquerdo.Controls.Add(this.btnPainel);
            this.pnlEsquerdo.Controls.Add(this.pnlIndicador);
            this.pnlEsquerdo.Name = "pnlEsquerdo";
            // 
            // btnSobre
            // 
            resources.ApplyResources(this.btnSobre, "btnSobre");
            this.btnSobre.FlatAppearance.BorderSize = 0;
            this.btnSobre.ForeColor = System.Drawing.Color.White;
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.BtnSobre_Click);
            // 
            // btnLink
            // 
            resources.ApplyResources(this.btnLink, "btnLink");
            this.btnLink.FlatAppearance.BorderSize = 0;
            this.btnLink.ForeColor = System.Drawing.Color.White;
            this.btnLink.Name = "btnLink";
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.BtnLink_Click);
            // 
            // btnTarefas
            // 
            resources.ApplyResources(this.btnTarefas, "btnTarefas");
            this.btnTarefas.FlatAppearance.BorderSize = 0;
            this.btnTarefas.ForeColor = System.Drawing.Color.White;
            this.btnTarefas.Name = "btnTarefas";
            this.btnTarefas.UseVisualStyleBackColor = true;
            this.btnTarefas.Click += new System.EventHandler(this.BtnTarefas_Click);
            // 
            // btnPainel
            // 
            resources.ApplyResources(this.btnPainel, "btnPainel");
            this.btnPainel.FlatAppearance.BorderSize = 0;
            this.btnPainel.ForeColor = System.Drawing.Color.White;
            this.btnPainel.Name = "btnPainel";
            this.btnPainel.UseVisualStyleBackColor = true;
            this.btnPainel.Click += new System.EventHandler(this.BtnPainel_Click);
            // 
            // pnlIndicador
            // 
            resources.ApplyResources(this.pnlIndicador, "pnlIndicador");
            this.pnlIndicador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.pnlIndicador.Name = "pnlIndicador";
            // 
            // picLogo
            // 
            resources.ApplyResources(this.picLogo, "picLogo");
            this.picLogo.Name = "picLogo";
            this.picLogo.TabStop = false;
            // 
            // btnFechar
            // 
            resources.ApplyResources(this.btnFechar, "btnFechar");
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // icnCertwebSystemTray
            // 
            resources.ApplyResources(this.icnCertwebSystemTray, "icnCertwebSystemTray");
            this.icnCertwebSystemTray.ContextMenuStrip = this.cmsContentMenu;
            // 
            // cmsContentMenu
            // 
            resources.ApplyResources(this.cmsContentMenu, "cmsContentMenu");
            this.cmsContentMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executarToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.cmsContentMenu.Name = "cmsContentMenu";
            // 
            // executarToolStripMenuItem
            // 
            resources.ApplyResources(this.executarToolStripMenuItem, "executarToolStripMenuItem");
            this.executarToolStripMenuItem.Name = "executarToolStripMenuItem";
            this.executarToolStripMenuItem.Click += new System.EventHandler(this.ExecutarToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            resources.ApplyResources(this.fecharToolStripMenuItem, "fecharToolStripMenuItem");
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // pnLinks
            // 
            resources.ApplyResources(this.pnLinks, "pnLinks");
            this.pnLinks.BackColor = System.Drawing.Color.White;
            this.pnLinks.Name = "pnLinks";
            // 
            // pnTarefas
            // 
            resources.ApplyResources(this.pnTarefas, "pnTarefas");
            this.pnTarefas.BackColor = System.Drawing.Color.White;
            this.pnTarefas.Name = "pnTarefas";
            // 
            // pnPainel
            // 
            resources.ApplyResources(this.pnPainel, "pnPainel");
            this.pnPainel.BackColor = System.Drawing.Color.White;
            this.pnPainel.Name = "pnPainel";
            // 
            // pnSobre
            // 
            resources.ApplyResources(this.pnSobre, "pnSobre");
            this.pnSobre.BackColor = System.Drawing.Color.White;
            this.pnSobre.Name = "pnSobre";
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pnlEsquerdo);
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.pnLinks);
            this.Controls.Add(this.pnTarefas);
            this.Controls.Add(this.pnPainel);
            this.Controls.Add(this.pnSobre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.pnlEsquerdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.cmsContentMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Panel pnlEsquerdo;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.Button btnTarefas;
        private System.Windows.Forms.Button btnPainel;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnFechar;
        private Sobre pnSobre;
        private Links pnLinks;
        private Tarefas pnTarefas;
        private Painel pnPainel;
        private System.Windows.Forms.Panel pnlIndicador;
        private System.Windows.Forms.ContextMenuStrip cmsContentMenu;
        private System.Windows.Forms.ToolStripMenuItem executarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        public System.Windows.Forms.NotifyIcon icnCertwebSystemTray;
    }
}

