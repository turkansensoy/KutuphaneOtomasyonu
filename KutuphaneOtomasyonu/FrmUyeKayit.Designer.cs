
namespace KutuphaneOtomasyonu
{
    partial class FrmUyeKayit
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
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbKız = new System.Windows.Forms.RadioButton();
            this.rdbErkek = new System.Windows.Forms.RadioButton();
            this.mskDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mskTelefon
            // 
            this.mskTelefon.BackColor = System.Drawing.SystemColors.Window;
            this.mskTelefon.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTelefon.Location = new System.Drawing.Point(148, 285);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(195, 26);
            this.mskTelefon.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(80, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "Telefon:";
            // 
            // mskTc
            // 
            this.mskTc.BackColor = System.Drawing.SystemColors.Window;
            this.mskTc.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTc.Location = new System.Drawing.Point(148, 144);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(195, 26);
            this.mskTc.TabIndex = 42;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(110, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 41;
            this.label4.Text = "TC:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BackColor = System.Drawing.SystemColors.Window;
            this.txtAdSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(148, 102);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(195, 26);
            this.txtAdSoyad.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(67, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "Ad Soyad:";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.SystemColors.Window;
            this.txtMail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(148, 176);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(195, 26);
            this.txtMail.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(99, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 47;
            this.label7.Text = "Mail:";
            // 
            // cmbBolum
            // 
            this.cmbBolum.BackColor = System.Drawing.SystemColors.Window;
            this.cmbBolum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Location = new System.Drawing.Point(148, 253);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(195, 26);
            this.cmbBolum.TabIndex = 46;
            this.cmbBolum.Text = "Bölüm Seçiniz.";
            this.cmbBolum.SelectedIndexChanged += new System.EventHandler(this.cmbBolum_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(84, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 45;
            this.label6.Text = "Bölüm:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.Window;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(148, 364);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(105, 32);
            this.btnKaydet.TabIndex = 52;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(76, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 54;
            this.label5.Text = "Cinsiyet:";
            // 
            // rdbKız
            // 
            this.rdbKız.AutoSize = true;
            this.rdbKız.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbKız.Location = new System.Drawing.Point(163, 321);
            this.rdbKız.MinimumSize = new System.Drawing.Size(6, 5);
            this.rdbKız.Name = "rdbKız";
            this.rdbKız.Size = new System.Drawing.Size(51, 22);
            this.rdbKız.TabIndex = 56;
            this.rdbKız.TabStop = true;
            this.rdbKız.Text = " Kız";
            this.rdbKız.UseVisualStyleBackColor = true;
            // 
            // rdbErkek
            // 
            this.rdbErkek.AutoSize = true;
            this.rdbErkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbErkek.Location = new System.Drawing.Point(234, 321);
            this.rdbErkek.Name = "rdbErkek";
            this.rdbErkek.Size = new System.Drawing.Size(65, 22);
            this.rdbErkek.TabIndex = 57;
            this.rdbErkek.TabStop = true;
            this.rdbErkek.Text = "Erkek";
            this.rdbErkek.UseVisualStyleBackColor = true;
            // 
            // mskDogumTarihi
            // 
            this.mskDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskDogumTarihi.Location = new System.Drawing.Point(148, 217);
            this.mskDogumTarihi.Mask = "00/00/0000";
            this.mskDogumTarihi.Name = "mskDogumTarihi";
            this.mskDogumTarihi.Size = new System.Drawing.Size(195, 26);
            this.mskDogumTarihi.TabIndex = 58;
            this.mskDogumTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(35, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 59;
            this.label8.Text = "Doğum Tarihi:";
            // 
            // FrmUyeKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mskDogumTarihi);
            this.Controls.Add(this.rdbErkek);
            this.Controls.Add(this.rdbKız);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label1);
            this.Name = "FrmUyeKayit";
            this.Text = "FrmUyeKayit";
            this.Load += new System.EventHandler(this.FrmUyeKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbKız;
        private System.Windows.Forms.RadioButton rdbErkek;
        private System.Windows.Forms.MaskedTextBox mskDogumTarihi;
        private System.Windows.Forms.Label label8;
    }
}