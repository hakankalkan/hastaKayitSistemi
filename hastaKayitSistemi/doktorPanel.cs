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
    
    public partial class doktorPanel : Form
    {
        private string doktorTC;
        string conString = "data source=.;initial catalog=hastaKayit;user id=sa;password=12345;MultipleActiveResultSets=True;";

        public doktorPanel(string strTextBox)
        {
            doktorTC = strTextBox;
            InitializeComponent();

        }
        private string doktor;
        private void randevuGor()
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand("select  unvan,ad,soyad from doktorlar where TCKimlikNo = @doktorTC", con);
            cmd.Parameters.AddWithValue("@doktorTC", doktorTC);

            SqlDataReader reader;
            try
            {

                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string a = reader.GetString(0);
                    string b = reader.GetString(1);
                    string c = reader.GetString(2);
                    doktor = a + b + c;
                }
                Console.WriteLine(doktor);
            }
            catch
            {

                throw;

            }
            con.Close();
            DateTime tarih = dateTimePicker1.Value.Date;
            string sqlFormattedDate = tarih.Date.ToString("yyyy-MM-dd");
            SqlConnection con2 = new SqlConnection(conString);
            try
            {
                con2.Open();
                string query = "select * from randevular where doktor='" + doktor + "' and cast ([tarih] as date)=@date";

                SqlCommand cmd2 = new SqlCommand(query, con2);
                cmd2.Parameters.AddWithValue("@date", sqlFormattedDate);
                cmd2.ExecuteNonQuery();


                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd2;
                DataTable dt = new DataTable();
                da.Fill(dt);
                

                dataGridView1.DataSource = dt;
                con2.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void btnRandevuListele_Click(object sender, EventArgs e)
        {
            randevuGor();
        }
        private void randevuSilme()
        {
            SqlConnection con = new SqlConnection(conString);

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from randevular where randevuNo = @randevuNo", con);
                cmd.Parameters.AddWithValue("@randevuNo", textBox1.Text);
                cmd.ExecuteNonQuery();

            }
            catch(Exception e2)
            {
                Console.WriteLine(e2.Message);
            }
            MessageBox.Show("Randevu Silindi");

        }
        private void btnRandevuSil_Click(object sender, EventArgs e)
        {
            randevuSilme();
        }
        private string hastaTC;
        private void raporOlustur()
        {

            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select TCKimlikNo from randevular where randevuNo=@randevuNo", con);
            cmd.Parameters.AddWithValue("@randevuNo", textBox1.Text);
            SqlDataReader rdr;
            try
            {
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    hastaTC = rdr.GetString(0);
                }
            }
            catch
            {
                throw;
            }
            Form f = new hastaRaporu(hastaTC);
            f.Show();
        }
        private void btnRaporOlustur_Click(object sender, EventArgs e)
        {
            raporOlustur();
        }
    }
}
