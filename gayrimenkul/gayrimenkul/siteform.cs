﻿using System;
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
    public partial class siteform : Form
    {
        public siteform()
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
            komut.CommandText = "insert into sitebilgileri (siteID, siteAdi, satKira, odaSayisi, metrekare, fiyat, blok, numara) values (@siteID, @siteAdi, @satKira, @odaSayisi, @metrekare, @fiyat, @blok, @numara)";

            komut.Parameters.AddWithValue("@siteID", idtextBox.Text);
            komut.Parameters.AddWithValue("@siteAdi", sitetextBox.Text);
            komut.Parameters.AddWithValue("@satKira", satkiratextBox.Text);
            komut.Parameters.AddWithValue("@odaSayisi", odatextBox.Text);
            komut.Parameters.AddWithValue("@metrekare", metretextBox.Text);
            komut.Parameters.AddWithValue("@fiyat", fiyattextBox.Text);
            komut.Parameters.AddWithValue("@blok", bloktextBox.Text);
            komut.Parameters.AddWithValue("@numara", notextBox.Text);

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
            komut.CommandText = "delete from sitebilgileri where siteID = @siteID";

            komut.Parameters.AddWithValue("@siteID", idtextBox.Text);

            if(komut.ExecuteNonQuery() > 0)
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

            SqlDataAdapter da = new SqlDataAdapter("select * from sitebilgileri", baglanti);

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
            komut.CommandText = "update sitebilgileri set siteAdi = @siteAdi, satKira = @satKira, odaSayisi = @odaSayisi, metrekare =  @metrekare, fiyat = @fiyat, blok = @blok, numara = @numara where siteID = @siteID";

            komut.Parameters.AddWithValue("@siteID", idtextBox.Text);
            komut.Parameters.AddWithValue("@siteAdi", sitetextBox.Text);
            komut.Parameters.AddWithValue("@satKira", satkiratextBox.Text);
            komut.Parameters.AddWithValue("odaSayisi", odatextBox.Text);
            komut.Parameters.AddWithValue("@metrekare", (metretextBox.Text));
            komut.Parameters.AddWithValue("@fiyat", fiyattextBox.Text);
            komut.Parameters.AddWithValue("@blok", bloktextBox.Text);
            komut.Parameters.AddWithValue("@numara", notextBox.Text);
            

            if (komut.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Güncellendi.");
            }

            baglanti.Close();
        }
    }
}
