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
    public partial class FormDaftar : Form
    {
        FormMasuk formMasuk;

        public FormDaftar()
        {
            InitializeComponent();
        }

        private void FormDaftar_Load(object sender, EventArgs e)
        {
            formMasuk = (FormMasuk)this.Owner;
        }

        private void linkLabelMasuk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formMasuk.FormMasuk_Load(linkLabelMasuk, e);
            this.Close();
        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            formMasuk.FormMasuk_Load(linkLabelMasuk, e);
            this.Close();
        }
    }
}
