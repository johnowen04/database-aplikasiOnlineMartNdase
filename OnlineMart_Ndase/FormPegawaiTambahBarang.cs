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
    public partial class FormPegawaiTambahBarang : Form
    {
        public FormPegawaiTambahBarang()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            // Add Data to DB
        }

        private void buttonBersihkan_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
            textBoxHarga.Text = "";
            comboBoxKategori.Text = "";
            comboBoxCabang.Text = "";
            textBoxNama.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormPegawaiDaftarBarang form = (FormPegawaiDaftarBarang)this.Owner;
            form.FormPegawaiDaftarBarang_Load(sender, e);

            this.Close();
        }
    }
}
