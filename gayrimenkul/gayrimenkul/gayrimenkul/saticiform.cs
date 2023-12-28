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

namespace gayrimenkul
{
    public partial class saticiform : Form
    {
        public saticiform()
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
            komut.CommandText = "insert into saticibilgileri (saticiID, saticiAd, SaticiSoyad, SaticiGsm) values (@saticiID, @saticiAd, @saticiSoyad, @saticiGsm)";

            komut.Parameters.AddWithValue("@saticiID", idtextBox.Text);
            komut.Parameters.AddWithValue("@saticiAd", adtextBox.Text);
            komut.Parameters.AddWithValue("@saticiSoyad", soyadtextBox.Text);
            komut.Parameters.AddWithValue("@saticiGsm", telefontextBox.Text);

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
            komut.CommandText = "delete from saticibilgileri where saticiID = @saticiID";

            komut.Parameters.AddWithValue("saticiID", idtextBox.Text);

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

            SqlDataAdapter da = new SqlDataAdapter("select * from saticibilgileri", baglanti);

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
            komut.CommandText = "update saticibilgileri set saticiAd = @saticiAd, saticiSoyad = @saticiSoyad, saticiGsm = @saticiGsm where saticiID = @saticiID";

            komut.Parameters.AddWithValue("@saticiID", idtextBox.Text);
            komut.Parameters.AddWithValue("@saticiAd", adtextBox.Text);
            komut.Parameters.AddWithValue("@saticiSoyad", soyadtextBox.Text);
            komut.Parameters.AddWithValue("@saticiGsm", telefontextBox.Text);

            if (komut.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Güncellendi.");
            }

            baglanti.Close();
        }
    }
}
