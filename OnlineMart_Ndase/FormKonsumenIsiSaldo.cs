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
            labelSaldoSekarang.Text = "Rp" + formUtama.ko.Saldo.ToString("#,###");
        }

        private void buttonIsi_Click(object sender, EventArgs e)
        {
            try
            {
                float nominal = float.Parse(textBoxNominal.Text);

                Konsumen.UpdateSaldo("isi saldo", formUtama.ko.Id, nominal);
                formUtama.ko.Saldo += nominal;
                MessageBox.Show("Isi saldo berhasil.", "Informasi");

                FormKonsumenIsiSaldo_Load(sender, e);
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
