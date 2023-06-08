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

namespace dbmsProject
{
    public partial class OyuncuEkle : Form
    {
        SqlConnection baglantı = new SqlConnection("Data Source=HpGaming\\SQLEXPRESS;Initial Catalog=SportsDatabase;Integrated Security=True");
        public OyuncuEkle()
        {
            InitializeComponent();
        }

        private void oyuncukayıt_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into oyuncular(oyuncu_ad,oyuncu_soyad,oyuncu_degeri,oyuncu_takım,oyuncu_yas,atılan_gol,yapılan_asist)" +
                "values (@oyuncu_ad,@oyuncu_soyad,@oyuncu_degeri,@oyuncu_takım,@oyuncu_yas,@atılan_gol,@yapılan_asist)", baglantı);
            komut.Parameters.AddWithValue("@oyuncu_ad", OyuncuAdtxt.Text);
            komut.Parameters.AddWithValue("@oyuncu_soyad", OyuncuSoyadtxt.Text);
            komut.Parameters.AddWithValue("@oyuncu_degeri", OyuncuDegertxt.Text);
            komut.Parameters.AddWithValue("@oyuncu_takım", OyuncuTakımtxt.Text);
            komut.Parameters.AddWithValue("@oyuncu_yas", OyuncuYastxt.Text);
            komut.Parameters.AddWithValue("@atılan_gol", AtılanGoltxt.Text);
            komut.Parameters.AddWithValue("@yapılan_asist", asisttxt.Text);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            komut.CommandText = "Select oyuncu_id as 'Oyuncu ID',oyuncu_ad as 'Oyuncu Adı',oyuncu_soyad as 'Oyuncu Soyadı',oyuncu_degeri as 'Oyuncu Değeri',oyuncu_takım as 'Oyuncunun Takımı',oyuncu_yas as 'Oyuncunun Yaşı',atılan_gol as 'Atılan Gol',yapılan_asist as 'Yapılan Asist' from oyuncular ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void OyuncuEkle_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select oyuncu_id as 'Oyuncu ID',oyuncu_ad as 'Oyuncu Adı',oyuncu_soyad as 'Oyuncu Soyadı',oyuncu_degeri as 'Oyuncu Değeri',oyuncu_takım as 'Oyuncunun Takımı',oyuncu_yas as 'Oyuncunun Yaşı',atılan_gol as 'Atılan Gol' from oyuncular ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void OyuncuAdtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
