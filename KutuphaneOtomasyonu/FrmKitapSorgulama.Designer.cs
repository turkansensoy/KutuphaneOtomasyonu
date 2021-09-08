
namespace KutuphaneOtomasyonu
{
    partial class FrmKitapSorgulama
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKitapSorgulama));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAra = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbAramaTürü = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnListele);
            this.panel2.Controls.Add(this.btnAra);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtArama);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cmbAramaTürü);
            this.panel2.Location = new System.Drawing.Point(224, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 67);
            this.panel2.TabIndex = 89;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.ImageIndex = 0;
            this.btnAra.ImageList = this.ımageList1;
            this.btnAra.Location = new System.Drawing.Point(603, 20);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(42, 26);
            this.btnAra.TabIndex = 90;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "seach.png");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(317, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 18);
            this.label11.TabIndex = 85;
            this.label11.Text = "Arama:";
            // 
            // txtArama
            // 
            this.txtArama.BackColor = System.Drawing.SystemColors.Window;
            this.txtArama.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.Location = new System.Drawing.Point(382, 19);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(203, 26);
            this.txtArama.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(20, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 18);
            this.label10.TabIndex = 87;
            this.label10.Text = "Arama Türü:";
            // 
            // cmbAramaTürü
            // 
            this.cmbAramaTürü.FormattingEnabled = true;
            this.cmbAramaTürü.Items.AddRange(new object[] {
            "Numara",
            "Barkod Numarası",
            "Kitap Ad",
            "Yazar",
            "Yayın Evi",
            "Kitap Türü",
            "Basım Tarihi",
            "Raf No "});
            this.cmbAramaTürü.Location = new System.Drawing.Point(122, 23);
            this.cmbAramaTürü.Name = "cmbAramaTürü";
            this.cmbAramaTürü.Size = new System.Drawing.Size(168, 21);
            this.cmbAramaTürü.TabIndex = 84;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1211, 407);
            this.dataGridView1.TabIndex = 90;
            // 
            // btnListele
            // 
            this.btnListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(686, 11);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(87, 43);
            this.btnListele.TabIndex = 91;
            this.btnListele.Text = "Kitapları Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // FrmKitapSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1211, 492);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmKitapSorgulama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKitapSorgulama";
            this.Load += new System.EventHandler(this.FrmKitapSorgulama_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbAramaTürü;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListele;
    }
}