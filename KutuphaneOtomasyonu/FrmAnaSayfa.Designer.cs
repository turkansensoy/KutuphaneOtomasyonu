
namespace KutuphaneOtomasyonu
{
    partial class FrmAnaSayfa
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.üyeİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.üyeListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapSorgulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapListelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetKitapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapİadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapVermeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıŞifreİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istatistikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istatistikToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rchSozler = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeİşlemleriToolStripMenuItem,
            this.kitapİşlemleriToolStripMenuItem,
            this.emanetKitapİşlemleriToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.istatistikToolStripMenuItem,
            this.çIKIŞToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 38);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // üyeİşlemleriToolStripMenuItem
            // 
            this.üyeİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.üyeEkleToolStripMenuItem,
            this.üyeListesiToolStripMenuItem});
            this.üyeİşlemleriToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.üyeİşlemleriToolStripMenuItem.Name = "üyeİşlemleriToolStripMenuItem";
            this.üyeİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(143, 34);
            this.üyeİşlemleriToolStripMenuItem.Text = "Üye İşlemleri";
            // 
            // üyeEkleToolStripMenuItem
            // 
            this.üyeEkleToolStripMenuItem.Name = "üyeEkleToolStripMenuItem";
            this.üyeEkleToolStripMenuItem.Size = new System.Drawing.Size(183, 34);
            this.üyeEkleToolStripMenuItem.Text = "Üye Ekle";
            this.üyeEkleToolStripMenuItem.Click += new System.EventHandler(this.üyeEkleToolStripMenuItem_Click);
            // 
            // üyeListesiToolStripMenuItem
            // 
            this.üyeListesiToolStripMenuItem.Name = "üyeListesiToolStripMenuItem";
            this.üyeListesiToolStripMenuItem.Size = new System.Drawing.Size(183, 34);
            this.üyeListesiToolStripMenuItem.Text = "Üye Listesi";
            this.üyeListesiToolStripMenuItem.Click += new System.EventHandler(this.üyeListesiToolStripMenuItem_Click);
            // 
            // kitapİşlemleriToolStripMenuItem
            // 
            this.kitapİşlemleriToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.kitapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapEkleToolStripMenuItem,
            this.kitapSorgulaToolStripMenuItem,
            this.kitapListelemeToolStripMenuItem});
            this.kitapİşlemleriToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.kitapİşlemleriToolStripMenuItem.Name = "kitapİşlemleriToolStripMenuItem";
            this.kitapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(155, 34);
            this.kitapİşlemleriToolStripMenuItem.Text = "Kitap İşlemleri";
            // 
            // kitapEkleToolStripMenuItem
            // 
            this.kitapEkleToolStripMenuItem.Name = "kitapEkleToolStripMenuItem";
            this.kitapEkleToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
            this.kitapEkleToolStripMenuItem.Text = "Kitap Ekle";
            this.kitapEkleToolStripMenuItem.Click += new System.EventHandler(this.kitapEkleToolStripMenuItem_Click);
            // 
            // kitapSorgulaToolStripMenuItem
            // 
            this.kitapSorgulaToolStripMenuItem.Name = "kitapSorgulaToolStripMenuItem";
            this.kitapSorgulaToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
            this.kitapSorgulaToolStripMenuItem.Text = "KitapSorgula";
            this.kitapSorgulaToolStripMenuItem.Click += new System.EventHandler(this.kitapSorgulaToolStripMenuItem_Click);
            // 
            // kitapListelemeToolStripMenuItem
            // 
            this.kitapListelemeToolStripMenuItem.Name = "kitapListelemeToolStripMenuItem";
            this.kitapListelemeToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
            this.kitapListelemeToolStripMenuItem.Text = "Kitap Listeleme";
            this.kitapListelemeToolStripMenuItem.Click += new System.EventHandler(this.kitapListelemeToolStripMenuItem_Click);
            // 
            // emanetKitapİşlemleriToolStripMenuItem
            // 
            this.emanetKitapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitapİadeToolStripMenuItem,
            this.kitapVermeToolStripMenuItem});
            this.emanetKitapİşlemleriToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.emanetKitapİşlemleriToolStripMenuItem.Name = "emanetKitapİşlemleriToolStripMenuItem";
            this.emanetKitapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(231, 34);
            this.emanetKitapİşlemleriToolStripMenuItem.Text = "Emanet Kitap İşlemleri";
            // 
            // kitapİadeToolStripMenuItem
            // 
            this.kitapİadeToolStripMenuItem.Name = "kitapİadeToolStripMenuItem";
            this.kitapİadeToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.kitapİadeToolStripMenuItem.Text = "Kitap İade";
            this.kitapİadeToolStripMenuItem.Click += new System.EventHandler(this.kitapİadeToolStripMenuItem_Click);
            // 
            // kitapVermeToolStripMenuItem
            // 
            this.kitapVermeToolStripMenuItem.Name = "kitapVermeToolStripMenuItem";
            this.kitapVermeToolStripMenuItem.Size = new System.Drawing.Size(198, 34);
            this.kitapVermeToolStripMenuItem.Text = "Kitap Verme";
            this.kitapVermeToolStripMenuItem.Click += new System.EventHandler(this.kitapVermeToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıŞifreİşlemleriToolStripMenuItem});
            this.adminToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(86, 34);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // kullanıcıŞifreİşlemleriToolStripMenuItem
            // 
            this.kullanıcıŞifreİşlemleriToolStripMenuItem.Name = "kullanıcıŞifreİşlemleriToolStripMenuItem";
            this.kullanıcıŞifreİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(293, 34);
            this.kullanıcıŞifreİşlemleriToolStripMenuItem.Text = "Kullanıcı Şifre İşlemleri";
            this.kullanıcıŞifreİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıŞifreİşlemleriToolStripMenuItem_Click);
            // 
            // istatistikToolStripMenuItem
            // 
            this.istatistikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.istatistikToolStripMenuItem1});
            this.istatistikToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.istatistikToolStripMenuItem.Name = "istatistikToolStripMenuItem";
            this.istatistikToolStripMenuItem.Size = new System.Drawing.Size(101, 34);
            this.istatistikToolStripMenuItem.Text = "İstatistik";
            // 
            // istatistikToolStripMenuItem1
            // 
            this.istatistikToolStripMenuItem1.Name = "istatistikToolStripMenuItem1";
            this.istatistikToolStripMenuItem1.Size = new System.Drawing.Size(180, 34);
            this.istatistikToolStripMenuItem1.Text = "İstatistik";
            this.istatistikToolStripMenuItem1.Click += new System.EventHandler(this.istatistikToolStripMenuItem1_Click);
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(73, 34);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // rchSozler
            // 
            this.rchSozler.BackColor = System.Drawing.SystemColors.ControlText;
            this.rchSozler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchSozler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rchSozler.Location = new System.Drawing.Point(90, 144);
            this.rchSozler.Name = "rchSozler";
            this.rchSozler.Size = new System.Drawing.Size(599, 141);
            this.rchSozler.TabIndex = 5;
            this.rchSozler.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(823, 401);
            this.Controls.Add(this.rchSozler);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAnaSayfa";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem üyeİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem üyeListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapSorgulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapListelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emanetKitapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapİadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitapVermeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıŞifreİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istatistikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istatistikToolStripMenuItem1;
        private System.Windows.Forms.RichTextBox rchSozler;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}