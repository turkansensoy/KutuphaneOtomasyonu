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
    public partial class FrmKitapEkle : Form
    {
        public FrmKitapEkle()
        {
            InitializeComponent();
        }
        DataTable dtKitapTur = new DataTable();
        DataTable dtRaf = new DataTable();
        private void FrmKitapEkle_Load(object sender, EventArgs e)
        {
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
        private void cmbKitapTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            kategoriId = cmbKitapTur.SelectedValue.ToString();
        }
        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmdKitapInsert = new SqlCommand("INSERT INTO Kitaplar(BarkodNo,KitapAd,Yazar,SayfaSayisi,YayinEvi,BasimTarihi,StokSayisi,KategoriId,RafId,AktifId) VALUES(@barkodNo,@kitapAd,@kitapYazar,@sayfaSayisi, @yayinEvi,@basimtarihi,@stokSayisi,@kategoriid,@rafid,@aktifid)", VeriTabaniİslemleri.Baglan());
                cmdKitapInsert.Parameters.Add("@barkodNo", SqlDbType.NVarChar).Value = txtBarkodNo.Text;
                cmdKitapInsert.Parameters.Add("@kitapAd", SqlDbType.NVarChar).Value = txtKitapAd.Text;
                cmdKitapInsert.Parameters.Add("@kitapYazar", SqlDbType.NVarChar).Value = txtKitapYazar.Text;
                cmdKitapInsert.Parameters.Add("@sayfaSayisi", SqlDbType.SmallInt).Value = txtKitapSayfası.Text;
                cmdKitapInsert.Parameters.Add("@yayinEvi", SqlDbType.NVarChar).Value = txtYayınEvi.Text;
                cmdKitapInsert.Parameters.Add("@basimtarihi", SqlDbType.Date).Value = mskBasimTarihi.Text;
                cmdKitapInsert.Parameters.Add("@stokSayisi", SqlDbType.TinyInt).Value = txtStokSayisi.Text;
                cmdKitapInsert.Parameters.Add("@kategoriid", SqlDbType.Int).Value = kategoriId;
                cmdKitapInsert.Parameters.Add("@rafid", SqlDbType.Int).Value = rafid;
                cmdKitapInsert.Parameters.Add("@aktifid", SqlDbType.Int).Value = 1;
                cmdKitapInsert.ExecuteNonQuery();
                VeriTabaniİslemleri.Baglan().Close();
                MessageBox.Show("Kayit İşlemi yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            catch 
            {
                MessageBox.Show("Ekleme İşlemi yapılamadı.", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            
        }


        string rafid;
        private void cmbKitapRafNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            rafid = cmbKitapRafNo.SelectedValue.ToString();
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
