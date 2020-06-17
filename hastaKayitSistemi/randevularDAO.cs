using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastaKayitSistemi
{
    class randevularDAO
    {
        string conString = "data source=.;initial catalog = hastaKayit; user id = sa; password=12345;MultipleActiveResultSets=True;";
        public void randevuKaydet(randevular r)

        {
            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into randevular (TCKimlikNo, bolum, doktor, tarih, saat) values (@TCKimlikNo, @bolum, @doktor, @tarih, @saat)", con);

                
                cmd.Parameters.AddWithValue("@TCKimlikNo", r.hastaTCKimlikNo);
                cmd.Parameters.AddWithValue("@doktor", r.doktorAd);
                
                cmd.Parameters.AddWithValue("@bolum", r.randevuBolumu);
                cmd.Parameters.AddWithValue("@tarih", r.randevuTarihi);
                cmd.Parameters.AddWithValue("@saat", r.randevuSaati);


                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Close();

            
        }
        public void randevuSil(randevular r)
        {
            SqlConnection con = new SqlConnection(conString);
            
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from randevular where randevuNo = @randevuNo", con);
                cmd.Parameters.AddWithValue("@randevuNo", r.randevuNo);
                cmd.ExecuteNonQuery();

            }
            catch
            {
                throw;
            }
        }
        public void randevuGuncelle(randevular r)
        {
            SqlConnection con = new SqlConnection(conString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update randevular set TCKimlikNo=@TCKimlikNo, bolum=@bolum, doktor=@doktor, tarih=@tarih, saat=@saat where randevuNo=@randevuNo", con);


                cmd.Parameters.AddWithValue("@TCKimlikNo", r.hastaTCKimlikNo);
                cmd.Parameters.AddWithValue("@doktor", r.doktorAd);

                cmd.Parameters.AddWithValue("@bolum", r.randevuBolumu);
                cmd.Parameters.AddWithValue("@tarih", r.randevuTarihi);
                cmd.Parameters.AddWithValue("@saat", r.randevuSaati);

                cmd.Parameters.AddWithValue("@randevuNo", r.randevuNo);
                
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Close();

        }
    }
}
