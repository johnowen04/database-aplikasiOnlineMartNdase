using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineMart_LIB;

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
            try
            {
                Koneksi k = new Koneksi();

                if(radioButtonKonsumen.Checked)
                {
                    if (textBoxKataSandiKonsumen.Text != textBoxUlangKataSandi.Text)
                    {
                        MessageBox.Show("Kata sandi tidak sama", "Informasi");
                    }

                    else
                    {
                        if (checkBoxDaftar.Checked)
                        {
                            Konsumen ko = new Konsumen(textBoxNamaKonsumen.Text, textBoxEmailKonsumen.Text, 
                                textBoxKataSandiKonsumen.Text, textBoxTelepon.Text, 0, 0);

                            Konsumen.CreateData(ko);

                            MessageBox.Show("Selamat anda berhasil mendaftar!", "Selamat datang di OMA");

                            formMasuk.FormMasuk_Load(linkLabelMasuk, e);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Anda perlu menyetujui Syarat dan Ketentuan dan Kebijakan Privasi OMA", "Informasi");
                        }
                    }
                }

                else if (radioButtonKurir.Checked)
                {
                    if (textBoxKurirKataSandi.Text != textBoxKurirUlangKataSandi.Text)
                    {
                        MessageBox.Show("Kata sandi tidak sama", "Informasi");
                    }

                    else
                    {
                        if (checkBoxDaftar.Checked)
                        {
                            Kurir ku = new Kurir(textBoxKurirNama.Text, textBoxKurirEmail.Text, textBoxUsername.Text,
                                textBoxKurirKataSandi.Text, textBoxKurirTelepon.Text);

                            Kurir.CreateData(ku);

                            MessageBox.Show("Selamat anda berhasil mendaftar!", "Selamat datang di OMA");

                            formMasuk.FormMasuk_Load(linkLabelMasuk, e);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Anda perlu menyetujui Syarat dan Ketentuan dan Kebijakan Privasi OMA", "Informasi");
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan. \nPesan kesalahan : " + ex.Message, "Informasi");
            }
        }

        private void radioButtonKonsumen_CheckedChanged(object sender, EventArgs e)
        {
            panelKonsumen.Visible = true;
            panelKurir.Visible = false;
        }

        private void radioButtonKurir_CheckedChanged(object sender, EventArgs e)
        {
            panelKonsumen.Visible = false;
            panelKurir.Visible = true;
        }
    }
}
