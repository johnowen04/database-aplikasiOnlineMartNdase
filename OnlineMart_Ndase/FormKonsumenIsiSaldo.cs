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
    public partial class FormKonsumenIsiSaldo : Form
    {
        FormUtama formUtama;
        public FormKonsumenIsiSaldo()
        {
            InitializeComponent();
        }

        private void FormKonsumenIsiSaldo_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.MdiParent;
            labelSaldoSekarang.Text = formUtama.ko.Saldo.ToString();
        }

        private void buttonIsi_Click(object sender, EventArgs e)
        {
            try
            {
                RiwayatIsiSaldo ris = new RiwayatIsiSaldo(DateTime.Now, int.Parse(textBoxNominal.Text), formUtama.ko);

                Boolean hasil = RiwayatIsiSaldo.CreateData(ris);

                if (hasil)
                {
                    MessageBox.Show("Isi saldo berhasil.");
                    //formUtama.ko.Saldo += ris.Saldo;
                    Konsumen.UpdateSaldo(float.Parse(textBoxNominal.Text), formUtama.ko.Id);
                }
                else
                {
                    MessageBox.Show("Isi saldo gagal.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan. Pesan kesalahan: " + ex.Message, "Kesalahan");
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
