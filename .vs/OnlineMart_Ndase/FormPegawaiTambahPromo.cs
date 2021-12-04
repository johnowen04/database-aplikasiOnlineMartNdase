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
    public partial class FormPegawaiTambahPromo : Form
    {
        public FormPegawaiTambahPromo()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            // Add data to DB
        }

        private void buttonBersihkan_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
            textBoxTipe.Text = "";
            textBoxDiskon.Text = "";
            textBoxMaksimalDiskon.Text = "";
            textBoxMinimalPembelian.Text = "";
            textBoxNama.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormPegawaiDaftarPromo form = (FormPegawaiDaftarPromo)this.Owner;
            form.FormPegawaiDaftarPromo_Load(sender, e);

            this.Close();
        }
    }
}
