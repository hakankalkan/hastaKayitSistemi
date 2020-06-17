using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastaKayitSistemi
{
    class hastalarDAO
    {
        string conString = "data source=.;initial catalog = hastaKayit; user id = sa; password=12345;MultipleActiveResultSets=True;";
        public void hastaKaydet(hastalar h)
            
        {
            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into hastalar(TCKimlikNo, ad, soyad, telefon, cinsiyet, yas, boy, kilo) values (@TCKimlikNo, @ad, @soyad, @telefon,@cinsiyet, @yas, @boy, @kilo)", con);
                
                int.TryParse(h.hastaYas, out int y);
                int.TryParse(h.hastaBoy, out int z);
                int.TryParse(h.hastaKilo, out int t);
                cmd.Parameters.AddWithValue("@TCKimlikNo", h.hastaTCKimlikNo);
                cmd.Parameters.AddWithValue("@ad", h.hastaAd);
                cmd.Parameters.AddWithValue("@soyad", h.hastaSoyad);
                cmd.Parameters.AddWithValue("@telefon", h.hastaTel);
                cmd.Parameters.AddWithValue("@cinsiyet", h.hastaCinsiyet);
                cmd.Parameters.AddWithValue("@yas", y);
                cmd.Parameters.AddWithValue("@boy", z);
                cmd.Parameters.AddWithValue("@kilo", t);

                cmd.ExecuteNonQuery();
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Close();

            SqlConnection con2 = new SqlConnection(conString);
            try
            {
                con2.Open();
                SqlCommand cmd2 = new SqlCommand("insert into hastaGiris(TCKimlikNo, sifre) values (@TC, @sifre)", con2);
                
                cmd2.Parameters.AddWithValue("@TC", h.hastaTCKimlikNo);
                cmd2.Parameters.AddWithValue("@sifre", h.hastaSifre);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Eklendi");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            con2.Close();
        }

        
        
        }
       
    }

