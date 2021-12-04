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
    public partial class FormPegawaiUbahKategori : Form
    {
        public FormPegawaiUbahKategori()
        {
            InitializeComponent();
        }

        private void FormPegawaiUbahKategori_Load(object sender, EventArgs e)
        {
            textBoxID.Enabled = false;
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori k = new Kategori(int.Parse(textBoxID.Text), textBoxNama.Text);

                Boolean hasil = Kategori.UpdateData(k);

                if (hasil)
                {
                    MessageBox.Show("Berhasil mengubah data kategori.", "Informasi");
                }
                else
                {
                    MessageBox.Show("Ubah data gagal.", "Kesalahan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data kategori. \nPesan kesalahan : " + ex.Message, "Informasi");
            }
        }

        private void buttonBersihkan_Click(object sender, EventArgs e)
        {
            textBoxNama.Clear();
            textBoxNama.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormPegawaiDaftarKategori formDaftarKategori = (FormPegawaiDaftarKategori)this.Owner;
            formDaftarKategori.FormPegawaiDaftarKategori_Load(sender, e);

            this.Close();
        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelUbahKategori_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
