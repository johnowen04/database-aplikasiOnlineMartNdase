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
    public partial class FormPegawaiTambahKategori : Form
    {
        public FormPegawaiTambahKategori()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori k = new Kategori(int.Parse(textBoxID.Text), textBoxNama.Text);

                Kategori.CreateData(k);

                MessageBox.Show("Data Kategori telah tersimpan");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan Kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void buttonBersihkan_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxNama.Clear();
            textBoxID.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormPegawaiDaftarKategori form = (FormPegawaiDaftarKategori)this.Owner;
            form.FormPegawaiDaftarKategori_Load(sender, e);

            this.Close();
        }
    }
}
