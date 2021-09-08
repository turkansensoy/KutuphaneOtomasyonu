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
    public partial class FrmSifreİslemleri : Form
    {
        public FrmSifreİslemleri()
        {
            InitializeComponent();
        }
        private void FrmSifreİslemleri_Load(object sender, EventArgs e)
        {
           VeriTabaniİslemleri.DataGridVerileriGöster("SELECT KullaniciId AS 'Kullanıcı Id',KullaniciAd AS'Kullanıcı Ad',Sifre AS 'Kullanıcı Şifre' FROM Admin", dataGridView1);         
            txtKullaniciİd.ReadOnly= true;
        }
       
        private void btnSifreKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmdInsertAdmin = new SqlCommand("INSERT INTO Admin VALUES(@kullaniciAd,@kullaniciSifre)", VeriTabaniİslemleri.Baglan());
                cmdInsertAdmin.Parameters.Add("@kullaniciAd",SqlDbType.NVarChar).Value=txtKullaniciAd.Text;
                cmdInsertAdmin.Parameters.Add("@kullaniciSifre", SqlDbType.NVarChar).Value= txtSifre.Text;
                cmdInsertAdmin.ExecuteNonQuery();
                VeriTabaniİslemleri.DataGridVerileriGöster("SELECT KullaniciId AS 'Kullanıcı Id',KullaniciAd AS'Kullanıcı Ad',Sifre AS 'Kullanıcı Şifre' FROM Admin", dataGridView1);
                VeriTabaniİslemleri.Baglan().Close();
                MessageBox.Show("Şifre kayit işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Yanlış giden bir şeyler var. tekrar giriniz", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnSifreGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmdUpdateAdmin = new SqlCommand("UPDATE Admin SET KullaniciAd=@kullaniciAd,Sifre=@Sifre WHERE KullaniciId=@kullaniciId",VeriTabaniİslemleri.Baglan());
                cmdUpdateAdmin.Parameters.Add("@KullaniciAd",SqlDbType.NVarChar).Value= txtKullaniciAd.Text;
                cmdUpdateAdmin.Parameters.Add("@sifre", SqlDbType.NVarChar).Value= txtSifre.Text;
                cmdUpdateAdmin.Parameters.Add("@KullaniciId", SqlDbType.TinyInt).Value= txtKullaniciİd.Text;
                cmdUpdateAdmin.ExecuteNonQuery();
                VeriTabaniİslemleri.DataGridVerileriGöster("SELECT KullaniciId AS 'Kullanıcı Id',KullaniciAd AS'Kullanıcı Ad',Sifre AS 'Kullanıcı Şifre' FROM Admin", dataGridView1);
                VeriTabaniİslemleri.Baglan().Close();
                MessageBox.Show("Güncelleme İşlemi yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Yanlış giden bir şeyler var. tekrar giriniz", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            
        }

        private void btnSifreSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmdDeleteAdmin = new SqlCommand("DELETE FROM Admin WHERE KullaniciId=@kullaniciId ", VeriTabaniİslemleri.Baglan());
                cmdDeleteAdmin.Parameters.Add("@kullaniciId",SqlDbType.TinyInt).Value= txtKullaniciİd.Text;
                cmdDeleteAdmin.ExecuteNonQuery();
                VeriTabaniİslemleri.DataGridVerileriGöster("SELECT KullaniciId AS 'Kullanıcı Id',KullaniciAd AS 'Kullanıcı Ad',Sifre AS 'Kullanıcı Şifre' FROM Admin", dataGridView1);
                VeriTabaniİslemleri.Baglan().Close();
                MessageBox.Show("Silme işlemi tamamlandı","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);        
            }
            catch 
            {
                MessageBox.Show("Yanlış giden bir şeyler var. tekrar giriniz", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
           
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int sec;
            string kullaniciId,kullaniciAd,kullaniciSifre;
            sec = dataGridView1.SelectedCells[0].RowIndex;
            kullaniciId = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            kullaniciAd = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            kullaniciSifre = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            txtKullaniciAd.Text = kullaniciAd;
            txtSifre.Text = kullaniciSifre;
            txtKullaniciİd.Text = kullaniciId;

        }
    }
}
