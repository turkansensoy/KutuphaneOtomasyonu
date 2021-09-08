using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace KutuphaneOtomasyonu
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();

        }
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {


            SqlCommand cmdSozAlma = new SqlCommand("SELECT  Soz FROM Sozler order by NEWID() ", VeriTabaniİslemleri.Baglan());
            SqlDataReader oku = cmdSozAlma.ExecuteReader();
            while (oku.Read())
            {
                rchSozler.Text = oku["Soz"].ToString();
                string[] renk = { "Red", "Pink", "White", "Yellow", "Lime " };
                Random rnd = new Random();
                int sayi = rnd.Next(renk.Length);
                rchSozler.ForeColor = Color.FromName(renk[sayi]);
            }
        }

        private void üyeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUyeKayit frmUyeKayit = new FrmUyeKayit();
            frmUyeKayit.Show();
        }

        private void üyeListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmUyeLİsteleme frmUyeLİsteleme = new FrmUyeLİsteleme();
            frmUyeLİsteleme.Show();
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKitapEkle frmKitapEkle = new FrmKitapEkle();
            frmKitapEkle.Show();
        }

        private void kitapSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmKitapSorgulama frmKitapSorgulama = new FrmKitapSorgulama();
            frmKitapSorgulama.Show();
        }

        private void kitapListelemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKitapListesi frmKitapListesi = new FrmKitapListesi();
            frmKitapListesi.Show();
        }

        private void kitapİadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKitapAlma frmKitapAlma = new FrmKitapAlma();
            frmKitapAlma.Show();
        }

        private void kitapVermeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmanetKitapVerme frmEmanetKitapVerme = new FrmEmanetKitapVerme();
            frmEmanetKitapVerme.Show();
        }

        private void kullanıcıŞifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSifreİslemleri frmSifreİslemleri = new FrmSifreİslemleri();
            frmSifreİslemleri.Show();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void istatistikToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmİstatistik frmİstatistik = new Frmİstatistik();
            frmİstatistik.Show();
        }
    }
}
