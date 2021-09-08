
namespace KutuphaneOtomasyonu
{
    partial class FrmEmanetKitapVerme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUyeAra = new System.Windows.Forms.Button();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblKitapId = new System.Windows.Forms.Label();
            this.LblUyeId = new System.Windows.Forms.Label();
            this.btnKitapVer = new System.Windows.Forms.Button();
            this.btnKitapAra = new System.Windows.Forms.Button();
            this.dtGelmesiGerekenTarih = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dtTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYayinEvi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUyeAra);
            this.groupBox1.Controls.Add(this.mskTc);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.mskTelefon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Bilgileri";
            // 
            // btnUyeAra
            // 
            this.btnUyeAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeAra.Location = new System.Drawing.Point(239, 16);
            this.btnUyeAra.Name = "btnUyeAra";
            this.btnUyeAra.Size = new System.Drawing.Size(43, 26);
            this.btnUyeAra.TabIndex = 53;
            this.btnUyeAra.Text = "Ara";
            this.btnUyeAra.UseVisualStyleBackColor = true;
            this.btnUyeAra.Click += new System.EventHandler(this.btnUyeAra_Click);
            // 
            // mskTc
            // 
            this.mskTc.BackColor = System.Drawing.SystemColors.Window;
            this.mskTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTc.Location = new System.Drawing.Point(102, 18);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(131, 21);
            this.mskTc.TabIndex = 52;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(73, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 15);
            this.label16.TabIndex = 51;
            this.label16.Text = "TC:";
            // 
            // mskTelefon
            // 
            this.mskTelefon.BackColor = System.Drawing.SystemColors.Window;
            this.mskTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTelefon.Location = new System.Drawing.Point(102, 100);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(131, 21);
            this.mskTelefon.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "Telefon:";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.SystemColors.Window;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(102, 73);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(131, 21);
            this.txtMail.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(64, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 49;
            this.label7.Text = "Mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "Ad Soyad:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BackColor = System.Drawing.SystemColors.Window;
            this.txtAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(102, 46);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(131, 21);
            this.txtAdSoyad.TabIndex = 42;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblKitapId);
            this.groupBox2.Controls.Add(this.LblUyeId);
            this.groupBox2.Controls.Add(this.btnKitapVer);
            this.groupBox2.Controls.Add(this.btnKitapAra);
            this.groupBox2.Controls.Add(this.dtGelmesiGerekenTarih);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.dtTeslimTarihi);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtYayinEvi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtBarkodNo);
            this.groupBox2.Controls.Add(this.txtYazar);
            this.groupBox2.Controls.Add(this.txtKitapAd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(327, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 295);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Bilgileri";
            // 
            // lblKitapId
            // 
            this.lblKitapId.AutoSize = true;
            this.lblKitapId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapId.Location = new System.Drawing.Point(380, 122);
            this.lblKitapId.Name = "lblKitapId";
            this.lblKitapId.Size = new System.Drawing.Size(45, 15);
            this.lblKitapId.TabIndex = 94;
            this.lblKitapId.Text = "KitapId";
            this.lblKitapId.Visible = false;
            // 
            // LblUyeId
            // 
            this.LblUyeId.AutoSize = true;
            this.LblUyeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUyeId.Location = new System.Drawing.Point(380, 95);
            this.LblUyeId.Name = "LblUyeId";
            this.LblUyeId.Size = new System.Drawing.Size(38, 15);
            this.LblUyeId.TabIndex = 93;
            this.LblUyeId.Text = "UyeId";
            this.LblUyeId.Visible = false;
            // 
            // btnKitapVer
            // 
            this.btnKitapVer.BackColor = System.Drawing.SystemColors.Window;
            this.btnKitapVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapVer.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapVer.Location = new System.Drawing.Point(158, 226);
            this.btnKitapVer.Name = "btnKitapVer";
            this.btnKitapVer.Size = new System.Drawing.Size(94, 32);
            this.btnKitapVer.TabIndex = 79;
            this.btnKitapVer.Text = "Kitap Ver";
            this.btnKitapVer.UseVisualStyleBackColor = false;
            this.btnKitapVer.Click += new System.EventHandler(this.btnKitapVer_Click);
            // 
            // btnKitapAra
            // 
            this.btnKitapAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapAra.Location = new System.Drawing.Point(369, 41);
            this.btnKitapAra.Name = "btnKitapAra";
            this.btnKitapAra.Size = new System.Drawing.Size(42, 23);
            this.btnKitapAra.TabIndex = 92;
            this.btnKitapAra.Text = "Ara";
            this.btnKitapAra.UseVisualStyleBackColor = true;
            this.btnKitapAra.Click += new System.EventHandler(this.btnKitapAra_Click);
            // 
            // dtGelmesiGerekenTarih
            // 
            this.dtGelmesiGerekenTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtGelmesiGerekenTarih.Location = new System.Drawing.Point(158, 190);
            this.dtGelmesiGerekenTarih.Name = "dtGelmesiGerekenTarih";
            this.dtGelmesiGerekenTarih.Size = new System.Drawing.Size(190, 18);
            this.dtGelmesiGerekenTarih.TabIndex = 91;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(12, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 15);
            this.label15.TabIndex = 90;
            this.label15.Text = "Gelmesi Gereken Tarihi:";
            // 
            // dtTeslimTarihi
            // 
            this.dtTeslimTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTeslimTarihi.Location = new System.Drawing.Point(158, 163);
            this.dtTeslimTarihi.Name = "dtTeslimTarihi";
            this.dtTeslimTarihi.Size = new System.Drawing.Size(190, 18);
            this.dtTeslimTarihi.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(71, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 15);
            this.label9.TabIndex = 87;
            this.label9.Text = "Teslim Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(94, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 85;
            this.label6.Text = "Yayın Evi:";
            // 
            // txtYayinEvi
            // 
            this.txtYayinEvi.BackColor = System.Drawing.SystemColors.Window;
            this.txtYayinEvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYayinEvi.Location = new System.Drawing.Point(158, 134);
            this.txtYayinEvi.Name = "txtYayinEvi";
            this.txtYayinEvi.Size = new System.Drawing.Size(190, 21);
            this.txtYayinEvi.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(111, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 83;
            this.label8.Text = "Yazar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(97, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 79;
            this.label4.Text = "Kitap Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(84, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 77;
            this.label2.Text = "Barkod No:";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtBarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkodNo.Location = new System.Drawing.Point(158, 43);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(190, 21);
            this.txtBarkodNo.TabIndex = 78;
            // 
            // txtYazar
            // 
            this.txtYazar.BackColor = System.Drawing.SystemColors.Window;
            this.txtYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazar.Location = new System.Drawing.Point(158, 107);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(190, 21);
            this.txtYazar.TabIndex = 84;
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.BackColor = System.Drawing.SystemColors.Window;
            this.txtKitapAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAd.Location = new System.Drawing.Point(158, 78);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(190, 21);
            this.txtKitapAd.TabIndex = 80;
            // 
            // FrmEmanetKitapVerme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 439);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEmanetKitapVerme";
            this.Load += new System.EventHandler(this.FrmEmanetKitapVerme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYayinEvi;
        private System.Windows.Forms.DateTimePicker dtTeslimTarihi;
        private System.Windows.Forms.Button btnKitapVer;
        private System.Windows.Forms.DateTimePicker dtGelmesiGerekenTarih;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnUyeAra;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnKitapAra;
        private System.Windows.Forms.Label lblKitapId;
        private System.Windows.Forms.Label LblUyeId;
        private System.Windows.Forms.Label label4;
    }
}