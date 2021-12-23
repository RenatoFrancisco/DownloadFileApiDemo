namespace DownloadFileFormsDemo
{
    partial class DownloadForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDownload = new System.Windows.Forms.Button();
            this.txtSearchFileAt = new System.Windows.Forms.TextBox();
            this.txtSaveFileAt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.SystemColors.Control;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDownload.Location = new System.Drawing.Point(384, 186);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(101, 42);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "&Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // txtSearchFileAt
            // 
            this.txtSearchFileAt.Location = new System.Drawing.Point(35, 54);
            this.txtSearchFileAt.Name = "txtSearchFileAt";
            this.txtSearchFileAt.Size = new System.Drawing.Size(450, 23);
            this.txtSearchFileAt.TabIndex = 1;
            // 
            // txtSaveFileAt
            // 
            this.txtSaveFileAt.Location = new System.Drawing.Point(35, 134);
            this.txtSaveFileAt.Name = "txtSaveFileAt";
            this.txtSaveFileAt.Size = new System.Drawing.Size(450, 23);
            this.txtSaveFileAt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar arquivo em:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(36, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salvar arquivo em:";
            // 
            // DownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 256);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaveFileAt);
            this.Controls.Add(this.txtSearchFileAt);
            this.Controls.Add(this.btnDownload);
            this.Name = "DownloadForm";
            this.Text = "Download de Arquivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDownload;
        private TextBox txtSearchFileAt;
        private TextBox txtSaveFileAt;
        private Label label1;
        private Label label3;
    }
}