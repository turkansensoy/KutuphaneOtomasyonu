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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }

        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            SqlCommand cmdEnCokOkunanKitap = new SqlCommand("SELECT KitapAd,AlinmaSayisi FROM Kitaplar WHERE AlinmaSayisi=(SELECT MAX(AlinmaSayisi) FROM Kitaplar) ", VeriTabaniİslemleri.Baglan());
            SqlDataReader oku = cmdEnCokOkunanKitap.ExecuteReader();
            while (oku.Read())
            {
                lblEnCokOkunanKitap.Text = oku["KitapAd"].ToString() +"  "+ oku["AlinmaSayisi"] +" "+"defa alınarak en çok okunan kitaptır ";
            }
            SqlCommand cmdEnCokKitapAlanKişi = new SqlCommand("SELECT TOP 1 Uyeler.AdSoyad 'adSoyad', count(*) as 'okunmasayisi' FROM Emanet inner join Uyeler on Uyeler.UyeId=Emanet.UyeId group by Uyeler.AdSoyad " +
                " order by COUNT(*) desc ", VeriTabaniİslemleri.Baglan());
            SqlDataReader dr = cmdEnCokKitapAlanKişi.ExecuteReader();
            while (dr.Read())
            {
                lblEnCokKitapOkuyan.Text = dr["adSoyad"].ToString() + " kişisi " + dr["okunmasayisi"] + " adet kitap  okuyarak en çok kitap okuyan kişidir.";
            }

        }
    }
}
