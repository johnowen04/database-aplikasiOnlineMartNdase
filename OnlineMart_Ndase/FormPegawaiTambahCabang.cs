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
    public partial class FormPegawaiTambahCabang : Form
    {
        public FormPegawaiTambahCabang()
        {
            InitializeComponent();
        }

        private void buttonBuat_Click(object sender, EventArgs e)
        {
            // Add Data to DB
        }

        private void buttonBersihkan_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxNama.Text = "";
            textBoxAlamat.Text = "";
            textBoxIdPegawai.Text = "";
            textBoxID.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormPegawaiDaftarCabang form = (FormPegawaiDaftarCabang)this.Owner;
            form.FormPegawaiDaftarCabang_Load(sender, e);

            this.Close();
        }
    }
}
