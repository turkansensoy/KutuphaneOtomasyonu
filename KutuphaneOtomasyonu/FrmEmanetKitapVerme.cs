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
    public partial class FrmEmanetKitapVerme : Form
    {
        public FrmEmanetKitapVerme()
        {
            InitializeComponent();
        }
        private void FrmEmanetKitapVerme_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            DateTime tarih = Convert.ToDateTime(dtTeslimTarihi.Text);
            DateTime onBesGünSonrası = tarih.AddDays(15);
            dtGelmesiGerekenTarih.Text = onBesGünSonrası.ToString();
        }

        private void btnUyeAra_Click(object sender, EventArgs e)
        {
            try
            {
                string ceza = "";
                SqlCommand cmdCeza = new SqlCommand("SELECT Ceza,UyeId,AdSoyad,Mail,Telefon FROM Uyeler WHERE TC=@tc", VeriTabaniİslemleri.Baglan());
                cmdCeza.Parameters.Add("@tc", SqlDbType.Char).Value = mskTc.Text;
                SqlDataReader oku = cmdCeza.ExecuteReader();
                while (oku.Read())
                {
                    ceza = oku["Ceza"].ToString();
                    LblUyeId.Text = oku["UyeId"].ToString();
                    txtAdSoyad.Text = oku["AdSoyad"].ToString();
                    txtMail.Text = oku["Mail"].ToString();
                    mskTelefon.Text = oku["Telefon"].ToString();
                }
                if (ceza == "0")
                {
                    groupBox2.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Kitap Alamazsınız.Cezanız vardır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch 
            {
                MessageBox.Show("Tekrar deneyiniz", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }



        private void btnKitapAra_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmdKitapAra = new SqlCommand("SELECT KitapId,KitapAd,Yazar,YayinEvi FROM Kitaplar WHERE BarkodNo=@barkodno", VeriTabaniİslemleri.Baglan());
                cmdKitapAra.Parameters.Add("@barkodno", SqlDbType.NVarChar).Value = txtBarkodNo.Text;
                SqlDataReader oku = cmdKitapAra.ExecuteReader();
                while (oku.Read())
                {
                    lblKitapId.Text = oku["KitapId"].ToString();
                    txtKitapAd.Text = oku["KitapAd"].ToString();
                    txtYazar.Text = oku["Yazar"].ToString();
                    txtYayinEvi.Text = oku["YayinEvi"].ToString();
                }
                VeriTabaniİslemleri.Baglan().Close();

            }
            catch
            {
                MessageBox.Show("Barkod Hatası", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }


        private void btnKitapVer_Click(object sender, EventArgs e)
        {
            try
            {
                string kitapAlmaKotasi = "";
                int sayi = 3;
                string okunmasayisi="";
                SqlCommand cmdKitapAlmaKotası = new SqlCommand("SELECT AlinanKitapSayisi FROM Uyeler WHERE UyeId=@uyeid", VeriTabaniİslemleri.Baglan());
                cmdKitapAlmaKotası.Parameters.Add("@uyeid", SqlDbType.Int).Value = LblUyeId.Text;
                SqlDataReader ok = cmdKitapAlmaKotası.ExecuteReader();
                while (ok.Read())
                {
                    kitapAlmaKotasi = ok["AlinanKitapSayisi"].ToString();
                }
                if (Int32.Parse(kitapAlmaKotasi) < sayi)
                {
                    SqlCommand cmdKitapVer = new SqlCommand("INSERT INTO Emanet(KitapId,UyeId,AktifId,TeslimTarihi,GelmesiGerekenTarih) values(@kitapid,@uyeid,@aktifid,@teslimtarihi,@gelmesigerekentarih)", VeriTabaniİslemleri.Baglan());
                    cmdKitapVer.Parameters.Add("@kitapid", SqlDbType.Int).Value = lblKitapId.Text;
                    cmdKitapVer.Parameters.Add("@uyeid", SqlDbType.Int).Value = LblUyeId.Text;
                    cmdKitapVer.Parameters.Add("@teslimtarihi", SqlDbType.DateTime).Value = dtTeslimTarihi.Text;
                    cmdKitapVer.Parameters.Add("@gelmesigerekentarih", SqlDbType.DateTime).Value = dtGelmesiGerekenTarih.Text;
                    cmdKitapVer.Parameters.Add("@aktifid", SqlDbType.Int).Value = 2;
                    cmdKitapVer.ExecuteNonQuery();
                    VeriTabaniİslemleri.Baglan().Close();

                    SqlCommand cmdAlınmaSayısı = new SqlCommand("SELECT AlinmaSayisi FROM Kitaplar WHERE KitapId=@kitapid", VeriTabaniİslemleri.Baglan());
                    cmdAlınmaSayısı.Parameters.Add("@kitapid", SqlDbType.Int).Value = lblKitapId.Text;
                    SqlDataReader alinmasayisiniOku = cmdAlınmaSayısı.ExecuteReader();
                    while (alinmasayisiniOku.Read())
                    {
                       okunmasayisi=alinmasayisiniOku["AlinmaSayisi"].ToString();
                    }
                    SqlCommand cmdAktiflikFalseYapma = new SqlCommand("UPDATE Kitaplar  SET AktifId=@aktif,AlinmaSayisi=@alinankitapsayisi WHERE KitapId=@kitapid", VeriTabaniİslemleri.Baglan());
                    cmdAktiflikFalseYapma.Parameters.Add("@kitapid", SqlDbType.Int).Value = lblKitapId.Text;
                    cmdAktiflikFalseYapma.Parameters.Add("@alinankitapsayisi", SqlDbType.SmallInt).Value =Int32.Parse(okunmasayisi) + 1;
                    cmdAktiflikFalseYapma.Parameters.Add("@aktif", SqlDbType.Int).Value = 2;
                    cmdAktiflikFalseYapma.ExecuteNonQuery();
                    VeriTabaniİslemleri.Baglan().Close();
                    SqlCommand cmdKitapSayisi = new SqlCommand("UPDATE Uyeler SET AlinanKitapSayisi=@alinan WHERE  UyeId=@uyeid", VeriTabaniİslemleri.Baglan());
                    cmdKitapSayisi.Parameters.Add("@uyeid", SqlDbType.Int).Value = LblUyeId.Text;
                    cmdKitapSayisi.Parameters.Add("@alinan", SqlDbType.Int).Value = Int32.Parse(kitapAlmaKotasi) + 1;
                    cmdKitapSayisi.ExecuteNonQuery();
                    MessageBox.Show("Kitap verme işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VeriTabaniİslemleri.Baglan().Close();

                }
                else
                {
                    MessageBox.Show("En fazla 3 kitap alabilirsiniz.Kitap alma kotanız doldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch 
            {
                MessageBox.Show("Tekrar deneyiniz", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
