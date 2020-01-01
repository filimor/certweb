namespace Certweb
{
    partial class Sobre
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSobre = new System.Windows.Forms.Label();
            this.lblParticipacao = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblAutorNome = new System.Windows.Forms.Label();
            this.lblAutorEmail = new System.Windows.Forms.Label();
            this.lblIcones = new System.Windows.Forms.Label();
            this.lblIconesAutor = new System.Windows.Forms.Label();
            this.llbIconesLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblSobre
            // 
            this.lblSobre.AutoSize = true;
            this.lblSobre.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobre.Location = new System.Drawing.Point(13, 14);
            this.lblSobre.Name = "lblSobre";
            this.lblSobre.Size = new System.Drawing.Size(212, 78);
            this.lblSobre.TabIndex = 0;
            this.lblSobre.Text = "Sobre";
            // 
            // lblParticipacao
            // 
            this.lblParticipacao.AutoSize = true;
            this.lblParticipacao.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipacao.Location = new System.Drawing.Point(365, 45);
            this.lblParticipacao.Name = "lblParticipacao";
            this.lblParticipacao.Size = new System.Drawing.Size(241, 42);
            this.lblParticipacao.TabIndex = 1;
            this.lblParticipacao.Text = "Participação";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(23, 133);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(226, 16);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Programa para acessar links sem timeout";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(369, 121);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(39, 15);
            this.lblAutor.TabIndex = 3;
            this.lblAutor.Text = "Autor:";
            // 
            // lblAutorNome
            // 
            this.lblAutorNome.AutoSize = true;
            this.lblAutorNome.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorNome.Location = new System.Drawing.Point(369, 136);
            this.lblAutorNome.Name = "lblAutorNome";
            this.lblAutorNome.Size = new System.Drawing.Size(78, 16);
            this.lblAutorNome.TabIndex = 4;
            this.lblAutorNome.Text = "Filipe Moreira";
            // 
            // lblAutorEmail
            // 
            this.lblAutorEmail.AutoSize = true;
            this.lblAutorEmail.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorEmail.Location = new System.Drawing.Point(369, 152);
            this.lblAutorEmail.Name = "lblAutorEmail";
            this.lblAutorEmail.Size = new System.Drawing.Size(125, 16);
            this.lblAutorEmail.TabIndex = 5;
            this.lblAutorEmail.Text = "filimor@posteo.com.br";
            // 
            // lblIcones
            // 
            this.lblIcones.AutoSize = true;
            this.lblIcones.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIcones.Location = new System.Drawing.Point(369, 189);
            this.lblIcones.Name = "lblIcones";
            this.lblIcones.Size = new System.Drawing.Size(66, 15);
            this.lblIcones.TabIndex = 6;
            this.lblIcones.Text = "Ícones por:";
            // 
            // lblIconesAutor
            // 
            this.lblIconesAutor.AutoSize = true;
            this.lblIconesAutor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconesAutor.Location = new System.Drawing.Point(369, 204);
            this.lblIconesAutor.Name = "lblIconesAutor";
            this.lblIconesAutor.Size = new System.Drawing.Size(113, 16);
            this.lblIconesAutor.TabIndex = 7;
            this.lblIconesAutor.Text = "SimpleIcon - CC 3.0";
            // 
            // llbIconesLink
            // 
            this.llbIconesLink.AutoSize = true;
            this.llbIconesLink.Location = new System.Drawing.Point(369, 220);
            this.llbIconesLink.Name = "llbIconesLink";
            this.llbIconesLink.Size = new System.Drawing.Size(221, 13);
            this.llbIconesLink.TabIndex = 8;
            this.llbIconesLink.TabStop = true;
            this.llbIconesLink.Text = "https://www.flaticon.com/authors/simpleicon";
            // 
            // Sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.llbIconesLink);
            this.Controls.Add(this.lblIconesAutor);
            this.Controls.Add(this.lblIcones);
            this.Controls.Add(this.lblAutorEmail);
            this.Controls.Add(this.lblAutorNome);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblParticipacao);
            this.Controls.Add(this.lblSobre);
            this.Name = "Sobre";
            this.Size = new System.Drawing.Size(735, 477);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSobre;
        private System.Windows.Forms.Label lblParticipacao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblAutorNome;
        private System.Windows.Forms.Label lblAutorEmail;
        private System.Windows.Forms.Label lblIcones;
        private System.Windows.Forms.Label lblIconesAutor;
        private System.Windows.Forms.LinkLabel llbIconesLink;
    }
}
