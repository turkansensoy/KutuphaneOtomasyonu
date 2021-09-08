
namespace KutuphaneOtomasyonu
{
    partial class FrmKitapListesi
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
            this.txtStokSayisi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnKitapSil = new System.Windows.Forms.Button();
            this.btnKitapGüncelle = new System.Windows.Forms.Button();
            this.txtKitapYazar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYayınEvi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKitapSayfası = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mskBasimTarihi = new System.Windows.Forms.MaskedTextBox();
            this.cmbKitapRafNo = new System.Windows.Forms.ComboBox();
            this.LblKitapId = new System.Windows.Forms.Label();
            this.cmbKitapTur = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStokSayisi
            // 
            this.txtStokSayisi.BackColor = System.Drawing.SystemColors.Window;
            this.txtStokSayisi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStokSayisi.Location = new System.Drawing.Point(475, 93);
            this.txtStokSayisi.Name = "txtStokSayisi";
            this.txtStokSayisi.Size = new System.Drawing.Size(195, 26);
            this.txtStokSayisi.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(385, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 18);
            this.label9.TabIndex = 79;
            this.label9.Text = "Stok Sayısı:";
            // 
            // btnKitapSil
            // 
            this.btnKitapSil.BackColor = System.Drawing.SystemColors.Window;
            this.btnKitapSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapSil.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapSil.Location = new System.Drawing.Point(1058, 74);
            this.btnKitapSil.Name = "btnKitapSil";
            this.btnKitapSil.Size = new System.Drawing.Size(105, 32);
            this.btnKitapSil.TabIndex = 78;
            this.btnKitapSil.Text = " Kitap Sil";
            this.btnKitapSil.UseVisualStyleBackColor = false;
            this.btnKitapSil.Click += new System.EventHandler(this.btnKitapSil_Click);
            // 
            // btnKitapGüncelle
            // 
            this.btnKitapGüncelle.BackColor = System.Drawing.SystemColors.Window;
            this.btnKitapGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapGüncelle.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapGüncelle.Location = new System.Drawing.Point(1058, 16);
            this.btnKitapGüncelle.Name = "btnKitapGüncelle";
            this.btnKitapGüncelle.Size = new System.Drawing.Size(105, 32);
            this.btnKitapGüncelle.TabIndex = 77;
            this.btnKitapGüncelle.Text = "Güncelle";
            this.btnKitapGüncelle.UseVisualStyleBackColor = false;
            this.btnKitapGüncelle.Click += new System.EventHandler(this.btnKitapGüncelle_Click);
            // 
            // txtKitapYazar
            // 
            this.txtKitapYazar.BackColor = System.Drawing.SystemColors.Window;
            this.txtKitapYazar.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapYazar.Location = new System.Drawing.Point(475, 53);
            this.txtKitapYazar.Name = "txtKitapYazar";
            this.txtKitapYazar.Size = new System.Drawing.Size(195, 26);
            this.txtKitapYazar.TabIndex = 76;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(416, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 75;
            this.label8.Text = "Yazar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(45, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 18);
            this.label7.TabIndex = 73;
            this.label7.Text = "Raf Numarası:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(54, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 71;
            this.label5.Text = "Basım Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(749, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 18);
            this.label6.TabIndex = 69;
            this.label6.Text = "Tür:";
            // 
            // txtYayınEvi
            // 
            this.txtYayınEvi.BackColor = System.Drawing.SystemColors.Window;
            this.txtYayınEvi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYayınEvi.Location = new System.Drawing.Point(792, 53);
            this.txtYayınEvi.Name = "txtYayınEvi";
            this.txtYayınEvi.Size = new System.Drawing.Size(195, 26);
            this.txtYayınEvi.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(707, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 67;
            this.label3.Text = "Yayın Evi:";
            // 
            // txtKitapSayfası
            // 
            this.txtKitapSayfası.BackColor = System.Drawing.SystemColors.Window;
            this.txtKitapSayfası.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapSayfası.Location = new System.Drawing.Point(792, 16);
            this.txtKitapSayfası.Name = "txtKitapSayfası";
            this.txtKitapSayfası.Size = new System.Drawing.Size(195, 26);
            this.txtKitapSayfası.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(694, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 65;
            this.label4.Text = "Sayfa Sayısı:";
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.BackColor = System.Drawing.SystemColors.Window;
            this.txtKitapAd.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAd.Location = new System.Drawing.Point(475, 12);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(195, 26);
            this.txtKitapAd.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(399, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 63;
            this.label2.Text = "Kitap Ad:";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtBarkodNo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkodNo.Location = new System.Drawing.Point(159, 15);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(195, 26);
            this.txtBarkodNo.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 61;
            this.label1.Text = "Barkod Numarası:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1202, 373);
            this.dataGridView1.TabIndex = 81;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mskBasimTarihi);
            this.panel1.Controls.Add(this.cmbKitapRafNo);
            this.panel1.Controls.Add(this.LblKitapId);
            this.panel1.Controls.Add(this.cmbKitapTur);
            this.panel1.Controls.Add(this.txtYayınEvi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtStokSayisi);
            this.panel1.Controls.Add(this.txtBarkodNo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnKitapSil);
            this.panel1.Controls.Add(this.txtKitapAd);
            this.panel1.Controls.Add(this.btnKitapGüncelle);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtKitapYazar);
            this.panel1.Controls.Add(this.txtKitapSayfası);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 153);
            this.panel1.TabIndex = 82;
            // 
            // mskBasimTarihi
            // 
            this.mskBasimTarihi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskBasimTarihi.Location = new System.Drawing.Point(159, 93);
            this.mskBasimTarihi.Mask = "00/00/0000";
            this.mskBasimTarihi.Name = "mskBasimTarihi";
            this.mskBasimTarihi.Size = new System.Drawing.Size(195, 26);
            this.mskBasimTarihi.TabIndex = 107;
            this.mskBasimTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // cmbKitapRafNo
            // 
            this.cmbKitapRafNo.BackColor = System.Drawing.SystemColors.Window;
            this.cmbKitapRafNo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKitapRafNo.FormattingEnabled = true;
            this.cmbKitapRafNo.Location = new System.Drawing.Point(159, 53);
            this.cmbKitapRafNo.Name = "cmbKitapRafNo";
            this.cmbKitapRafNo.Size = new System.Drawing.Size(195, 26);
            this.cmbKitapRafNo.TabIndex = 105;
            this.cmbKitapRafNo.SelectedIndexChanged += new System.EventHandler(this.cmbKitapRafNo_SelectedIndexChanged);
            // 
            // LblKitapId
            // 
            this.LblKitapId.AutoSize = true;
            this.LblKitapId.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblKitapId.Location = new System.Drawing.Point(371, 38);
            this.LblKitapId.Name = "LblKitapId";
            this.LblKitapId.Size = new System.Drawing.Size(56, 18);
            this.LblKitapId.TabIndex = 82;
            this.LblKitapId.Text = "kitapId";
            this.LblKitapId.Visible = false;
            // 
            // cmbKitapTur
            // 
            this.cmbKitapTur.BackColor = System.Drawing.SystemColors.Window;
            this.cmbKitapTur.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKitapTur.FormattingEnabled = true;
            this.cmbKitapTur.Location = new System.Drawing.Point(792, 94);
            this.cmbKitapTur.Name = "cmbKitapTur";
            this.cmbKitapTur.Size = new System.Drawing.Size(195, 26);
            this.cmbKitapTur.TabIndex = 81;
            this.cmbKitapTur.Text = "Bölüm Seçiniz.";
            this.cmbKitapTur.SelectedIndexChanged += new System.EventHandler(this.cmbKitapTur_SelectedIndexChanged_1);
            // 
            // FrmKitapListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 543);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmKitapListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Listesi";
            this.Load += new System.EventHandler(this.FrmKitapListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtStokSayisi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnKitapSil;
        private System.Windows.Forms.Button btnKitapGüncelle;
        private System.Windows.Forms.TextBox txtKitapYazar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYayınEvi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKitapSayfası;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbKitapTur;
        private System.Windows.Forms.Label LblKitapId;
        private System.Windows.Forms.ComboBox cmbKitapRafNo;
        private System.Windows.Forms.MaskedTextBox mskBasimTarihi;
    }
}