using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastaKayitSistemi
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void hastaGiris_Click(object sender, EventArgs e)
        {
            Form f3 = new hastaGiris();
            f3.Show();
            Hide();
        }

        private void doktorGiris_Click(object sender, EventArgs e)
        {
            Form f2 = new doktorGiris();
            f2.Show();
            Hide();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
