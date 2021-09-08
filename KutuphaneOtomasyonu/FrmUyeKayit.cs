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
    public partial class FrmUyeKayit : Form
    {
        public FrmUyeKayit()
        {
            InitializeComponent();
        }

        DataTable dtBolum = new DataTable();
     
        // veritabanından combobox ile cmbBolume verileri cekip ve gelen degerin Id degerini ilişkilendirme yapma.Datatable ile Id degerini alma
        private void FrmUyeKayit_Load(object sender, EventArgs e)
        {
            dtBolum.Clear();
            dtBolum.Columns.Add("BolumId");
            dtBolum.Columns.Add("BolumAd");

            SqlCommand cmdBolumAd = new SqlCommand("SELECT BolumId, BolumAd FROM S_Bolum", VeriTabaniİslemleri.Baglan());
            SqlDataAdapter da = new SqlDataAdapter(cmdBolumAd);
            da.Fill(dtBolum);

            cmbBolum.DataSource = dtBolum;
            cmbBolum.ValueMember = "BolumId";
            cmbBolum.DisplayMember = "BolumAd";
            cmbBolum.Text = "Bölüm seçiniz...";
        }
        string bolumid;
        private void cmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            bolumid = cmbBolum.SelectedValue.ToString();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmdKayitUye = new SqlCommand("INSERT INTO Uyeler(TC,AdSoyad,Mail,Telefon,DogumTarihi,Cinsiyet,BolumId) VALUES(@uyeTc,@uyeAdSoyad,@uyeMail,@uyeTelefon,@dogumTarihi,@cinsiyet,@bolumId)", VeriTabaniİslemleri.Baglan());
                cmdKayitUye.Parameters.Add("@uyeTc", SqlDbType.Char).Value = mskTc.Text;
                cmdKayitUye.Parameters.Add("@uyeAdSoyad", SqlDbType.NVarChar).Value = txtAdSoyad.Text;
                cmdKayitUye.Parameters.Add("@uyeMail", SqlDbType.NVarChar).Value = txtMail.Text;
                cmdKayitUye.Parameters.Add("@uyeTelefon", SqlDbType.NVarChar).Value = mskTelefon.Text;
                cmdKayitUye.Parameters.Add("@dogumTarihi", SqlDbType.Date).Value = mskDogumTarihi.Text;

                string cinsiyeti = "";
                if (rdbKız.Checked)
                {
                    cinsiyeti = rdbKız.Text;
                }
                else
                {
                    cinsiyeti = rdbErkek.Text;
                }
                cmdKayitUye.Parameters.Add("@cinsiyet", SqlDbType.NVarChar).Value = cinsiyeti;
                cmdKayitUye.Parameters.Add("@bolumId", SqlDbType.Int).Value = bolumid;
                cmdKayitUye.ExecuteNonQuery();
                VeriTabaniİslemleri.Baglan().Close();
                MessageBox.Show("Kayit İşlemi yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            catch 
            {
                MessageBox.Show("Yanlış giden bir şeyler var. tekrar giriniz", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
        }

        void temizle()
        {
            txtAdSoyad.Clear();
            mskTc.Clear();
            txtMail.Clear();
            mskDogumTarihi.Clear();
            cmbBolum.Text = "Bölüm Seçiniz...";
            mskTelefon.Clear();
            txtAdSoyad.Focus();
        }
    }

}
