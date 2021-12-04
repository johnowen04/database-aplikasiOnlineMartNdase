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
        public FormDaftar()
        {
            InitializeComponent();
        }

        private void FormDaftar_Load(object sender, EventArgs e)
        {
            
        }

        private void linkLabelMasuk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormMasuk form = (FormMasuk)this.Owner;
            form.FormMasuk_Load(linkLabelMasuk, e);

            this.Close();
        }
    }
}
