using PBO_Gymly.JadwalGym;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO_Gymly
{
    public partial class HomepageCustomer : Form
    {
        public HomepageCustomer()
        {
            InitializeComponent();
        }

        private void Button_Jadwal_Click(object sender, EventArgs e)
        {
            TampilanJadwal TampilanJadwal = new TampilanJadwal();
            
            TampilanJadwal.Show();

            this.Hide();
        }
    }
}
