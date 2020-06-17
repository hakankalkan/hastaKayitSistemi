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
    public partial class bolumBaskaniPanel : Form
    {
        private string doktorTC;
        string conString = "data source=.;initial catalog = hastaKayit; user id = sa; password=12345;MultipleActiveResultSets=True;";
        public bolumBaskaniPanel(string strTextBox)
        {
            doktorTC = strTextBox;
            InitializeComponent();
        }
        private string [] doktor = new string[35];
        public static string secilenBolum = "";
        
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            

        }

        
        public void fillComboBoxDoktorSec()
        {

            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand("select  unvan,ad,soyad from doktorlar where bolum = '" + secilenBolum + "'", con);
            SqlDataReader reader;
            int i = 0;
            try
            {

                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string a = reader.GetString(0);
                    string b = reader.GetString(1);
                    string c = reader.GetString(2);
                    doktor[i] = a + b + c;
                    comboBox1.Items.Add(doktor[i]);
                    i++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private void bolumSecme()
        {
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand("select bolum from doktorlar where TCKimlikNo='" + doktorTC.Trim() + "'", con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    secilenBolum += reader.GetString(0);
                }

            }

            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
            }
        }
        private void bolumBaskaniPanel_Load(object sender, EventArgs e)
        {

            bolumSecme();
            fillComboBoxDoktorSec();
        }
        private void randevuGoruntuleme()
        {
            int indeks = comboBox1.SelectedIndex;
            string secilenDoktor = doktor[indeks];
            Console.WriteLine(secilenDoktor);
            DateTime tarih = dateTimePicker1.Value.Date;
            string sqlFormattedDate = tarih.Date.ToString("yyyy-MM-dd");
            SqlConnection con2 = new SqlConnection(conString);
            try
            {
                con2.Open();
                string query = "select * from randevular where doktor='" + secilenDoktor + "' and cast ([tarih] as date)=@date";
                Console.WriteLine(tarih);
                Console.WriteLine(sqlFormattedDate);
                SqlCommand cmd2 = new SqlCommand(query, con2);
                cmd2.Parameters.AddWithValue("@date", sqlFormattedDate);
                cmd2.ExecuteNonQuery();


                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd2;
                DataTable dt = new DataTable();
                da.Fill(dt);


                dataGridView2.DataSource = dt;
                con2.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void btnRandevuGoruntule_Click(object sender, EventArgs e)
        {
            randevuGoruntuleme();
        }
        private void randevuSilme()
        {

            SqlConnection conn = new SqlConnection(conString);
            try
            {
                conn.Open();
                SqlCommand cmmd = new SqlCommand("delete from randevular where randevuNo=@randevuNo", conn);
                cmmd.Parameters.AddWithValue("@randevuNo", textBoxRandevuSil.Text);
                cmmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
        private void btnRandevuSil_Click(object sender, EventArgs e)
        {
            randevuSilme();
        }
        private string hastaTC;
        private DateTime tarih;
        private void raporGoruntule()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select TCKimlikNo,tarih from randevular where randevuNo=@randevuNo", con);
            cmd.Parameters.AddWithValue("@randevuNo", textBoxRandevuSil.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader rdr;
            try
            {
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    hastaTC = rdr.GetString(0);
                    tarih = rdr.GetDateTime(1);
                    Console.WriteLine(hastaTC);
                    Console.WriteLine(tarih);
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            con.Close();
            
            
            System.Diagnostics.Process.Start(@"D:\hastaKayitSistemi\Raporlar\"+ hastaTC +".doc");
        }
        private void btnRaporGoruntule_Click(object sender, EventArgs e)
        {
            raporGoruntule();
        }
        private string raporYazHastaTC;
        private void raporYaz()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select TCKimlikNo from randevular where randevuNo=@randevuNo", con);
            cmd.Parameters.AddWithValue("@randevuNo", textBoxRandevuSil.Text);
            SqlDataReader rdr;
            try
            {
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    raporYazHastaTC = rdr.GetString(0);
                }
            }
            catch
            {
                throw;
            }
            con.Close();

            Form f = new hastaRaporu(raporYazHastaTC);
            f.Show();
        }
        private void btnRaporYaz_Click(object sender, EventArgs e)
        {
            raporYaz();
        }
    }
}
