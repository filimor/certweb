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
            this.pnSobre = new Certweb.Sobre();
            this.pnTarefas = new Certweb.Tarefas();
            this.pnLinks = new Certweb.Links();
            this.pnPainel = new Certweb.Painel();
            this.pnlEsquerdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(982, 15);
            this.pnlSuperior.TabIndex = 0;
            this.pnlSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlSuperior_MouseDown);
            this.pnlSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlSuperior_MouseMove);
            this.pnlSuperior.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnlSuperior_MouseUp);
            // 
            // pnlEsquerdo
            // 
            this.pnlEsquerdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.pnlEsquerdo.Controls.Add(this.btnSobre);
            this.pnlEsquerdo.Controls.Add(this.btnLink);
            this.pnlEsquerdo.Controls.Add(this.btnTarefas);
            this.pnlEsquerdo.Controls.Add(this.btnPainel);
            this.pnlEsquerdo.Controls.Add(this.pnlIndicador);
            this.pnlEsquerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerdo.Location = new System.Drawing.Point(0, 15);
            this.pnlEsquerdo.Name = "pnlEsquerdo";
            this.pnlEsquerdo.Size = new System.Drawing.Size(229, 593);
            this.pnlEsquerdo.TabIndex = 1;
            // 
            // btnSobre
            // 
            this.btnSobre.FlatAppearance.BorderSize = 0;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.Color.White;
            this.btnSobre.Image = ((System.Drawing.Image)(resources.GetObject("btnSobre.Image")));
            this.btnSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSobre.Location = new System.Drawing.Point(38, 494);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(161, 54);
            this.btnSobre.TabIndex = 3;
            this.btnSobre.Text = "          Sobre";
            this.btnSobre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.BtnSobre_Click);
            // 
            // btnLink
            // 
            this.btnLink.FlatAppearance.BorderSize = 0;
            this.btnLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLink.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLink.ForeColor = System.Drawing.Color.White;
            this.btnLink.Image = ((System.Drawing.Image)(resources.GetObject("btnLink.Image")));
            this.btnLink.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLink.Location = new System.Drawing.Point(38, 340);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(161, 54);
            this.btnLink.TabIndex = 2;
            this.btnLink.Text = "          Link";
            this.btnLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.BtnLink_Click);
            // 
            // btnTarefas
            // 
            this.btnTarefas.FlatAppearance.BorderSize = 0;
            this.btnTarefas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarefas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarefas.ForeColor = System.Drawing.Color.White;
            this.btnTarefas.Image = ((System.Drawing.Image)(resources.GetObject("btnTarefas.Image")));
            this.btnTarefas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTarefas.Location = new System.Drawing.Point(38, 186);
            this.btnTarefas.Name = "btnTarefas";
            this.btnTarefas.Size = new System.Drawing.Size(161, 54);
            this.btnTarefas.TabIndex = 1;
            this.btnTarefas.Text = "          Tarefas";
            this.btnTarefas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTarefas.UseVisualStyleBackColor = true;
            this.btnTarefas.Click += new System.EventHandler(this.BtnTarefas_Click);
            // 
            // btnPainel
            // 
            this.btnPainel.FlatAppearance.BorderSize = 0;
            this.btnPainel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPainel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPainel.ForeColor = System.Drawing.Color.White;
            this.btnPainel.Image = ((System.Drawing.Image)(resources.GetObject("btnPainel.Image")));
            this.btnPainel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPainel.Location = new System.Drawing.Point(38, 32);
            this.btnPainel.Name = "btnPainel";
            this.btnPainel.Size = new System.Drawing.Size(161, 54);
            this.btnPainel.TabIndex = 0;
            this.btnPainel.Text = "          Painel";
            this.btnPainel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPainel.UseVisualStyleBackColor = true;
            this.btnPainel.Click += new System.EventHandler(this.BtnPainel_Click);
            // 
            // pnlIndicador
            // 
            this.pnlIndicador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.pnlIndicador.Location = new System.Drawing.Point(21, 17);
            this.pnlIndicador.Name = "pnlIndicador";
            this.pnlIndicador.Size = new System.Drawing.Size(11, 81);
            this.pnlIndicador.TabIndex = 4;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(247, 14);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(115, 99);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(941, 21);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(29, 28);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // pnSobre
            // 
            this.pnSobre.BackColor = System.Drawing.Color.White;
            this.pnSobre.Location = new System.Drawing.Point(235, 119);
            this.pnSobre.Name = "pnSobre";
            this.pnSobre.Size = new System.Drawing.Size(735, 477);
            this.pnSobre.TabIndex = 5;
            // 
            // pnTarefas
            // 
            this.pnTarefas.BackColor = System.Drawing.Color.White;
            this.pnTarefas.Location = new System.Drawing.Point(235, 119);
            this.pnTarefas.Name = "pnTarefas";
            this.pnTarefas.Size = new System.Drawing.Size(735, 477);
            this.pnTarefas.TabIndex = 7;
            // 
            // pnLinks
            // 
            this.pnLinks.BackColor = System.Drawing.Color.White;
            this.pnLinks.Location = new System.Drawing.Point(235, 119);
            this.pnLinks.Name = "pnLinks";
            this.pnLinks.Size = new System.Drawing.Size(735, 477);
            this.pnLinks.TabIndex = 9;
            // 
            // pnPainel
            // 
            this.pnPainel.BackColor = System.Drawing.Color.White;
            this.pnPainel.Location = new System.Drawing.Point(235, 21);
            this.pnPainel.Name = "pnPainel";
            this.pnPainel.Size = new System.Drawing.Size(735, 575);
            this.pnPainel.TabIndex = 8;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 608);
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
            this.Text = "Form1";
            this.pnlEsquerdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
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
    }
}

