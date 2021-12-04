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
    public partial class FormPegawaiUbahKategori : Form
    {
        public FormPegawaiUbahKategori()
        {
            InitializeComponent();
        }

        private void FormPegawaiUbahKategori_Load(object sender, EventArgs e)
        {
            textBoxID.Enabled = false;
            // Select data from DB
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            // Add data from DB
        }

        private void buttonBersihkan_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
            textBoxNama.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            // Need more implementation
            this.Close();
        }
    }
}
