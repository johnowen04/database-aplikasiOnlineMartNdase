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
    public partial class FormPegawaiTambahMetodePembayaran : Form
    {
        public FormPegawaiTambahMetodePembayaran()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                MetodePembayaran mp = new MetodePembayaran(textBoxNama.Text);

                MetodePembayaran.CreateData(mp);

                MessageBox.Show("Data metode pembayaran telah tersimpan");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan Kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void buttonBersihkan_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
            textBoxNama.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormPegawaiDaftarMetodePembayaran form = (FormPegawaiDaftarMetodePembayaran)this.Owner;
            form.FormPegawaiDaftarMetodePembayaran_Load(sender, e);

            this.Close();
        }

        private void FormPegawaiTambahMetodePembayaran_Load(object sender, EventArgs e)
        {

        }
    }
}
