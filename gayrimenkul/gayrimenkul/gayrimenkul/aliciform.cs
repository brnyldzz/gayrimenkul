using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gayrimenkul
{
    public partial class aliciform : Form
    {
        public aliciform()
        {
            InitializeComponent();
        }

        private void eklebutton_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=YILDIZPC\\SQLEXPRESS;Initial Catalog=gayrimenkul;Integrated Security=True;Encrypt=False";
            baglanti.Open();

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "insert into alicibilgileri (aliciID, aliciAd, aliciSoyad, aliciGsm) values (@aliciID, @aliciAd, @aliciSoyad, @aliciGsm)";

            komut.Parameters.AddWithValue("@aliciID", idtextBox.Text);
            komut.Parameters.AddWithValue("@aliciAd", adtextBox.Text);
            komut.Parameters.AddWithValue("@aliciSoyad", soyadtextBox.Text);
            komut.Parameters.AddWithValue("@aliciGsm", telefontextBox.Text);

            if (komut.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Eklendi.");
            }

            baglanti.Close();

        }

        private void silbutton_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=YILDIZPC\\SQLEXPRESS;Initial Catalog=gayrimenkul;Integrated Security=True;Encrypt=False";
            baglanti.Open();

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "delete from alicibilgileri where aliciID = @aliciID";

            komut.Parameters.AddWithValue("aliciID", idtextBox.Text);

            if (komut.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Silindi.");
            }
            baglanti.Close();
        }

        private void gosterbutton_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=YILDIZPC\\SQLEXPRESS;Initial Catalog=gayrimenkul;Integrated Security=True;Encrypt=False";
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from alicibilgileri", baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            baglanti.Close();
        }

        private void guncellebutton_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=YILDIZPC\\SQLEXPRESS;Initial Catalog=gayrimenkul;Integrated Security=True;Encrypt=False";
            baglanti.Open();

            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "update alicibilgileri set aliciAd = @aliciAd, aliciSoyad = @aliciSoyad, aliciGsm = @aliciGsm where aliciID = @aliciID";

            komut.Parameters.AddWithValue("@aliciID", idtextBox.Text);
            komut.Parameters.AddWithValue("@aliciAd", adtextBox.Text);
            komut.Parameters.AddWithValue("@aliciSoyad", soyadtextBox.Text);
            komut.Parameters.AddWithValue("@aliciGsm", telefontextBox.Text);

            if (komut.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Güncellendi.");
            }

            baglanti.Close();
        }
    }
}
