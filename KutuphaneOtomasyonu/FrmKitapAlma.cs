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
    public partial class FrmKitapAlma : Form
    {
        public FrmKitapAlma()
        {
            InitializeComponent();
        }
        private void FrmKitapAlma_Load(object sender, EventArgs e)
        {
        }     
        // Barkod Numarasına göre kitap Arama
        private void btnKitapAra_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmdKitapAra = new SqlCommand("SELECT Uyeler.UyeId,Emanet.KitapId,Kitaplar.KitapAd,Kitaplar.Yazar,Kitaplar.YayinEvi,Emanet.TeslimTarihi,Emanet.GelmesiGerekenTarih " +
               "FROM Kitaplar inner join Emanet on Emanet.KitapId=Kitaplar.KitapId inner join Uyeler on Emanet.UyeId=Uyeler.UyeId WHERE BarkodNo=@barkodno", VeriTabaniİslemleri.Baglan());
                cmdKitapAra.Parameters.Add("@barkodno", SqlDbType.NVarChar).Value = txtBarkodNo.Text;
                SqlDataReader oku = cmdKitapAra.ExecuteReader();
                while (oku.Read())
                {
                    lblKitapId.Text = oku["KitapId"].ToString();
                    LblUyeId.Text = oku["UyeId"].ToString();
                    txtKitapAd.Text = oku["KitapAd"].ToString();
                    txtYazar.Text = oku["Yazar"].ToString();
                    txtYayinEvi.Text = oku["YayinEvi"].ToString();
                    dtGelmesiGerekenTarih.Text = oku["GelmesiGerekenTarih"].ToString();
                    dtTeslimTarihi.Text = oku["TeslimTarihi"].ToString();
                }
                VeriTabaniİslemleri.Baglan().Close();
            }
            catch
            {
                MessageBox.Show("Barkod Hatası", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        // 3den az aldıgı kitapları iade etme
        //İadesi geciken kitapların üyesine ceza verme
        private void btnKitapAl_Click(object sender, EventArgs e)
        {
            DateTime iadetarih = Convert.ToDateTime(dtIadeTarihi.Text);
            int iadeMonth = iadetarih.Month;
            int iadeGun = iadetarih.Day;

            DateTime GelmesiGerekentarih = Convert.ToDateTime(dtGelmesiGerekenTarih.Text);
            int month = GelmesiGerekentarih.Month;
            int gun = GelmesiGerekentarih.Day;

            string kitapAlmaKotasi = "";
            int sayi = 0;
            SqlCommand cmdKitapAlmaKotası = new SqlCommand("SELECT AlinanKitapSayisi FROM Uyeler WHERE UyeId=@uyeid", VeriTabaniİslemleri.Baglan());
            cmdKitapAlmaKotası.Parameters.Add("@uyeid", SqlDbType.Int).Value = LblUyeId.Text;
            SqlDataReader ok = cmdKitapAlmaKotası.ExecuteReader();
            while (ok.Read())
            {
                kitapAlmaKotasi = ok["AlinanKitapSayisi"].ToString();
            }
            if (Int32.Parse(kitapAlmaKotasi) > sayi)
            {
               
                SqlCommand cmdKitapAlma = new SqlCommand("UPDATE Emanet SET IadeTarihi=@iadetarihi WHERE KitapId=@kitapid", VeriTabaniİslemleri.Baglan());
                cmdKitapAlma.Parameters.Add("@kitapid", SqlDbType.Int).Value = lblKitapId.Text;
                cmdKitapAlma.Parameters.Add("@iadetarihi", SqlDbType.DateTime).Value = dtIadeTarihi.Text;
                cmdKitapAlma.ExecuteNonQuery();
                VeriTabaniİslemleri.Baglan().Close();
                if (iadeGun>gun || iadeMonth>month)
                {
                    SqlCommand cmdcezaver = new SqlCommand("UPDATE Uyeler SET Ceza=@ceza where UyeId=@uyeid", VeriTabaniİslemleri.Baglan());
                    cmdcezaver.Parameters.Add("@uyeid", SqlDbType.Int).Value = LblUyeId.Text;
                    cmdcezaver.Parameters.Add("@ceza", SqlDbType.Char).Value = "1";
                    cmdcezaver.ExecuteNonQuery();
                    VeriTabaniİslemleri.Baglan().Close();
                }

                SqlCommand cmdAktiflikFalseYapma = new SqlCommand("UPDATE Kitaplar  SET AktifId=@aktif WHERE KitapId=@kitapid", VeriTabaniİslemleri.Baglan());
                cmdAktiflikFalseYapma.Parameters.Add("@kitapid", SqlDbType.Int).Value = lblKitapId.Text;
                cmdAktiflikFalseYapma.Parameters.Add("@aktif", SqlDbType.Int).Value = 1;
                cmdAktiflikFalseYapma.ExecuteNonQuery();
                VeriTabaniİslemleri.Baglan().Close();
                SqlCommand cmdKitapSayisi = new SqlCommand("UPDATE Uyeler SET AlinanKitapSayisi=@alinan WHERE  UyeId=@uyeid", VeriTabaniİslemleri.Baglan());
                cmdKitapSayisi.Parameters.Add("@uyeid", SqlDbType.Int).Value = LblUyeId.Text;
                cmdKitapSayisi.Parameters.Add("@alinan", SqlDbType.Int).Value = Int32.Parse(kitapAlmaKotasi) - 1;
                cmdKitapSayisi.ExecuteNonQuery();
                VeriTabaniİslemleri.Baglan().Close();
                MessageBox.Show("Kitap alma işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
