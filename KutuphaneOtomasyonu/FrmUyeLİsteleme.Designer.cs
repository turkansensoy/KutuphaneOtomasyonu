
namespace KutuphaneOtomasyonu
{
    partial class FrmUyeLİsteleme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.rbKız = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUyeSil = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.mskDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.lblUyeId = new System.Windows.Forms.Label();
            this.btnUyeGüncelleme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(341, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(931, 319);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbErkek.Location = new System.Drawing.Point(196, 235);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(65, 22);
            this.rbErkek.TabIndex = 72;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKız
            // 
            this.rbKız.AutoSize = true;
            this.rbKız.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKız.Location = new System.Drawing.Point(128, 235);
            this.rbKız.MinimumSize = new System.Drawing.Size(6, 5);
            this.rbKız.Name = "rbKız";
            this.rbKız.Size = new System.Drawing.Size(51, 22);
            this.rbKız.TabIndex = 71;
            this.rbKız.TabStop = true;
            this.rbKız.Text = " Kız";
            this.rbKız.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(43, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 70;
            this.label5.Text = "Cinsiyet:";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.SystemColors.Window;
            this.txtMail.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(115, 101);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(195, 26);
            this.txtMail.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(66, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 68;
            this.label7.Text = "Mail:";
            // 
            // cmbBolum
            // 
            this.cmbBolum.BackColor = System.Drawing.SystemColors.Window;
            this.cmbBolum.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Location = new System.Drawing.Point(115, 165);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(195, 26);
            this.cmbBolum.TabIndex = 67;
            this.cmbBolum.SelectedIndexChanged += new System.EventHandler(this.cmbBolum_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(47, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 66;
            this.label6.Text = " Bölüm:";
            // 
            // mskTelefon
            // 
            this.mskTelefon.BackColor = System.Drawing.SystemColors.Window;
            this.mskTelefon.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTelefon.Location = new System.Drawing.Point(115, 197);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(195, 26);
            this.mskTelefon.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 64;
            this.label3.Text = "Telefon:";
            // 
            // mskTc
            // 
            this.mskTc.BackColor = System.Drawing.SystemColors.Window;
            this.mskTc.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTc.Location = new System.Drawing.Point(115, 69);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(195, 26);
            this.mskTc.TabIndex = 63;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(77, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 62;
            this.label4.Text = "TC:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BackColor = System.Drawing.SystemColors.Window;
            this.txtAdSoyad.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(115, 37);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(195, 26);
            this.txtAdSoyad.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 60;
            this.label2.Text = "Ad Soyad:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUyeSil);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.mskDogumTarihi);
            this.panel1.Controls.Add(this.lblUyeId);
            this.panel1.Controls.Add(this.btnUyeGüncelleme);
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Controls.Add(this.rbErkek);
            this.panel1.Controls.Add(this.rbKız);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAdSoyad);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbBolum);
            this.panel1.Controls.Add(this.mskTc);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mskTelefon);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 319);
            this.panel1.TabIndex = 74;
            // 
            // btnUyeSil
            // 
            this.btnUyeSil.BackColor = System.Drawing.SystemColors.Window;
            this.btnUyeSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeSil.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeSil.Location = new System.Drawing.Point(184, 278);
            this.btnUyeSil.Name = "btnUyeSil";
            this.btnUyeSil.Size = new System.Drawing.Size(105, 32);
            this.btnUyeSil.TabIndex = 78;
            this.btnUyeSil.Text = "Üye Sil";
            this.btnUyeSil.UseVisualStyleBackColor = false;
            this.btnUyeSil.Click += new System.EventHandler(this.btnUyeSil_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(2, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 77;
            this.label8.Text = "Doğum Tarihi:";
            // 
            // mskDogumTarihi
            // 
            this.mskDogumTarihi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskDogumTarihi.Location = new System.Drawing.Point(115, 133);
            this.mskDogumTarihi.Mask = "00/00/0000";
            this.mskDogumTarihi.Name = "mskDogumTarihi";
            this.mskDogumTarihi.Size = new System.Drawing.Size(195, 26);
            this.mskDogumTarihi.TabIndex = 76;
            this.mskDogumTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // lblUyeId
            // 
            this.lblUyeId.AutoSize = true;
            this.lblUyeId.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyeId.Location = new System.Drawing.Point(229, 16);
            this.lblUyeId.Name = "lblUyeId";
            this.lblUyeId.Size = new System.Drawing.Size(23, 18);
            this.lblUyeId.TabIndex = 75;
            this.lblUyeId.Text = "Id";
            this.lblUyeId.Visible = false;
            // 
            // btnUyeGüncelleme
            // 
            this.btnUyeGüncelleme.BackColor = System.Drawing.SystemColors.Window;
            this.btnUyeGüncelleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeGüncelleme.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeGüncelleme.Location = new System.Drawing.Point(50, 278);
            this.btnUyeGüncelleme.Name = "btnUyeGüncelleme";
            this.btnUyeGüncelleme.Size = new System.Drawing.Size(105, 32);
            this.btnUyeGüncelleme.TabIndex = 74;
            this.btnUyeGüncelleme.Text = "Güncelle";
            this.btnUyeGüncelleme.UseVisualStyleBackColor = false;
            this.btnUyeGüncelleme.Click += new System.EventHandler(this.btnUyeGüncelleme_Click);
            // 
            // FrmUyeLİsteleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 357);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmUyeLİsteleme";
            this.Load += new System.EventHandler(this.FrmUyeLİsteleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.RadioButton rbKız;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUyeGüncelleme;
        private System.Windows.Forms.Label lblUyeId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskDogumTarihi;
        private System.Windows.Forms.Button btnUyeSil;
    }
}