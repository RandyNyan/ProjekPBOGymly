using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using PBO_Gymly.DataBase;
using static System.Windows.Forms.DataFormats;

namespace PBO_Gymly
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Text;
            string password = TextBoxPassword.Text;

            // Validasi untuk memastikan input tidak kosong
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Data salah, isi kembali!");
                return; // Menghentikan eksekusi jika input kosong
            }
            string role = GetUserRole(username, password);

            if (role == "admin")
            {
                HomePage homepage = new HomePage();

                homepage.Show();

                this.Hide();
            }
            else if (role == "customer")
            {
                HomepageCustomer customerpage = new HomepageCustomer();
                
                customerpage.Show();
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau password salah, isi kembali!");
            }
        }
        private string GetUserRole(string username, string password)
        {
            string queryAdmin = "SELECT COUNT(*) FROM Akun_admin WHERE Nama_admin = @Username AND Password_admin = @Password";
            string queryCustomer = "SELECT COUNT(*) FROM Akun_customer WHERE Nama_customer = @Username AND Password_customer = @Password";

            NpgsqlParameter[] parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@Username", username),
                new NpgsqlParameter("@Password", password)
            };

            try
            {
                // Cek di tabel admin
                DataTable adminResult = Database_FasilitasGym.queryExecutor(queryAdmin, parameters);
                int adminCount = Convert.ToInt32(adminResult.Rows[0][0]);

                if (adminCount > 0)
                {
                    return "admin";
                }

                // Cek di tabel customer
                DataTable customerResult = Database_FasilitasGym.queryExecutor(queryCustomer, parameters);
                int customerCount = Convert.ToInt32(customerResult.Rows[0][0]);

                if (customerCount > 0)
                {
                    return "customer";
                }

                // Jika tidak ditemukan di kedua tabel
                return string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return string.Empty;
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void Button_Regist_Click(object sender, EventArgs e)
        {
            Registrasi registrasi = new Registrasi();

            registrasi.Show();

            this.Hide();
        }
    }
}
