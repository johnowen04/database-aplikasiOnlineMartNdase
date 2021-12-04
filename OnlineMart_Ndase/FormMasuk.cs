﻿using System;
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
    public partial class FormMasuk : Form
    {
        FormUtama formUtama;

        public FormMasuk()
        {
            InitializeComponent();
        }

        public void FormMasuk_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.Owner;
        }

        private void radioButtonKonsumen_CheckedChanged(object sender, EventArgs e)
        {
            labelLoginInfo.Text = "Email :";
            textBoxPassword.MaxLength = 8;
            linkLabelDaftar.ForeColor = Color.OrangeRed;
            linkLabelDaftar.Enabled = true;
        }

        private void radioButtonKurir_CheckedChanged(object sender, EventArgs e)
        {
            labelLoginInfo.Text = "Username :";
            textBoxPassword.MaxLength = 0;
            linkLabelDaftar.ForeColor = Color.OrangeRed;
            linkLabelDaftar.Enabled = true;
        }

        private void radioButtonPegawai_CheckedChanged(object sender, EventArgs e)
        {
            labelLoginInfo.Text = "Email :";
            textBoxPassword.MaxLength = 0;
            linkLabelDaftar.ForeColor = Color.DarkGray;
            linkLabelDaftar.Enabled = false;
        }

        private void buttonMasuk_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi k = new Koneksi();

                string info = textBoxLoginInfo.Text;
                string password = textBoxPassword.Text;

                if (radioButtonKonsumen.Checked)
                {
                    Konsumen ko = Konsumen.CekLogin(info, password);

                    if (!(ko is null))
                    {
                        formUtama.ko = ko;
                        formUtama.pengguna = "ko";
                        MessageBox.Show("Koneksi Berhasil.", "Informasi");
                        //formUtama.menuStripKonsumen.Visible = true;

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Gagal masuk. Username atau Password yang dimasukkan salah.", "Informasi");
                    }
                }

                else if (radioButtonKurir.Checked)
                {
                    Kurir ku = Kurir.CekLogin(info, password);

                    if (!(ku is null))
                    {
                        formUtama.ku = ku;
                        formUtama.pengguna = "ku";
                        MessageBox.Show("Koneksi Berhasil.", "Informasi");
                        //formUtama.menuStripKurir.Visible = true;

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Gagal masuk. Username atau Password yang dimasukkan salah.", "Informasi");
                    }
                }

                else
                {
                    Pegawai p = Pegawai.CekLogin(info, password);

                    if (!(p is null))
                    {
                        formUtama.pe = p;
                        formUtama.pengguna = "pe";
                        MessageBox.Show("Koneksi Berhasil.", "Informasi");
                        //formUtama.menuStripPegawai.Visible = true;

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                    else
                    {
                        MessageBox.Show("Gagal masuk. Username atau Password yang dimasukkan salah.", "Informasi");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Gagal masuk. Pesan kesalahan: " + ex.Message, "Informasi");
            }
        }

        public void linkLabelDaftar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDaftar formDaftar = new FormDaftar();
            formDaftar.Owner = this;
            formDaftar.Show();
            //this.Hide();
        }
    }
}
