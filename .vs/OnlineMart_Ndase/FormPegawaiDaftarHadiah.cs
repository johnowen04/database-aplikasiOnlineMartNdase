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
    public partial class FormPegawaiDaftarHadiah : Form
    {
        public FormPegawaiDaftarHadiah()
        {
            InitializeComponent();
        }

        public void FormPegawaiDaftarHadiah_Load(object sender, EventArgs e)
        {
            // Select Data from DB
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormPegawaiTambahHadiah formPegawaiTambahHadiah = new FormPegawaiTambahHadiah();
            formPegawaiTambahHadiah.Owner = this;
            formPegawaiTambahHadiah.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
