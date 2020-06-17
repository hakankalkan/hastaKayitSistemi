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

namespace hastaKayitSistemi
{
    public partial class doktorGiris : Form
    {

        string conString = "data source=.;initial catalog=hastaKayit;user id=sa;password=12345;MultipleActiveResultSets=True;";
        private static int count = 0;
        private static int yetkiNo = 0;
        public doktorGiris()
        {
            InitializeComponent();
        }
        private void doktorGirisi()
        {
            string girilenTC = textBoxDoktorGiris1.Text;
            string girilensifre = textBoxDoktorGiris2.Text;

            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
                string query = "SELECT * FROM doktorGiris WHERE TCKimlikNo = '" + girilenTC.Trim() + "' AND sifre = '" + girilensifre.Trim() + "'";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                count = ds.Tables[0].Rows.Count;

                con.Close();

                SqlConnection con2 = new SqlConnection(conString);
                SqlCommand cmd = new SqlCommand("SELECT yetkiNo FROM doktorlar WHERE TCKimlikNo = '" + girilenTC.Trim() + "'", con2);
                SqlDataReader dr;
                try
                {
                    con2.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        yetkiNo = dr.GetInt32(0);

                    }
                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1);
                }
                con2.Close();

                if (count != 1)
                {
                    MessageBox.Show("TC Kimlik No veya Şifre Hatalı!!");
                }
                if (count == 1 && yetkiNo == 3)
                {
                    Form f = new doktorPanel(textBoxDoktorGiris1.Text);
                    f.Show();
                    Hide();
                }
                if (count == 1 && yetkiNo == 2)
                {
                    Form f = new bolumBaskaniPanel(textBoxDoktorGiris1.Text);
                    f.Show();
                    Hide();
                }
                if (count == 1 && yetkiNo == 1)
                {
                    Form f = new bashekimPanel();
                    f.Show();
                    Hide();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private void btnDoktorGiris_Click(object sender, EventArgs e)
        {
            doktorGirisi();
        }

        private void doktorGiris_Load(object sender, EventArgs e)
        {
            textBoxDoktorGiris2.PasswordChar = '*';
        }
    }
}
