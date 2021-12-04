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
    public partial class FormKonsumenCheckout : Form
    {
        public FormKonsumenCheckout()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabelKodePromo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormKonsumenKodePromo formKonsumenKodePromo = new FormKonsumenKodePromo();
            formKonsumenKodePromo.Owner = this;
            formKonsumenKodePromo.ShowDialog();
        }

        private void FormKonsumenCheckout_Load(object sender, EventArgs e)
        {
            labelKodePromo.Visible = false;
            labelKodePromo.Enabled = false;

            buttonBayar.Enabled = false;
        }
    }
}
