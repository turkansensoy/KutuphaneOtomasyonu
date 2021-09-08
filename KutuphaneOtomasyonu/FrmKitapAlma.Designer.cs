
namespace KutuphaneOtomasyonu
{
    partial class FrmKitapAlma
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
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtGelmesiGerekenTarih = new System.Windows.Forms.DateTimePicker();
            this.dtIadeTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblKitapId = new System.Windows.Forms.Label();
            this.LblUyeId = new System.Windows.Forms.Label();
            this.btnKitapAl = new System.Windows.Forms.Button();
            this.btnKitapAra = new System.Windows.Forms.Button();
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
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(93, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 15);
            this.label10.TabIndex = 107;
            this.label10.Text = "İade Tarihi:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(21, 219);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 15);
            this.label15.TabIndex = 106;
            this.label15.Text = "Gelmesi Gereken Tarihi:";
            // 
            // dtGelmesiGerekenTarih
            // 
            this.dtGelmesiGerekenTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtGelmesiGerekenTarih.Location = new System.Drawing.Point(167, 217);
            this.dtGelmesiGerekenTarih.Name = "dtGelmesiGerekenTarih";
            this.dtGelmesiGerekenTarih.Size = new System.Drawing.Size(190, 18);
            this.dtGelmesiGerekenTarih.TabIndex = 109;
            // 
            // dtIadeTarihi
            // 
            this.dtIadeTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtIadeTarihi.Location = new System.Drawing.Point(167, 241);
            this.dtIadeTarihi.Name = "dtIadeTarihi";
            this.dtIadeTarihi.Size = new System.Drawing.Size(190, 18);
            this.dtIadeTarihi.TabIndex = 108;
            // 
            // lblKitapId
            // 
            this.lblKitapId.AutoSize = true;
            this.lblKitapId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapId.Location = new System.Drawing.Point(389, 146);
            this.lblKitapId.Name = "lblKitapId";
            this.lblKitapId.Size = new System.Drawing.Size(45, 15);
            this.lblKitapId.TabIndex = 112;
            this.lblKitapId.Text = "KitapId";
            this.lblKitapId.Visible = false;
            // 
            // LblUyeId
            // 
            this.LblUyeId.AutoSize = true;
            this.LblUyeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUyeId.Location = new System.Drawing.Point(389, 119);
            this.LblUyeId.Name = "LblUyeId";
            this.LblUyeId.Size = new System.Drawing.Size(38, 15);
            this.LblUyeId.TabIndex = 111;
            this.LblUyeId.Text = "UyeId";
            this.LblUyeId.Visible = false;
            // 
            // btnKitapAl
            // 
            this.btnKitapAl.BackColor = System.Drawing.SystemColors.Window;
            this.btnKitapAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapAl.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapAl.Location = new System.Drawing.Point(167, 280);
            this.btnKitapAl.Name = "btnKitapAl";
            this.btnKitapAl.Size = new System.Drawing.Size(94, 32);
            this.btnKitapAl.TabIndex = 99;
            this.btnKitapAl.Text = "Kitap Al";
            this.btnKitapAl.UseVisualStyleBackColor = false;
            this.btnKitapAl.Click += new System.EventHandler(this.btnKitapAl_Click);
            // 
            // btnKitapAra
            // 
            this.btnKitapAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapAra.Location = new System.Drawing.Point(378, 65);
            this.btnKitapAra.Name = "btnKitapAra";
            this.btnKitapAra.Size = new System.Drawing.Size(42, 23);
            this.btnKitapAra.TabIndex = 110;
            this.btnKitapAra.Text = "Ara";
            this.btnKitapAra.UseVisualStyleBackColor = true;
            this.btnKitapAra.Click += new System.EventHandler(this.btnKitapAra_Click);
            // 
            // dtTeslimTarihi
            // 
            this.dtTeslimTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtTeslimTarihi.Location = new System.Drawing.Point(167, 187);
            this.dtTeslimTarihi.Name = "dtTeslimTarihi";
            this.dtTeslimTarihi.Size = new System.Drawing.Size(190, 18);
            this.dtTeslimTarihi.TabIndex = 95;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(89, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 105;
            this.label9.Text = "AlınanTarih:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(103, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 103;
            this.label6.Text = "Yayın Evi:";
            // 
            // txtYayinEvi
            // 
            this.txtYayinEvi.BackColor = System.Drawing.SystemColors.Window;
            this.txtYayinEvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYayinEvi.Location = new System.Drawing.Point(167, 158);
            this.txtYayinEvi.Name = "txtYayinEvi";
            this.txtYayinEvi.Size = new System.Drawing.Size(190, 21);
            this.txtYayinEvi.TabIndex = 104;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(120, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 101;
            this.label8.Text = "Yazar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(106, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 98;
            this.label4.Text = "Kitap Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(93, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 96;
            this.label2.Text = "Barkod No:";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtBarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkodNo.Location = new System.Drawing.Point(167, 67);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(190, 21);
            this.txtBarkodNo.TabIndex = 97;
            // 
            // txtYazar
            // 
            this.txtYazar.BackColor = System.Drawing.SystemColors.Window;
            this.txtYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazar.Location = new System.Drawing.Point(167, 131);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(190, 21);
            this.txtYazar.TabIndex = 102;
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.BackColor = System.Drawing.SystemColors.Window;
            this.txtKitapAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKitapAd.Location = new System.Drawing.Point(167, 102);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(190, 21);
            this.txtKitapAd.TabIndex = 100;
            // 
            // FrmKitapAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 353);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dtGelmesiGerekenTarih);
            this.Controls.Add(this.dtIadeTarihi);
            this.Controls.Add(this.lblKitapId);
            this.Controls.Add(this.LblUyeId);
            this.Controls.Add(this.btnKitapAl);
            this.Controls.Add(this.btnKitapAra);
            this.Controls.Add(this.dtTeslimTarihi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtYayinEvi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtKitapAd);
            this.Name = "FrmKitapAlma";
            this.Load += new System.EventHandler(this.FrmKitapAlma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtGelmesiGerekenTarih;
        private System.Windows.Forms.DateTimePicker dtIadeTarihi;
        private System.Windows.Forms.Label lblKitapId;
        private System.Windows.Forms.Label LblUyeId;
        private System.Windows.Forms.Button btnKitapAl;
        private System.Windows.Forms.Button btnKitapAra;
        private System.Windows.Forms.DateTimePicker dtTeslimTarihi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYayinEvi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtKitapAd;
    }
}