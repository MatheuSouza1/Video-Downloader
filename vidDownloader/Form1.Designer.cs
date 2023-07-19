namespace vidDownloader
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPath = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.txtBoxLink = new System.Windows.Forms.TextBox();
            this.txtBoxPath = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPath.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPath.Location = new System.Drawing.Point(12, 49);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(64, 27);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "Path:";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.BackColor = System.Drawing.Color.Transparent;
            this.lblLink.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLink.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLink.Location = new System.Drawing.Point(12, 9);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(60, 27);
            this.lblLink.TabIndex = 1;
            this.lblLink.Text = "Link:";
            // 
            // txtBoxLink
            // 
            this.txtBoxLink.Location = new System.Drawing.Point(82, 6);
            this.txtBoxLink.Name = "txtBoxLink";
            this.txtBoxLink.Size = new System.Drawing.Size(551, 26);
            this.txtBoxLink.TabIndex = 3;
            // 
            // txtBoxPath
            // 
            this.txtBoxPath.Location = new System.Drawing.Point(82, 46);
            this.txtBoxPath.Name = "txtBoxPath";
            this.txtBoxPath.Size = new System.Drawing.Size(504, 26);
            this.txtBoxPath.TabIndex = 0;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.DarkRed;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Microsoft YaHei UI", 7F, System.Drawing.FontStyle.Bold);
            this.btnDownload.Location = new System.Drawing.Point(12, 79);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(182, 67);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(200, 90);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(433, 24);
            this.progressBar.TabIndex = 5;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(592, 44);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(41, 40);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "...";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(200, 126);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            this.lblStatus.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(645, 197);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.txtBoxLink);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.txtBoxPath);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.TextBox txtBoxLink;
        private System.Windows.Forms.TextBox txtBoxPath;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblStatus;
    }
}

