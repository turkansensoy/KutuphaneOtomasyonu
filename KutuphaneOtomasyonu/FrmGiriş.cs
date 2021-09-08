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
    public partial class FrmGiriş : Form
    {
        public FrmGiriş()
        {
            InitializeComponent();
        }
        private void btnGiriş_Click(object sender, EventArgs e)
        {
            SqlCommand cmdSelectAdmin = new SqlCommand("SELECT KullaniciAd,Sifre FROM Admin WHERE KullaniciAd=@kullaniciAd and Sifre=@kullaniciSifre",VeriTabaniİslemleri.Baglan());
            cmdSelectAdmin.Parameters.AddWithValue("@kullaniciAd", txtKullaniciAd.Text);
            cmdSelectAdmin.Parameters.AddWithValue("@kullaniciSifre",txtSifre.Text);
            SqlDataReader reader = cmdSelectAdmin.ExecuteReader();
            if(reader.Read())
            {
                FrmAnaSayfa anaSayfaGitme = new FrmAnaSayfa();
                anaSayfaGitme.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("kullanıcı adı ya da şifreniz yanlış tekrar giriniz", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
