using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // Add data to DB
        }

        private void buttonBersihkan_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxNama.Text = "";
            textBoxID.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormPegawaiDaftarMetodePembayaran form = (FormPegawaiDaftarMetodePembayaran)this.Owner;
            form.FormPegawaiDaftarMetodePembayaran_Load(sender, e);

            this.Close();
        }
    }
}
