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
    public partial class FormPegawaiTambahHadiah : Form
    {
        public FormPegawaiTambahHadiah()
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
            textBoxJumlahPoin.Text = "";
            textBoxID.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormPegawaiDaftarHadiah form = (FormPegawaiDaftarHadiah)this.Owner;
            form.FormPegawaiDaftarHadiah_Load(sender, e);

            this.Close();
        }
    }
}
