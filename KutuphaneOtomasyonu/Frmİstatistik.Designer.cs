
namespace KutuphaneOtomasyonu
{
    partial class Frmİstatistik
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
            this.lblEnCokOkunanKitap = new System.Windows.Forms.Label();
            this.lblEnCokKitapOkuyan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnCokOkunanKitap
            // 
            this.lblEnCokOkunanKitap.AutoSize = true;
            this.lblEnCokOkunanKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnCokOkunanKitap.ForeColor = System.Drawing.Color.Red;
            this.lblEnCokOkunanKitap.Location = new System.Drawing.Point(108, 68);
            this.lblEnCokOkunanKitap.Name = "lblEnCokOkunanKitap";
            this.lblEnCokOkunanKitap.Size = new System.Drawing.Size(260, 29);
            this.lblEnCokOkunanKitap.TabIndex = 0;
            this.lblEnCokOkunanKitap.Text = "En Çok Okunan Kitap";
            // 
            // lblEnCokKitapOkuyan
            // 
            this.lblEnCokKitapOkuyan.AutoSize = true;
            this.lblEnCokKitapOkuyan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnCokKitapOkuyan.ForeColor = System.Drawing.Color.Red;
            this.lblEnCokKitapOkuyan.Location = new System.Drawing.Point(52, 139);
            this.lblEnCokKitapOkuyan.Name = "lblEnCokKitapOkuyan";
            this.lblEnCokKitapOkuyan.Size = new System.Drawing.Size(316, 29);
            this.lblEnCokKitapOkuyan.TabIndex = 1;
            this.lblEnCokKitapOkuyan.Text = "En Çok Kitap Okuyan Kişi ";
            // 
            // Frmİstatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.lblEnCokKitapOkuyan);
            this.Controls.Add(this.lblEnCokOkunanKitap);
            this.Name = "Frmİstatistik";
            this.Load += new System.EventHandler(this.Frmİstatistik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnCokOkunanKitap;
        private System.Windows.Forms.Label lblEnCokKitapOkuyan;
    }
}