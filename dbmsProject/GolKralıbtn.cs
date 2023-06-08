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
    public partial class GolKralıbtn : Form
    {
        SqlConnection baglantı = new SqlConnection("Data Source=HpGaming\\SQLEXPRESS;Initial Catalog=SportsDatabase;Integrated Security=True");
        public GolKralıbtn()
        {
            InitializeComponent();
        }

        private void GolKralıbtn_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select oyuncu_id as 'Oyuncu ID',oyuncu_ad as 'Oyuncu Adı',oyuncu_soyad as 'Oyuncu Soyadı',oyuncu_degeri as 'Oyuncu Değeri',oyuncu_takım as 'Oyuncunun Takımı',oyuncu_yas as 'Oyuncunun Yaşı',atılan_gol as 'Atılan Gol', yapılan_asist as 'Yapılan Asist' from oyuncular  where atılan_gol=(select max (atılan_gol)from oyuncular) ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;


        }


    }
}
