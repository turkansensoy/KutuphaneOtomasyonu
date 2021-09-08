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
    public partial class FrmKitapSorgulama : Form
    {
        public FrmKitapSorgulama()
        {
            InitializeComponent();
        }

        private void FrmKitapSorgulama_Load(object sender, EventArgs e)
        {
            VeriTabaniİslemleri.DataGridVerileriGöster("SELECT Kitaplar.KitapId 'Numara',Kitaplar.BarkodNo 'Barkod Numarası', Kitaplar.KitapAd 'Kitap Ad', Kitaplar.Yazar, Kitaplar.SayfaSayisi, Kitaplar.YayinEvi, Kategori.KitapTuru, Kitaplar.StokSayisi," +
             "Kitaplar.BasimTarihi, Raf.RafNo, Aktiflik.Durum, Kitaplar.AlinmaSayisi 'OkunmaSayısı' FROM Kitaplar inner join Raf on Kitaplar.RafId = Raf.RafId inner join Aktiflik on Kitaplar.AktifId = Aktiflik.AktifId inner join" +
             " Kategori on Kitaplar.KategoriId = Kategori.KategoriId", dataGridView1);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aramatürü = cmbAramaTürü.Text;   
            if (aramatürü== "Numara")
            {
                VeriTabaniİslemleri.DataGridVerileriGöster("SELECT Kitaplar.KitapId 'Numara',Kitaplar.BarkodNo 'Barkod Numarası', Kitaplar.KitapAd 'Kitap Ad', Kitaplar.Yazar,Kitaplar.SayfaSayisi, Kitaplar.YayinEvi, Kategori.KitapTuru, Kitaplar.StokSayisi," +
                    " Kitaplar.BasimTarihi, Raf.RafNo,Aktiflik.Durum, Kitaplar.AlinmaSayisi 'OkunmaSayısı' FROM Kitaplar inner join Raf on Kitaplar.RafId = Raf.RafId inner join Aktiflik on Kitaplar.AktifId = Aktiflik.AktifId inner join Kategori" +
                    " on Kitaplar.KategoriId = Kategori.KategoriId WHERE KitapId='"+txtArama.Text+"'",dataGridView1);
            }
            else if (aramatürü== "Barkod Numarası")
            {
                VeriTabaniİslemleri.DataGridVerileriGöster("SELECT Kitaplar.KitapId 'Numara',Kitaplar.BarkodNo 'Barkod Numarası', Kitaplar.KitapAd 'Kitap Ad', Kitaplar.Yazar,Kitaplar.SayfaSayisi, Kitaplar.YayinEvi, Kategori.KitapTuru, Kitaplar.StokSayisi," +
                    " Kitaplar.BasimTarihi, Raf.RafNo, Aktiflik.Durum, Kitaplar.AlinmaSayisi 'OkunmaSayısı' FROM Kitaplar inner join Raf on Kitaplar.RafId = Raf.RafId inner join Aktiflik on Kitaplar.AktifId = Aktiflik.AktifId inner join Kategori" +
                    " on Kitaplar.KategoriId = Kategori.KategoriId WHERE BarkodNo like '%"+ txtArama.Text + "%'", dataGridView1);
            }
            else if (aramatürü== "Kitap Ad")
            {
                VeriTabaniİslemleri.DataGridVerileriGöster("SELECT Kitaplar.KitapId 'Numara',Kitaplar.BarkodNo 'Barkod Numarası', Kitaplar.KitapAd 'Kitap Ad', Kitaplar.Yazar,Kitaplar.SayfaSayisi, Kitaplar.YayinEvi, Kategori.KitapTuru, Kitaplar.StokSayisi," +
                  " Kitaplar.BasimTarihi, Raf.RafNo,Aktiflik.Durum, Kitaplar.AlinmaSayisi 'OkunmaSayısı' FROM Kitaplar inner join Raf on Kitaplar.RafId = Raf.RafId inner join Aktiflik on Kitaplar.AktifId = Aktiflik.AktifId inner join Kategori" +
                  " on Kitaplar.KategoriId = Kategori.KategoriId WHERE KitapAd like'%" + txtArama.Text + "%'", dataGridView1);
            }
            else if (aramatürü == "Yazar")
            {
                VeriTabaniİslemleri.DataGridVerileriGöster("SELECT Kitaplar.KitapId 'Numara',Kitaplar.BarkodNo 'Barkod Numarası', Kitaplar.KitapAd 'Kitap Ad', Kitaplar.Yazar,Kitaplar.SayfaSayisi, Kitaplar.YayinEvi, Kategori.KitapTuru, Kitaplar.StokSayisi," +
                  " Kitaplar.BasimTarihi, Raf.RafNo,Aktiflik.Durum, Kitaplar.AlinmaSayisi 'OkunmaSayısı' FROM Kitaplar inner join Raf on Kitaplar.RafId = Raf.RafId inner join Aktiflik on Kitaplar.AktifId = Aktiflik.AktifId inner join Kategori" +
                  " on Kitaplar.KategoriId = Kategori.KategoriId WHERE Yazar like'%" + txtArama.Text + "%'", dataGridView1);
            }
            else if (aramatürü == "Yayın Evi")
            {
                VeriTabaniİslemleri.DataGridVerileriGöster("SELECT Kitaplar.KitapId 'Numara',Kitaplar.BarkodNo 'Barkod Numarası', Kitaplar.KitapAd 'Kitap Ad', Kitaplar.Yazar,Kitaplar.SayfaSayisi, Kitaplar.YayinEvi, Kategori.KitapTuru, Kitaplar.StokSayisi," +
                  " Kitaplar.BasimTarihi, Raf.RafNo,Aktiflik.Durum, Kitaplar.AlinmaSayisi 'OkunmaSayısı' FROM Kitaplar inner join Raf on Kitaplar.RafId = Raf.RafId inner join Aktiflik on Kitaplar.AktifId = Aktiflik.AktifId inner join Kategori" +
                  " on Kitaplar.KategoriId = Kategori.KategoriId WHERE YayinEvi like'%" + txtArama.Text + "%'", dataGridView1);
            }
            else if (aramatürü == "Kitap Türü")
            {
                VeriTabaniİslemleri.DataGridVerileriGöster("SELECT Kitaplar.KitapId 'Numara',Kitaplar.BarkodNo 'Barkod Numarası', Kitaplar.KitapAd 'Kitap Ad', Kitaplar.Yazar,Kitaplar.SayfaSayisi, Kitaplar.YayinEvi, Kategori.KitapTuru, Kitaplar.StokSayisi," +
                  " Kitaplar.BasimTarihi, Raf.RafNo,Aktiflik.Durum, Kitaplar.AlinmaSayisi 'OkunmaSayısı' FROM Kitaplar inner join Raf on Kitaplar.RafId = Raf.RafId inner join Aktiflik on Kitaplar.AktifId = Aktiflik.AktifId inner join Kategori" +
                  " on Kitaplar.KategoriId = Kategori.KategoriId WHERE KitapTuru like'%" + txtArama.Text + "%'", dataGridView1);
            }
            else if (aramatürü == "Basım Tarihi")
            {
                VeriTabaniİslemleri.DataGridVerileriGöster("SELECT Kitaplar.KitapId 'Numara',Kitaplar.BarkodNo 'Barkod Numarası', Kitaplar.KitapAd 'Kitap Ad', Kitaplar.Yazar,Kitaplar.SayfaSayisi, Kitaplar.YayinEvi, Kategori.KitapTuru, Kitaplar.StokSayisi," +
                  " Kitaplar.BasimTarihi, Raf.RafNo,Aktiflik.Durum, Kitaplar.AlinmaSayisi 'OkunmaSayısı' FROM Kitaplar inner join Raf on Kitaplar.RafId = Raf.RafId inner join Aktiflik on Kitaplar.AktifId = Aktiflik.AktifId inner join Kategori" +
                  " on Kitaplar.KategoriId = Kategori.KategoriId WHERE BasimTarihi like'%" + txtArama.Text + "%'", dataGridView1);
            }
            else
            {
                VeriTabaniİslemleri.DataGridVerileriGöster("SELECT Kitaplar.KitapId 'Numara',Kitaplar.BarkodNo 'Barkod Numarası', Kitaplar.KitapAd 'Kitap Ad', Kitaplar.Yazar,Kitaplar.SayfaSayisi, Kitaplar.YayinEvi, Kategori.KitapTuru, Kitaplar.StokSayisi," +
                 " Kitaplar.BasimTarihi, Raf.RafNo,Aktiflik.Durum, Kitaplar.AlinmaSayisi 'OkunmaSayısı' FROM Kitaplar inner join Raf on Kitaplar.RafId = Raf.RafId inner join Aktiflik on Kitaplar.AktifId = Aktiflik.AktifId inner join Kategori" +
                 " on Kitaplar.KategoriId = Kategori.KategoriId WHERE RafNo like'%" + txtArama.Text + "%'", dataGridView1);
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            VeriTabaniİslemleri.DataGridVerileriGöster("SELECT Kitaplar.KitapId 'Numara',Kitaplar.BarkodNo 'Barkod Numarası', Kitaplar.KitapAd 'Kitap Ad', Kitaplar.Yazar, Kitaplar.SayfaSayisi, Kitaplar.YayinEvi, Kategori.KitapTuru, Kitaplar.StokSayisi," +
            "Kitaplar.BasimTarihi, Raf.RafNo, Aktiflik.Durum, Kitaplar.AlinmaSayisi 'OkunmaSayısı' FROM Kitaplar inner join Raf on Kitaplar.RafId = Raf.RafId inner join Aktiflik on Kitaplar.AktifId = Aktiflik.AktifId inner join" +
            " Kategori on Kitaplar.KategoriId = Kategori.KategoriId", dataGridView1);
        }
    }
}
