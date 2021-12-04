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
    public partial class FormKonsumenUbahProfil : Form
    {
        public FormKonsumenUbahProfil()
        {
            InitializeComponent();
        }

        private void FormKonsumenUbahProfil_Load(object sender, EventArgs e)
        {

        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {

        }

        private void buttonBersihkan_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
            textBoxEmail.Text = "";
            textBoxTelepon.Text = "";
            textBoxNama.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormKonsumenProfil formKonsumenProfil = (FormKonsumenProfil)this.Owner;
            formKonsumenProfil.FormKonsumenProfil_Load(sender, e);
            
            this.Close();
        }
    }
}
