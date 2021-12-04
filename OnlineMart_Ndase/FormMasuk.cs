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
    public partial class FormMasuk : Form
    {
        public FormMasuk()
        {
            InitializeComponent();
        }

        public void FormMasuk_Load(object sender, EventArgs e)
        {
            this.Show();
        }

        private void radioButtonKonsumen_CheckedChanged(object sender, EventArgs e)
        {
            labelLoginInfo.Text = "Email :";
            textBoxPassword.MaxLength = 8;
        }

        private void radioButtonKurir_CheckedChanged(object sender, EventArgs e)
        {
            labelLoginInfo.Text = "Username :";
        }

        private void radioButtonPegawai_CheckedChanged(object sender, EventArgs e)
        {
            labelLoginInfo.Text = "Username :";
        }

        private void buttonMasuk_Click(object sender, EventArgs e)
        {
            try
            {
                FormUtama formUtama = (FormUtama)this.MdiParent;

                if (radioButtonKonsumen.Checked)
                {
                    // Konsumen
                    formUtama.menuStripKonsumen.Visible = true;
                }
                else if (radioButtonKurir.Checked)
                {
                    // Kurir
                    formUtama.menuStripKurir.Visible = true;
                }
                else
                {
                    // Pegawai
                    formUtama.menuStripPegawai.Visible = true;
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login gagal. Pesan error: " + ex.Message, "Info");
            }
        }

        private void linkLabelDaftar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDaftar formDaftar = new FormDaftar();
            formDaftar.Owner = this;
            formDaftar.Show();
            this.Hide();
        }
    }
}
