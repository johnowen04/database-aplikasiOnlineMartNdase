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
        FormDaftar formDaftar;
        string email, username, password;

        public FormMasuk()
        {
            InitializeComponent();
        }

        private void FormMasuk_Load(object sender, EventArgs e)
        {
            radioButtonKonsumen.Checked = true;
            radioButtonKurir.Checked = false;
            radioButtonPegawai.Checked = false;
            panelKonsumen.Visible = true;
            panelKurirPegawai.Visible = false;
            panelKonsumen.Enabled = true;
            panelKurirPegawai.Enabled = false;
            textBoxEmailKonsumen.Focus();
        }

        private void radioButtonKonsumen_CheckedChanged(object sender, EventArgs e)
        {
            panelKonsumen.Visible = true;
            panelKonsumen.Enabled = true;
            panelKurirPegawai.Visible = false;
            panelKurirPegawai.Enabled = false;
            textBoxEmailKonsumen.Focus();
        }

        private void radioButtonKurir_CheckedChanged(object sender, EventArgs e)
        {
            panelKonsumen.Visible = false;
            panelKonsumen.Enabled = false;
            panelKurirPegawai.Visible = true;
            panelKurirPegawai.Enabled = true;
            textBoxUsernameKurirPegawai.Focus();
        }

        private void radioButtonPegawai_CheckedChanged(object sender, EventArgs e)
        {
            panelKonsumen.Visible = false;
            panelKonsumen.Enabled = false;
            panelKurirPegawai.Visible = true;
            panelKurirPegawai.Enabled = true;
            textBoxUsernameKurirPegawai.Focus();
        }

        private void buttonMasuk_Click(object sender, EventArgs e)
        {
            //if (radioButtonKonsumen.Checked)
            //{
            //    email = textBoxEmailKonsumen.Text;

            //    FormUtamaKonsumen formUtamaKonsumen = new FormUtamaKonsumen();
            //    formUtamaKonsumen.Owner = this;
            //    formUtamaKonsumen.ShowDialog();
            //}
            //else if (radioButtonKurir.Checked)
            //{
            //    FormUtamaKurir formUtamaKurir = new FormUtamaKurir();
            //    formUtamaKurir.Owner = this;
            //    formUtamaKurir.ShowDialog();
            //}

            //else
            //{
            //    FormUtamaPegawai formUtamaPegawai = new FormUtamaPegawai();
            //    formUtamaPegawai.Owner = this;
            //    formUtamaPegawai.ShowDialog();
            //}

        }

        private void linkLabelDaftar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDaftar formDaftar = new FormDaftar();
            formDaftar.Show();
            this.Hide();
        }
    }
}
