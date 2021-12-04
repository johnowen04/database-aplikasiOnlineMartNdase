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
    public partial class FormPegawaiUbahMetodePembayaran : Form
    {
        public FormPegawaiUbahMetodePembayaran()
        {
            InitializeComponent();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                MetodePembayaran mp = new MetodePembayaran(int.Parse(textBoxID.Text), textBoxNama.Text);

                Boolean hasil = MetodePembayaran.UpdateData(mp);

                if (hasil)
                {
                    MessageBox.Show("Berhasil mengubah data metode pembayaran.", "Informasi");
                }
                else
                {
                    MessageBox.Show("Ubah data gagal.", "Kesalahan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data metode pembayaran. \nPesan kesalahan : " + ex.Message, "Informasi");
            }
        }

        private void buttonBersihkan_Click(object sender, EventArgs e)
        {
            textBoxNama.Clear();
            textBoxNama.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPegawaiUbahMetodePembayaran_Load(object sender, EventArgs e)
        {
            textBoxNama.Focus();
        }
    }
}
