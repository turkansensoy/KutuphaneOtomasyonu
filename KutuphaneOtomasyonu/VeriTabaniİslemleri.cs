using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace KutuphaneOtomasyonu
{
    class VeriTabaniİslemleri // veri tabani işlemleri
    {
        public static SqlConnection Baglan()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-QK3J5Q0;Initial Catalog=dboKütüphane;Integrated Security=True");
                connection.Open();
                return connection;
            }
            catch
            {
                MessageBox.Show("Baglantı Hatası","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }  
        }
        public static void  DataGridVerileriGöster(string veriler, DataGridView dataGridView)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, VeriTabaniİslemleri.Baglan());
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView.DataSource = ds.Tables[0];    
        }
       


    }
}
