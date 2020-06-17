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
    public partial class hastaKayit : Form
    {
        public hastaKayit()
        {
            InitializeComponent();
        }
        private void hastaKaydi()
        {
            hastalar h = new hastalar();

            h.hastaTCKimlikNo = textBoxHastaTC.Text;
            h.hastaAd = textBoxHastaAd.Text;
            h.hastaSoyad = textBoxHastaSoyad.Text;
            h.hastaCinsiyet = comboBox1.Text;
            h.hastaTel = textBoxHastaTel.Text;
            h.hastaYas = textBoxHastaYas.Text;
            h.hastaBoy = textBoxHastaBoy.Text;
            h.hastaKilo = textBoxHastaKilo.Text;
            h.hastaSifre = textBoxSifre.Text;

            hastalarDAO hastalarDAO = new hastalarDAO();
            hastalarDAO.hastaKaydet(h);

            Close();
        }
        private void btnHastaKaydet_Click(object sender, EventArgs e)
        {
            hastaKaydi();
        }

        private void hastaKayit_Load(object sender, EventArgs e)
        {
           

        }
    }
}
