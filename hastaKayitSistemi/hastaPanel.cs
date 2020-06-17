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
    public partial class hastaPanel : Form
    {
        private string tc;
        string conString= "data source=.;initial catalog = hastaKayit; user id = sa; password=12345;MultipleActiveResultSets=True;";
        public hastaPanel(string strTextBox)
        {
            tc = strTextBox;
            InitializeComponent();
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string query = "select * from randevular where TCKimlikNo ='" + tc.Trim() + "'";
                Console.WriteLine(tc);

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                
                
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }
        public static string secilenBolum="";
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            secilenBolum += comboBoxBolum.SelectedItem.ToString();
            fillComboBoxDoktorSec();
            
        }
       
        
        public void fillComboBoxDoktorSec()
        {
           
            SqlConnection con = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand("select  unvan,ad,soyad from doktorlar where bolum = '"+ secilenBolum +"'", con);
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
                    comboBoxDoktor.Items.Add(d);
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        private void randevuKaydi()
        {

            randevular r = new randevular();

            r.hastaTCKimlikNo = textBoxTCKimlikNo.Text;
            r.randevuBolumu = comboBoxBolum.Text;
            r.doktorAd = comboBoxDoktor.Text;
            r.randevuTarihi = dateTimePicker1.Value.Date;
            r.randevuSaati = comboBoxSaat.Text;

            randevularDAO randevularDAO = new randevularDAO();
            randevularDAO.randevuKaydet(r);

            MessageBox.Show("Başarılı!");
        }
        private void btnRandevuOnay_Click(object sender, EventArgs e)
        {
            DateTime tarih = dateTimePicker1.Value.Date;
            string sqlFormattedDate = tarih.Date.ToString("yyyy-MM-dd");
            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from randevular where tarih=@tarih and saat=@saat", con);
                cmd.Parameters.AddWithValue("@tarih", sqlFormattedDate);
                cmd.Parameters.AddWithValue("@saat", comboBoxSaat.Text);
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    MessageBox.Show("Seçilen randevu daha önce alınmış. Yeni bir randevu alınız..");
                    Form f = new hastaPanel(textBoxTCKimlikNo.Text);
                    f.Show();
                    Close();
                }
                else
                {
                    randevuKaydi();
                }
                con.Close();
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
           
        }

        private void randevuAl_Load(object sender, EventArgs e)
        {

        }
        private void randevuGuncellemesi()
        {

            randevular r = new randevular();

            r.hastaTCKimlikNo = textBoxTCKimlikNo.Text;
            r.randevuBolumu = comboBoxBolum.Text;
            r.doktorAd = comboBoxDoktor.Text;
            r.randevuTarihi = dateTimePicker1.Value.Date;
            r.randevuSaati = comboBoxSaat.Text;

            randevularDAO randevularDAO = new randevularDAO();
            randevularDAO.randevuGuncelle(r);

            MessageBox.Show("Başarılı!");
        }
        private void btnRandevuGuncelle_Click(object sender, EventArgs e)
        {
            randevuGuncellemesi();
        }
        private void randevuSilme()
        {

            randevular r = new randevular();
            r.randevuNo = Convert.ToInt32(textBoxRandevuNo.Text);

            randevularDAO randevularDAO = new randevularDAO();
            randevularDAO.randevuSil(r);
            MessageBox.Show("Silindi!");
        }
        private void btnRandevuSil_Click(object sender, EventArgs e)
        {
            randevuSilme();
        }
    }
}
