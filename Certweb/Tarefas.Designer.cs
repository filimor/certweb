namespace Certweb
{
    partial class Tarefas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tarefas));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLink = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblLinks = new System.Windows.Forms.Label();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 93);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(507, 363);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLink);
            this.panel1.Controls.Add(this.lblDescricao);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 20);
            this.panel1.TabIndex = 5;
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLink.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblLink.Location = new System.Drawing.Point(140, 0);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(204, 13);
            this.lblLink.TabIndex = 3;
            this.lblLink.Text = "http://www.cursodewindowsforms.com.br";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDescricao.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(0, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(140, 16);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Curso de Windows Forms";
            // 
            // lblLinks
            // 
            this.lblLinks.AutoSize = true;
            this.lblLinks.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinks.Location = new System.Drawing.Point(3, 12);
            this.lblLinks.Name = "lblLinks";
            this.lblLinks.Size = new System.Drawing.Size(173, 78);
            this.lblLinks.TabIndex = 5;
            this.lblLinks.Text = "Links";
            // 
            // btnExecutar
            // 
            this.btnExecutar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExecutar.BackgroundImage")));
            this.btnExecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExecutar.FlatAppearance.BorderSize = 0;
            this.btnExecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecutar.Location = new System.Drawing.Point(554, 93);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(157, 151);
            this.btnExecutar.TabIndex = 7;
            this.btnExecutar.UseVisualStyleBackColor = true;
            // 
            // Tarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblLinks);
            this.Name = "Tarefas";
            this.Size = new System.Drawing.Size(735, 477);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblLinks;
        private System.Windows.Forms.Button btnExecutar;
    }
}
