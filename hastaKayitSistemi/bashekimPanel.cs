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
    public partial class bashekimPanel : Form
    {
        string conString = "data source=.;initial catalog = hastaKayit; user id = sa; password=12345;MultipleActiveResultSets=True;";
        public bashekimPanel()
        {
            InitializeComponent();
        }
        public static string secilenBolum = "";

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenBolum += comboBox1.SelectedItem.ToString();
            fillComboBoxDoktorSec();
        }
        public void fillComboBoxDoktorSec()
        {

            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand("select  unvan,ad,soyad from doktorlar where bolum = '" + secilenBolum + "'", con);
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
                    string d = a + b + c;
                    comboBox2.Items.Add(d);

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        private void randevuGoruntule()
        {
            string secilenDoktor = comboBox2.Text;
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


                dataGridView1.DataSource = dt;
                con2.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        private void btnRandevuListeleBashekim_Click(object sender, EventArgs e)
        {

            randevuGoruntule();

        }
        private void randevusilme()
        {
            SqlConnection con2 = new SqlConnection(conString);
            try
            {
                con2.Open();
                SqlCommand cmmd = new SqlCommand("delete from randevular where randevuNo=@randevuNo", con2);
                cmmd.Parameters.AddWithValue("@randevuNo", textBoxrandevuNo.Text);
                cmmd.ExecuteNonQuery();
                con2.Close();
                MessageBox.Show("Randevu Silindi!");
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
            }
        }
        private void btnRandevuSil_Click(object sender, EventArgs e)
        {
            randevusilme();
        }
        private string hastaTC;
        private void raporGoruntuleme()
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select TCKimlikNo from randevular where randevuNo=@randevuNo", con);
            cmd.Parameters.AddWithValue("@randevuNo", textBoxrandevuNo.Text);
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
            con.Close();
            System.Diagnostics.Process.Start(@"D:\hastaKayitSistemi\Raporlar\" + hastaTC + ".doc");
        }
        private void btnRaporGoruntule_Click(object sender, EventArgs e)
        {
            raporGoruntuleme();
        }
    }
}
