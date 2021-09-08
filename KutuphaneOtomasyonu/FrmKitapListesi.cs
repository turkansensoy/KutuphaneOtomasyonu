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
    public partial class FrmKitapListesi : Form
    {
        public FrmKitapListesi()
        {
            InitializeComponent();
        }
       
        DataTable dtKitapTur = new DataTable();
        DataTable dtRaf = new DataTable();

        private void FrmKitapListesi_Load(object sender, EventArgs e)
        {
            VeriTabaniİslemleri.DataGridVerileriGöster("SELECT Kitaplar.KitapId 'Numara',Kitaplar.BarkodNo 'Barkod Numarası', Kitaplar.KitapAd 'Kitap Ad', Kitaplar.Yazar, Kitaplar.SayfaSayisi, Kitaplar.YayinEvi, Kategori.KitapTuru, Kitaplar.StokSayisi," +
              "Kitaplar.BasimTarihi, Raf.RafNo, Aktiflik.Durum, Kitaplar.AlinmaSayisi 'OkunmaSayısı' FROM Kitaplar inner join Raf on Kitaplar.RafId = Raf.RafId inner join Aktiflik on Kitaplar.AktifId = Aktiflik.AktifId inner join" +
              " Kategori on Kitaplar.KategoriId = Kategori.KategoriId",dataGridView1);
            dtKitapTur.Clear();
            dtKitapTur.Columns.Add("KategoriId");
            dtKitapTur.Columns.Add("KitapTuru");
            SqlCommand cmdKitapTur = new SqlCommand("SELECT KategoriId, KitapTuru FROM Kategori", VeriTabaniİslemleri.Baglan());
            SqlDataAdapter da = new SqlDataAdapter(cmdKitapTur);
            da.Fill(dtKitapTur);
            cmbKitapTur.DataSource = dtKitapTur;
            cmbKitapTur.ValueMember = "KategoriId";
            cmbKitapTur.DisplayMember = "KitapTuru";
            cmbKitapTur.Text = "Kitap türünü seçiniz...";

            dtRaf.Columns.Add("RafId");
            dtRaf.Columns.Add("RafNo");
            SqlCommand cmdRafIdCek = new SqlCommand("SELECT RafId,RafNo FROM Raf", VeriTabaniİslemleri.Baglan());
            SqlDataAdapter daRaf = new SqlDataAdapter(cmdRafIdCek);
            daRaf.Fill(dtRaf);
            cmbKitapRafNo.DataSource = dtRaf;
            cmbKitapRafNo.ValueMember = "RafId";
            cmbKitapRafNo.DisplayMember = "RafNo";
            cmbKitapRafNo.Text = "Raf numarası seçin...";
        }
        string kategoriId;
        private void cmbKitapTur_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            kategoriId = cmbKitapTur.SelectedValue.ToString();
        }
        string rafid;
        private void cmbKitapRafNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            rafid = cmbKitapRafNo.SelectedValue.ToString();
        }
        private void btnKitapGüncelle_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmdKitapGüncelle = new SqlCommand("UPDATE Kitaplar SET BarkodNo=@barkodno,KitapAd=@kitapad,Yazar=@yazar,SayfaSayisi=@sayfasayisi,YayinEvi=@yayinevi,BasimTarihi=@basimtarihi,StokSayisi=@stoksayisi," +
                    "KategoriId=@kategoriid,RafId=@rafid WHERE KitapId=@kitapid", VeriTabaniİslemleri.Baglan());
                cmdKitapGüncelle.Parameters.Add("@barkodno", SqlDbType.NVarChar).Value = txtBarkodNo.Text;
                cmdKitapGüncelle.Parameters.Add("@kitapad", SqlDbType.NVarChar).Value = txtKitapAd.Text;
                cmdKitapGüncelle.Parameters.Add("@yazar", SqlDbType.NVarChar).Value = txtKitapYazar.Text;
                cmdKitapGüncelle.Parameters.Add("@sayfasayisi", SqlDbType.SmallInt).Value = txtKitapSayfası.Text;
                cmdKitapGüncelle.Parameters.Add("@yayinevi", SqlDbType.NVarChar).Value = txtYayınEvi.Text;
                cmdKitapGüncelle.Parameters.Add("@basimtarihi", SqlDbType.DateTime).Value = mskBasimTarihi.Text;
                cmdKitapGüncelle.Parameters.Add("@stoksayisi", SqlDbType.TinyInt).Value = txtStokSayisi.Text;
                cmdKitapGüncelle.Parameters.Add("@rafid", SqlDbType.Int).Value = rafid;
                cmdKitapGüncelle.Parameters.Add("@kategoriid", SqlDbType.Int).Value = kategoriId;
                cmdKitapGüncelle.Parameters.Add("@kitapid", SqlDbType.Int).Value = LblKitapId.Text;
                cmdKitapGüncelle.ExecuteNonQuery();


                VeriTabaniİslemleri.Baglan().Close();
                MessageBox.Show("Güncelleme işlemi yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
                VeriTabaniİslemleri.DataGridVerileriGöster("SELECT Kitaplar.KitapId 'Numara',Kitaplar.BarkodNo 'Barkod Numarası', Kitaplar.KitapAd 'Kitap Ad', Kitaplar.Yazar, Kitaplar.SayfaSayisi, Kitaplar.YayinEvi, Kategori.KitapTuru, Kitaplar.StokSayisi," +
                 "Kitaplar.BasimTarihi, Raf.RafNo, Aktiflik.Durum, Kitaplar.AlinmaSayisi 'OkunmaSayısı' FROM Kitaplar inner join Raf on Kitaplar.RafId = Raf.RafId inner join Aktiflik on Kitaplar.AktifId = Aktiflik.AktifId inner join" +
                 " Kategori on Kitaplar.KategoriId = Kategori.KategoriId", dataGridView1);

            }
            catch 
            {
                MessageBox.Show("Yanlış giden bir şeyler var. tekrar giriniz", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmdKitapDelete = new SqlCommand("DELETE FROM Kitaplar WHERE KitapId=@kitapid", VeriTabaniİslemleri.Baglan());
                cmdKitapDelete.Parameters.Add("@kitapid", SqlDbType.Int).Value = LblKitapId.Text;
                cmdKitapDelete.ExecuteNonQuery();
                VeriTabaniİslemleri.Baglan().Close();
                MessageBox.Show("Silme işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VeriTabaniİslemleri.DataGridVerileriGöster("SELECT Kitaplar.KitapId 'Numara',Kitaplar.BarkodNo 'Barkod Numarası', Kitaplar.KitapAd 'Kitap Ad', Kitaplar.Yazar, Kitaplar.SayfaSayisi, Kitaplar.YayinEvi, Kategori.KitapTuru, Kitaplar.StokSayisi," +
                "Kitaplar.BasimTarihi, Raf.RafNo, Aktiflik.Durum, Kitaplar.AlinmaSayisi 'OkunmaSayısı' FROM Kitaplar inner join Raf on Kitaplar.RafId = Raf.RafId inner join Aktiflik on Kitaplar.AktifId = Aktiflik.AktifId inner join" +
                " Kategori on Kitaplar.KategoriId = Kategori.KategoriId", dataGridView1);
                temizle();
            }
            catch 
            {
                MessageBox.Show("Silme İşlemi Yapılamadı", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int sec;
            string kitapid,barkodno, kitapAd, yazar, sayfasayisi, yayinevi, basimtarihi, stoksayisi,rafno,kategoritür;
            sec = dataGridView1.SelectedCells[0].RowIndex;
            kitapid = dataGridView1.Rows[sec].Cells[0].Value.ToString();
            barkodno = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            kitapAd = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            yazar = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            sayfasayisi = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            yayinevi = dataGridView1.Rows[sec].Cells[5].Value.ToString();
            kategoritür = dataGridView1.Rows[sec].Cells[6].Value.ToString();
            stoksayisi = dataGridView1.Rows[sec].Cells[7].Value.ToString();
            basimtarihi = dataGridView1.Rows[sec].Cells[8].Value.ToString();    
            rafno = dataGridView1.Rows[sec].Cells[9].Value.ToString();

            LblKitapId.Text = kitapid;
            txtBarkodNo.Text = barkodno;
            txtKitapAd.Text = kitapAd;
            txtKitapYazar.Text = yazar;
            txtKitapSayfası.Text = sayfasayisi;
            txtYayınEvi.Text = yayinevi;
            mskBasimTarihi.Text = basimtarihi;
            cmbKitapRafNo.Text = rafno;
            cmbKitapTur.Text = kategoritür;
            txtStokSayisi.Text = stoksayisi;
            
        }
        void temizle()
        {
            txtBarkodNo.Clear();
            txtKitapAd.Clear();
            txtKitapYazar.Clear();
            txtKitapSayfası.Clear();
            txtYayınEvi.Clear();
            mskBasimTarihi.Clear();
            txtStokSayisi.Clear();
        }
    }
}
