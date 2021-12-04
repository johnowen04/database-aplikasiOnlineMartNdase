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
    public partial class FormPegawaiUbahCabang : Form
    {
        public FormPegawaiUbahCabang()
        {
            InitializeComponent();
        }

        private void FormPegawaiUbahCabang_Load(object sender, EventArgs e)
        {
            textBoxID.Enabled = false;
            // Select data from DB
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            // Add data to DB
        }

        private void buttonBersihkan_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
            textBoxAlamat.Text = "";
            textBoxIdPegawai.Text = "";
            textBoxNama.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            // Need more implementation
            this.Close();
        }
    }
}
