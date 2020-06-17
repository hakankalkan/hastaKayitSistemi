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
    public partial class hastaGiris : Form
    {
        string conString = "data source=.;initial catalog=hastaKayit;user id=sa;password=12345;MultipleActiveResultSets=True;";
        public hastaGiris()
        {
            InitializeComponent();
        }

        private void btnHastaKayit_Click(object sender, EventArgs e)
        {
            Form f4 = new hastaKayit();
            f4.Show();
        }
        private void hastaGirisi()
        {
            
            string girilenTC = textBoxHastaGiris1.Text;
            string girilensifre = textBoxHastaGiris2.Text;
            
            int count = 0;

            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
                string query = "SELECT * FROM hastaGiris WHERE TCKimlikNo = '" + girilenTC.Trim() + "' AND sifre = '" + girilensifre.Trim() + "'";

                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                count = ds.Tables[0].Rows.Count;

                con.Close();


                if (count == 1)
                {
                    Form form = new hastaPanel(textBoxHastaGiris1.Text);

                    form.Show();
                    Hide();
                }
                if (count != 1)
                {
                    MessageBox.Show("TC kimlik no veya şifre hatalı!!");
                }
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void btnHastaGiris_Click(object sender, EventArgs e)
        {
            
            
            hastaGirisi();
            
        }

        private void hastaGiris_Load(object sender, EventArgs e)
        {
            textBoxHastaGiris1.MaxLength = 11;
            
            textBoxHastaGiris2.PasswordChar = '*';
        }
    }
}
