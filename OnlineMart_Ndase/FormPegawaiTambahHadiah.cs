using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineMart_LIB;

namespace OnlineMart_Ndase
{
    public partial class FormPegawaiTambahHadiah : Form
    {
        public FormPegawaiTambahHadiah()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Hadiah h = new Hadiah(int.Parse(textBoxID.Text), textBoxNama.Text, int.Parse(textBoxJumlahPoin.Text));

                Boolean hasil = Hadiah.CreateData(h);

                if (hasil)
                    MessageBox.Show("Data Hadiah telah tersimpan", "Informasi");
                else
                    MessageBox.Show("Penyimpanan data gagal.", "Informasi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan. Pesan kesalahan: " + ex.Message, "Kesalahan");
            }
        }

        private void buttonBersihkan_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxNama.Text = "";
            textBoxJumlahPoin.Text = "";
            textBoxID.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormPegawaiDaftarHadiah form = (FormPegawaiDaftarHadiah)this.Owner;
            form.FormPegawaiDaftarHadiah_Load(sender, e);

            this.Close();
        }
    }
}
