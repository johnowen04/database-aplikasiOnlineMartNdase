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
    public partial class FormPegawaiUbahPromo : Form
    {
        public FormPegawaiUbahPromo()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e) => this.Close();

        private void buttonBersihkan_Click(object sender, EventArgs e)
        {
            textBoxDiskon.Clear();
            textBoxMaksimalDiskon.Clear();
            textBoxMinimalPembelian.Clear();
            textBoxDiskon.Focus();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Promo p = new Promo(int.Parse(textBoxID.Text), textBoxTipe.Text, textBoxNama.Text, 
                    int.Parse(textBoxDiskon.Text), int.Parse(textBoxMaksimalDiskon.Text), 
                    float.Parse(textBoxMinimalPembelian.Text));

                Boolean hasil = Promo.UpdateData(p);

                if (hasil)
                {
                    MessageBox.Show("Berhasil mengubah data promo.", "Informasi");
                }
                else
                {
                    MessageBox.Show("Ubah data gagal.", "Kesalahan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data promo. \nPesan kesalahan : " + ex.Message, "Informasi");
            }
        }
    }
}
