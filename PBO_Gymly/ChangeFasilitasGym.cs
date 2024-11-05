using PBO_Gymly.CRUD;
using PBO_Gymly.StrukturData;
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
    public partial class ChangeFasilitasGym : Form
    {
        private int idFasilitas;
        private FasilitasGym parentForm;

        public ChangeFasilitasGym(int id, string nama, string jumlah, string fasilitasBaik, string fasilitasRusak, FasilitasGym parent)
        {
            InitializeComponent();
            this.idFasilitas = id;
            this.parentForm = parent;

            // Isi kontrol dengan data yang diterima
            TextBoxtNamaFasilitas.Text = nama;
            TextBoxtJumlahFasilitas.Text = jumlah;
            TextBoxtFasilitasBaik.Text = fasilitasBaik;
            TextBoxtFasilitasRusak.Text = fasilitasRusak;
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            try
            {
                // Ambil nilai dari TextBox
                string namaFasilitas = TextBoxtNamaFasilitas.Text;
                string jumlahFasilitas = TextBoxtJumlahFasilitas.Text;
                string fasilitasBaik = TextBoxtFasilitasBaik.Text;
                string fasilitasRusak = TextBoxtFasilitasRusak.Text;

                // Membuat objek Struktur_FasilitasGym dengan data yang dimasukkan
                Struktur_FasilitasGym fasilitas = new Struktur_FasilitasGym
                {
                    id_fasilitas_gym = idFasilitas, // ID fasilitas yang dipilih
                    nama_fasilitas = namaFasilitas,
                    jumlah_fasilitas = int.Parse(jumlahFasilitas),
                    fasilitas_baik = int.Parse(fasilitasBaik),
                    fasilitas_rusak = int.Parse(fasilitasRusak)
                };

                // Panggil fungsi UpdateFasilitas untuk memperbarui data fasilitas
                BagianFasilitasGym.UpdateFasilitas(fasilitas);

                // Update DataGridView di form utama
                parentForm.LoadDataFasilitasGym();

                // Menampilkan pesan sukses
                MessageBox.Show("Fasilitas berhasil diperbarui.");

                // Tutup form setelah perubahan berhasil
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            // Menutup form jika pengguna membatalkan perubahan
            this.Close();
        }
    }

}
