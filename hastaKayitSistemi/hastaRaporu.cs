using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace hastaKayitSistemi
{
    public partial class hastaRaporu : Form
    {
        private string hastaTC;
        string conString = "data source=.;initial catalog=hastaKayit;user id=sa;password=18982885638Hk+;MultipleActiveResultSets=True;";
        public hastaRaporu(string strhastaTC)
        {
            hastaTC = strhastaTC;
            InitializeComponent();
            
          
        }
        private string hastaAd;
        private string hastaSoyad;
        private string hastaCinsiyet;
        private string hastaYas;
        private string hastaBoy;
        private string hastaKilo;
        private static string doktor;
        private string doktorTC;
        private void doktorBilgileri()
        {
            
            SqlConnection con2 = new SqlConnection(conString);
            con2.Open();
            doktorTC = textBoxDoktorTC.Text;
            SqlCommand cmd2 = new SqlCommand("select unvan,ad,soyad from doktorlar where TCKimlikNo = '"+ doktorTC.Trim() +"'", con2);

            Console.WriteLine(doktorTC);
            cmd2.ExecuteNonQuery();
            
            SqlDataReader rdr;
            try
            {
                rdr = cmd2.ExecuteReader();
                while (rdr.Read())
                {
                    string a = rdr.GetString(0).Replace(" ","");
                    string b = rdr.GetString(1).Replace(" ","");
                    string c = rdr.GetString(2).Replace(" ", "");
                    doktor = a + " " + b + " " + c;
                    Console.WriteLine(doktor);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            con2.Close();
        }


        
        private void hastaBilgileri()
        {
            
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from hastalar where TCKimlikNo = @tc", con);
            cmd.Parameters.AddWithValue("@tc", hastaTC);
            cmd.ExecuteNonQuery();
            SqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    hastaAd = reader.GetString(1);
                    hastaSoyad = reader.GetString(2);
                    hastaCinsiyet = reader.GetString(4);
                    hastaYas = reader.GetString(5);
                    hastaBoy = reader.GetString(6);
                    hastaKilo = reader.GetString(7);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            con.Close();

        }
        private void hastaRapor()
        {
            DateTime tarih = dateTimePicker1.Value.Date;
            string sqlFormattedDate = tarih.Date.ToString("dd-MM-yyyy");
            string dosyaYolu = @"D:\hastaKayitSistemi\Raporlar\"+hastaTC+".doc";
            FileStream fs = new FileStream(dosyaYolu, FileMode.Create, FileAccess.Write);
            
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("Hasta Bilgileri");
            sw.WriteLine("------------------------------------------------------------------------");
            sw.WriteLine("TC Kimlik No:  " + hastaTC);
            sw.WriteLine("Adı:  " + hastaAd);
            sw.WriteLine("Soyadı:  " + hastaSoyad);
            sw.WriteLine("Cinsiyeti:  " + hastaCinsiyet);
            sw.WriteLine("Yaş:  " + hastaYas);
            sw.WriteLine("Boy:  " + hastaBoy);
            sw.WriteLine("Kilo:  " + hastaKilo);
            sw.WriteLine("------------------------------------------------------------------------");
            sw.WriteLine("Tanı:" + richTextBoxTani.Text);
            sw.WriteLine("------------------------------------------------------------------------");
            sw.WriteLine("Uygulanan Tedavi:" + richTextBoxTedavi.Text);
            sw.WriteLine("------------------------------------------------------------------------");
            sw.WriteLine("Tarih:  " + sqlFormattedDate);
            sw.WriteLine("------------------------------------------------------------------------");
            sw.WriteLine("Tedaviyi Uygulayan:  " + doktor);

            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void btnRaporOlustur_Click(object sender, EventArgs e)
        {
            doktorBilgileri();
            hastaBilgileri();
            hastaRapor();
            
        }
    }
}
