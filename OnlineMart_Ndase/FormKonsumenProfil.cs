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
    public partial class FormKonsumenProfil : Form
    {
        public FormKonsumenProfil()
        {
            InitializeComponent();
        }

        public void FormKonsumenProfil_Load(object sender, EventArgs e)
        {
            // Select data from DB
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormKonsumenUbahProfil formKonsumenUbahProfil = new FormKonsumenUbahProfil();
            formKonsumenUbahProfil.Owner = this;
            formKonsumenUbahProfil.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
