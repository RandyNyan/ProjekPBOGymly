using Npgsql;
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
    public partial class Registrasi : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=putra23;Database=Project PBO Gymly";
        public Registrasi()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            // Tambahkan inisialisasi jika diperlukan
            MessageBox.Show("Form Register berhasil dimuat.");
        }

        private void button_exit_Click(object sender, EventArgs e)
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

        private void Button_Daftar_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Text; // Input username
            string password = textBox_Password.Text;        // Input password

            // Validasi input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan password harus diisi.");
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    // Periksa apakah username sudah ada
                    string checkUsernameQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
                    using (var checkUsernameCmd = new NpgsqlCommand(checkUsernameQuery, conn))
                    {
                        checkUsernameCmd.Parameters.AddWithValue("username", username);
                        int usernameCount = Convert.ToInt32(checkUsernameCmd.ExecuteScalar());
                        if (usernameCount > 0)
                        {
                            MessageBox.Show("Username sudah digunakan. Silakan gunakan username lain.");
                            return;
                        }
                    }

                    // Periksa apakah password sudah ada
                    string checkPasswordQuery = "SELECT COUNT(*) FROM users WHERE password = @password";
                    using (var checkPasswordCmd = new NpgsqlCommand(checkPasswordQuery, conn))
                    {
                        checkPasswordCmd.Parameters.AddWithValue("password", password);
                        int passwordCount = Convert.ToInt32(checkPasswordCmd.ExecuteScalar());
                        if (passwordCount > 0)
                        {
                            MessageBox.Show("Password sudah digunakan. Silakan gunakan password lain.");
                            return;
                        }
                    }

                    // Jika username dan password valid, tambahkan data
                    string insertQuery = "INSERT INTO users (username, password) VALUES (@username, @password)";
                    using (var insertCmd = new NpgsqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("username", username);
                        insertCmd.Parameters.AddWithValue("password", password);
                        insertCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Registrasi berhasil!");

                HomePage homepage = new HomePage();
                homepage.Show();
                this.Hide();
            }
            catch (Npgsql.PostgresException ex) when (ex.SqlState == "23505") // UNIQUE violation
            {
                MessageBox.Show("Username atau password sudah digunakan. Silakan gunakan data lain.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            login.Show();

            this.Hide();
        }
    }

}
