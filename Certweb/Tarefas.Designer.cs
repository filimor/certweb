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
            this.flpLinks = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLinks = new System.Windows.Forms.Label();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.prgProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // flpLinks
            // 
            this.flpLinks.AutoScroll = true;
            this.flpLinks.AutoSize = true;
            this.flpLinks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpLinks.Location = new System.Drawing.Point(16, 91);
            this.flpLinks.Name = "flpLinks";
            this.flpLinks.Size = new System.Drawing.Size(519, 365);
            this.flpLinks.TabIndex = 6;
            // 
            // lblLinks
            // 
            this.lblLinks.AutoSize = true;
            this.lblLinks.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinks.Location = new System.Drawing.Point(3, 10);
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
            this.btnExecutar.Location = new System.Drawing.Point(554, 184);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(157, 151);
            this.btnExecutar.TabIndex = 7;
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.BtnExecutar_Click);
            // 
            // prgProgressBar
            // 
            this.prgProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.prgProgressBar.Location = new System.Drawing.Point(554, 368);
            this.prgProgressBar.Name = "prgProgressBar";
            this.prgProgressBar.Size = new System.Drawing.Size(165, 17);
            this.prgProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgProgressBar.TabIndex = 8;
            // 
            // Tarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.prgProgressBar);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.flpLinks);
            this.Controls.Add(this.lblLinks);
            this.Name = "Tarefas";
            this.Size = new System.Drawing.Size(735, 477);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpLinks;
        private System.Windows.Forms.Label lblLinks;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.ProgressBar prgProgressBar;
    }
}
