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
    public partial class FormPegawaiUbahHadiah : Form
    {
        public FormPegawaiUbahHadiah()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e) => this.Close();

        private void buttonBersihkan_Click(object sender, EventArgs e)
        {
            textBoxNama.Clear();
            textBoxJumlahPoin.Clear();
            textBoxNama.Focus();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Hadiah h = new Hadiah(int.Parse(textBoxID.Text), textBoxNama.Text,
                    int.Parse(textBoxJumlahPoin.Text));

                Boolean hasil = Hadiah.UpdateData(h);

                if (hasil)
                {
                    MessageBox.Show("Berhasil mengubah data hadiah.", "Informasi");
                }
                else
                {
                    MessageBox.Show("Ubah data gagal.", "Kesalahan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data hadiah. \nPesan kesalahan : " + ex.Message, "Informasi");
            }
        }
    }
}
