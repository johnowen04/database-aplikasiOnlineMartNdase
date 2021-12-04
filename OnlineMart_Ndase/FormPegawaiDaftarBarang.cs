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
    public partial class FormPegawaiDaftarBarang : Form
    {
        public FormPegawaiDaftarBarang()
        {
            InitializeComponent();
        }

        public void FormPegawaiDaftarBarang_Load(object sender, EventArgs e)
        {
            // Select all data
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormPegawaiTambahBarang formPegawaiTambahBarang = new FormPegawaiTambahBarang();
            formPegawaiTambahBarang.Owner = this;
            formPegawaiTambahBarang.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
