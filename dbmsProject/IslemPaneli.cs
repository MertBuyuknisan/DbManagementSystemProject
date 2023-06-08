using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace dbmsProject
{
    public partial class IslemPaneli : Form
    {
        SqlConnection baglantı = new SqlConnection("Data Source=HpGaming\\SQLEXPRESS;Initial Catalog=SportsDatabase;Integrated Security=True");
        public IslemPaneli()
        {
            InitializeComponent();
        }

        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            OyuncuEkle.Visible = false;
            OyuncuGüncelle.Visible = false;
            OyuncuSil.Visible = false;
            GolKralıbtn.Visible = false;
            Asistkralıbtn.Visible = false;
            takımeklebtn.Visible = false;
            takımgüncellebtn.Visible = false;
            takımsilbtn.Visible = false;
            Takımbilgileribtn.Visible = false;
            taraftareklebtn.Visible = false;
            taraftarsilbtn.Visible = false;


        }

        private void Oyuncular_Click(object sender, EventArgs e)
        {
            if (OyuncuEkle.Visible == false)
            {
                OyuncuEkle.Visible = true;
                OyuncuGüncelle.Visible = true;
                OyuncuSil.Visible = true;
            }
            else
            {
                OyuncuEkle.Visible = false;
                OyuncuGüncelle.Visible = false;
                OyuncuSil.Visible = false;
            }
            //OyuncuListe oyuncuListe = new OyuncuListe();
            //oyuncuListe.MdiParent = this;
            //oyuncuListe.Show();
            if (OyuncuEkle.Visible == true)
            {
                İstatistiklerbtn.Visible = false;
                takımlarbtn.Visible = false;
                taraftarlarbtn.Visible = false;
            }
            else
            {
                İstatistiklerbtn.Visible = true;
                takımlarbtn.Visible = true;
                taraftarlarbtn.Visible = true;
            }

        }

        private void OyuncuEkle_Click(object sender, EventArgs e)
        {
            OyuncuEkle yenioyuncu = new OyuncuEkle();
            yenioyuncu.MdiParent = this;
            yenioyuncu.Show();

        }


        private void OyuncuSil_Click(object sender, EventArgs e)
        {
            OyuncuSil oyuncusil = new OyuncuSil();
            oyuncusil.MdiParent = this;
            oyuncusil.Show();

        }

        private void OyuncuGüncelle_Click(object sender, EventArgs e)
        {
            OyuncuGüncelle oyuncugüncelle = new OyuncuGüncelle();
            oyuncugüncelle.MdiParent = this;
            oyuncugüncelle.Show();
        }

        private void İstatistiklerbtn_Click(object sender, EventArgs e)
        {
            if (GolKralıbtn.Visible == false)
            {
                GolKralıbtn.Visible = true;
                Asistkralıbtn.Visible = true;

            }
            else
            {
                GolKralıbtn.Visible = false;
                Asistkralıbtn.Visible = false;

            }
            if (GolKralıbtn.Visible == true)
            {
                Oyuncular.Visible = false;
                takımlarbtn.Visible = false;
                taraftarlarbtn.Visible = false;
            }
            else
            {
                Oyuncular.Visible = true;
                takımlarbtn.Visible = true;
                taraftarlarbtn.Visible = true;
            }
        }

        private void GolKralıbtn_Click(object sender, EventArgs e)
        {
            GolKralıbtn golKralıbtn = new GolKralıbtn();
            golKralıbtn.MdiParent = this;
            golKralıbtn.Show();
        }

        private void Asistkralıbtn_Click(object sender, EventArgs e)
        {
            Asistkralıbtn asistkralıbtn = new Asistkralıbtn();
            asistkralıbtn.MdiParent = this;
            asistkralıbtn.Show();

        }
        private void takımlarbtn_Click(object sender, EventArgs e)
        {
            if (takımeklebtn.Visible == false)
            {
                takımeklebtn.Visible = true;
                takımgüncellebtn.Visible = true;
                takımsilbtn.Visible = true;
                Takımbilgileribtn.Visible = true;
            }
            else
            {
                takımeklebtn.Visible = false;
                takımgüncellebtn.Visible = false;
                takımsilbtn.Visible = false;
                Takımbilgileribtn.Visible = false;
            }
            if (takımeklebtn.Visible == true)
            {
                Oyuncular.Visible = false;
                İstatistiklerbtn.Visible = false;
                taraftarlarbtn.Visible = false;
            }
            else
            {
                Oyuncular.Visible = true;
                İstatistiklerbtn.Visible = true;
                taraftarlarbtn.Visible = true;
            }

        }

        private void takımeklebtn_Click(object sender, EventArgs e)
        {
            TakımEkle takımekle = new TakımEkle();
            takımekle.MdiParent = this;
            takımekle.Show();
        }

        private void takımsilbtn_Click(object sender, EventArgs e)
        {
            TakımSil takımSil = new TakımSil();
            takımSil.MdiParent = this;
            takımSil.Show();
        }

        private void takımgüncellebtn_Click(object sender, EventArgs e)
        {
            TakımGüncelle takımGüncelle = new TakımGüncelle();
            takımGüncelle.MdiParent = this;
            takımGüncelle.Show();
        }

        private void Takımbilgileribtn_Click(object sender, EventArgs e)
        {
            TakımBilgileri takımbilgileri = new TakımBilgileri();
            takımbilgileri.MdiParent = this;
            takımbilgileri.Show();
        }

        private void taraftarlarbtn_Click(object sender, EventArgs e)
        {
            if (taraftareklebtn.Visible == false)
            {
                taraftareklebtn.Visible = true;
                taraftarsilbtn.Visible = true;

            }
            else
            {
                taraftareklebtn.Visible = false;
                taraftarsilbtn.Visible = false;

            }

            if (taraftareklebtn.Visible == true)
            {
                Oyuncular.Visible = false;
                İstatistiklerbtn.Visible = false;
                takımlarbtn.Visible = false;

            }
            else
            {
                Oyuncular.Visible = true;
                İstatistiklerbtn.Visible = true;
                takımlarbtn.Visible = true;
            }
        }

        private void taraftareklebtn_Click(object sender, EventArgs e)
        {
            TaraftarEkle taraftarEkle = new TaraftarEkle();
            taraftarEkle.MdiParent = this;
            taraftarEkle.Show();
        }

        private void taraftarsilbtn_Click(object sender, EventArgs e)
        {
            TaraftarSil taraftarSil = new TaraftarSil();
            taraftarSil.MdiParent = this;
            taraftarSil.Show();
        }
    }
}
