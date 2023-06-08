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
    public partial class TaraftarEkle : Form
    {
        SqlConnection baglantı = new SqlConnection("Data Source=HpGaming\\SQLEXPRESS;Initial Catalog=SportsDatabase;Integrated Security=True");
        public TaraftarEkle()
        {
            InitializeComponent();
        }

        private void taraftarkayıt_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into taraftarlar(taraftar_isim,taraftar_soyisim,taraftar_yas,taraftar_takım,taraftar_telefon)" +
                "values (@taraftar_isim,@taraftar_soyisim,@taraftar_yas,@taraftar_takım,@taraftar_telefon)", baglantı);
            komut.Parameters.AddWithValue("@taraftar_isim", taraftaradtxt.Text);
            komut.Parameters.AddWithValue("@taraftar_soyisim", taraftarsoyadtxt.Text);
            komut.Parameters.AddWithValue("@taraftar_yas", taraftaryastxt.Text);
            komut.Parameters.AddWithValue("@taraftar_takım", taraftartakımtxt.Text);
            komut.Parameters.AddWithValue("@taraftar_telefon", taraftartlftxt.Text);


            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            komut.CommandText = "Select taraftarid as 'Taraftar ID',taraftar_isim as 'Taraftar Ad',taraftar_soyisim as 'Taraftar Soyad',taraftar_yas as 'Taraftarın Yaşı',taraftar_takım as 'Taraftarın Takımı',taraftar_telefon as 'Taraftarın Telefonu' from taraftarlar ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void TaraftarEkle_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "Select taraftarid as 'Taraftar ID',taraftar_isim as 'Taraftar Ad',taraftar_soyisim as 'Taraftar Soyad',taraftar_yas as 'Taraftarın Yaşı',taraftar_takım as 'Taraftarın Takımı',taraftar_telefon as 'Taraftarın Telefonu' from taraftarlar ";
            komut.Connection = baglantı;
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
    }
}
