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
        public string noOrder = "";

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
                Order.CetakDaftarOrder("o.id", noOrder, "daftarnota.txt", new Font("Courier New", 10));

                MessageBox.Show("Nota berhasil dicetak.");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Cetak Nota gagal. \nPesan kesalahan : " + ex.Message);
            }
        }

        private void FormKonsumenCetakNota_Load(object sender, EventArgs e)
        {
            labelNoOrder.Text = noOrder;
        }
    }
}
