namespace Certweb
{
    partial class Links
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.lblLinks = new System.Windows.Forms.Label();
            this.flpLinks = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(627, 68);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 33);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(17, 15);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(300, 37);
            this.txtDescricao.TabIndex = 1;
            this.txtDescricao.Text = "Descrição";
            // 
            // txtLink
            // 
            this.txtLink.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLink.Location = new System.Drawing.Point(323, 15);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(392, 37);
            this.txtLink.TabIndex = 2;
            this.txtLink.Text = "Link";
            // 
            // lblLinks
            // 
            this.lblLinks.AutoSize = true;
            this.lblLinks.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinks.Location = new System.Drawing.Point(4, 102);
            this.lblLinks.Name = "lblLinks";
            this.lblLinks.Size = new System.Drawing.Size(173, 78);
            this.lblLinks.TabIndex = 3;
            this.lblLinks.Text = "Links";
            // 
            // flpLinks
            // 
            this.flpLinks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpLinks.Location = new System.Drawing.Point(17, 183);
            this.flpLinks.Name = "flpLinks";
            this.flpLinks.Size = new System.Drawing.Size(698, 281);
            this.flpLinks.TabIndex = 4;
            // 
            // Links
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flpLinks);
            this.Controls.Add(this.lblLinks);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnSalvar);
            this.Name = "Links";
            this.Size = new System.Drawing.Size(735, 477);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label lblLinks;
        private System.Windows.Forms.FlowLayoutPanel flpLinks;
    }
}
