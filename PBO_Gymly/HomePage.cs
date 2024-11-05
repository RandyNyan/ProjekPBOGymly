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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void ButtonFasilitasGym_Click(object sender, EventArgs e)
        {
            FasilitasGym fasilitas_gym = new FasilitasGym();

            fasilitas_gym.Show();

            this.Hide();
        }

        private void ButtonLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            login.Show();

            this.Hide();
        }
    }
}
