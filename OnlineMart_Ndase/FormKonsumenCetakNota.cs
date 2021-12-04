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
    public partial class FormKonsumenCetakNota : Form
    {
        public FormKonsumenCetakNota()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCetak_Click(object sender, EventArgs e)
        {
            try
            {
                //Order.CetakDaftarOrder(kriteria, nilai, "daftarnota.txt", new Font("Courier New", 10));

                MessageBox.Show("Nota berhasil dicetak terserah wes kata-katanya");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cetak Nota gagal MAKA E BELI PRINTER SENG MAHAL DASAR KISMIN. \nPesan kesalahan : " + ex.Message);
            }
        }
    }
}
