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
    public partial class FormPegawaiDaftarMetodePembayaran : Form
    {
        public FormPegawaiDaftarMetodePembayaran()
        {
            InitializeComponent();
        }

        public void FormPegawaiDaftarMetodePembayaran_Load(object sender, EventArgs e)
        {
            // Select data from DB
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormPegawaiTambahMetodePembayaran formPegawaiTambahMetodePembayaran = new FormPegawaiTambahMetodePembayaran();
            formPegawaiTambahMetodePembayaran.Owner = this;
            formPegawaiTambahMetodePembayaran.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
