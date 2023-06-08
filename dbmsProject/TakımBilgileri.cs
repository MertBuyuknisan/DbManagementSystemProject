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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace dbmsProject
{
    public partial class TakımBilgileri : Form
    {
        SqlConnection baglantı = new SqlConnection("Data Source=HpGaming\\SQLEXPRESS;Initial Catalog=SportsDatabase;Integrated Security=True");
        public TakımBilgileri()
        {
            InitializeComponent();
        }

        private void TakımBilgileri_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select takım_id as 'Takım ID', takım_adı as 'Takım Adı',takım_ülke as 'Bulunduğu Ülke',takım_bütce as 'Takımın Bütçesi',takım_stad as 'Takımın Stadı' from takımlar"; ;
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }

        private void OyuncularıGöster_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT t.takım_adı as 'Takım Adı',t.takım_ülke as 'Ülke',t.takım_stad as 'Stad İsmi',o.oyuncu_ad as 'Oyuncu Adı',o. oyuncu_soyad as 'Oyuncu Soyadı',o.oyuncu_yas as 'Oyuncunun Yaşı',o.oyuncu_degeri as 'Oyuncunun Değeri' FROM oyuncular o JOIN takımlar t ON   o.oyuncu_takım = t.takım_adı ORDER BY t.takım_adı, o.oyuncu_ad, o.oyuncu_soyad", baglantı);

            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void takımgolsıralamabtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT t.takım_adı as 'Takım Adı', SUM(o.atılan_gol) AS Toplam_Gol FROM oyuncular o JOIN takımlar t ON o.oyuncu_takım=t.takım_adı GROUP BY t.takım_adı ORDER BY toplam_gol DESC", baglantı);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT t.takım_adı, COUNT(*) AS taraftar_sayısı FROM taraftarlar tf JOIN takımlar t ON tf.taraftar_takım = t.takım_adı GROUP BY t.takım_adı ORDER BY taraftar_sayısı DESC", baglantı);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
    }
}
