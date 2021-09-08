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
    public partial class FrmUyeLİsteleme : Form
    {
        public FrmUyeLİsteleme()
        {
            InitializeComponent();
        }

        DataTable dtBolum = new DataTable();
        private void FrmUyeLİsteleme_Load(object sender, EventArgs e)
        {
            // DataGridView'e verileri çekme
            VeriTabaniİslemleri.DataGridVerileriGöster("SELECT Uyeler.UyeId AS 'Numara',Uyeler.AdSoyad AS 'Ad Soyad',Uyeler.TC AS 'TC',Uyeler.Mail AS 'Mail',Uyeler.DogumTarihi AS" +
             " 'Dogum Tarihi',Uyeler.Telefon AS 'Telefon',Uyeler.Cinsiyet AS 'Cinsiyet',S_Bolum.BolumAd AS 'Bölüm',Uyeler.AlinanKitapSayisi FROM Uyeler inner join S_Bolum on Uyeler.BolumId = S_Bolum.BolumId ", dataGridView1);
            //ilişkili tablolarda Id degeri çekme
            dtBolum.Clear();
            dtBolum.Columns.Add("BolumId");
            dtBolum.Columns.Add("BolumAd");

            SqlCommand cmdUye = new SqlCommand("SELECT BolumId,BolumAd FROM S_Bolum", VeriTabaniİslemleri.Baglan());
            SqlDataAdapter da = new SqlDataAdapter(cmdUye);
            da.Fill(dtBolum);

            cmbBolum.DataSource = dtBolum;
            cmbBolum.DisplayMember = "BolumAd";
            cmbBolum.ValueMember = "BolumId";
            cmbBolum.Text = "Bölüm Seçiniz...";
        }
        string bolumid;
        private void cmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            bolumid = cmbBolum.SelectedValue.ToString();
        }
        private void btnUyeGüncelleme_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmdUyeUpdate = new SqlCommand("UPDATE UYELER SET AdSoyad=@adSoyad,Tc=@tc,Mail=@mail,Telefon=@telefon,Cinsiyet=@cinsiyet,BolumId=@bolumId,DogumTarihi=@dogumTarihi WHERE UyeId=@uyeId ",
             VeriTabaniİslemleri.Baglan());
                cmdUyeUpdate.Parameters.Add("@adSoyad", SqlDbType.NVarChar).Value = txtAdSoyad.Text;
                cmdUyeUpdate.Parameters.Add("@tc", SqlDbType.Char).Value = mskTc.Text;
                cmdUyeUpdate.Parameters.Add("@mail", SqlDbType.NVarChar).Value = txtMail.Text;
                cmdUyeUpdate.Parameters.Add("@dogumTarihi", SqlDbType.Date).Value = mskDogumTarihi.Text;
                cmdUyeUpdate.Parameters.Add("@bolumId", SqlDbType.VarChar).Value = bolumid;
                cmdUyeUpdate.Parameters.Add("@telefon", SqlDbType.NVarChar).Value = mskTelefon.Text;
                string cinsiyet = "";
                if (rbKız.Checked)
                {
                    cinsiyet = rbKız.Text;
                }
                else
                {
                    cinsiyet = rbErkek.Text;
                }
                cmdUyeUpdate.Parameters.Add("@cinsiyet", SqlDbType.NVarChar).Value = cinsiyet;
                cmdUyeUpdate.Parameters.Add("@uyeId", SqlDbType.Int).Value = lblUyeId.Text;
                cmdUyeUpdate.ExecuteNonQuery();
                VeriTabaniİslemleri.Baglan().Close();
                MessageBox.Show("Güncelleme işlemi Yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
                VeriTabaniİslemleri.DataGridVerileriGöster("SELECT Uyeler.UyeId AS 'Numara',Uyeler.AdSoyad AS 'Ad Soyad',Uyeler.TC AS 'TC',Uyeler.Mail AS 'Mail',Uyeler.DogumTarihi AS" +
                  " 'Dogum Tarihi',Uyeler.Telefon AS 'Telefon',Uyeler.Cinsiyet AS 'Cinsiyet',S_Bolum.BolumAd AS 'Bölüm',Uyeler.AlinanKitapSayisi FROM Uyeler inner join S_Bolum on Uyeler.BolumId = S_Bolum.BolumId ", dataGridView1);

            }
            catch
            {
                MessageBox.Show("Yanlış giden bir şeyler var. tekrar giriniz", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        { 
            int veriSec;
            string adSoyad, tc, mail, telefon, bolumAd,uyeid,dogumtarihi;
            veriSec = dataGridView1.SelectedCells[0].RowIndex;
            uyeid = dataGridView1.Rows[veriSec].Cells[0].Value.ToString();
            adSoyad = dataGridView1.Rows[veriSec].Cells[1].Value.ToString();
            tc = dataGridView1.Rows[veriSec].Cells[2].Value.ToString();
            mail = dataGridView1.Rows[veriSec].Cells[3].Value.ToString();
            dogumtarihi = dataGridView1.Rows[veriSec].Cells[4].Value.ToString();
            telefon = dataGridView1.Rows[veriSec].Cells[5].Value.ToString();
            bolumAd = dataGridView1.Rows[veriSec].Cells[7].Value.ToString();

            txtAdSoyad.Text = adSoyad;
            mskTc.Text = tc;
            txtMail.Text = mail;
            mskTelefon.Text = telefon;
            cmbBolum.Text = bolumAd;
            lblUyeId.Text = uyeid;
            mskDogumTarihi.Text=dogumtarihi;

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
        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmdUyeSilme = new SqlCommand("DELETE FROM Uyeler where UyeId=@uyeid", VeriTabaniİslemleri.Baglan());
            cmdUyeSilme.Parameters.Add("@uyeid", SqlDbType.Int).Value = lblUyeId.Text;
            cmdUyeSilme.ExecuteNonQuery();
            VeriTabaniİslemleri.Baglan().Close();
            MessageBox.Show("Üye Silinmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            VeriTabaniİslemleri.DataGridVerileriGöster("SELECT Uyeler.UyeId AS 'Numara',Uyeler.AdSoyad AS 'Ad Soyad',Uyeler.TC AS 'TC',Uyeler.Mail AS 'Mail',Uyeler.DogumTarihi AS" +
              " 'Dogum Tarihi',Uyeler.Telefon AS 'Telefon',Uyeler.Cinsiyet AS 'Cinsiyet',S_Bolum.BolumAd AS 'Bölüm',Uyeler.AlinanKitapSayisi FROM Uyeler inner join S_Bolum on Uyeler.BolumId = S_Bolum.BolumId ", dataGridView1);

        }
    }
}
