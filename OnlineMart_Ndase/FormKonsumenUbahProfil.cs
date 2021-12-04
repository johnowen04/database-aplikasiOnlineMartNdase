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
    public partial class FormKonsumenUbahProfil : Form
    {
        FormKonsumenProfil formKonsumenProfil;

        public FormKonsumenUbahProfil()
        {
            InitializeComponent();
        }

        private void FormKonsumenUbahProfil_Load(object sender, EventArgs e)
        {
            formKonsumenProfil = (FormKonsumenProfil)this.Owner;

            textBoxNama.Focus();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            string nama = textBoxNama.Text;
            string email = textBoxEmail.Text;
            string telepon = textBoxTelepon.Text;

            Konsumen konsumen = new Konsumen(formKonsumenProfil.listKonsumen[0].Id, nama, email,
                formKonsumenProfil.listKonsumen[0].Password, telepon, formKonsumenProfil.listKonsumen[0].Saldo,
                formKonsumenProfil.listKonsumen[0].Poin);

            Boolean hasilUpdate = Konsumen.UpdateData(konsumen);
            
            if (hasilUpdate)
            {
                formKonsumenProfil.formUtama.ko = konsumen;
                formKonsumenProfil.FormKonsumenProfil_Load(buttonUbah, e);

                MessageBox.Show("Data pengguna berhasil diubah.", "Informasi");
            }
            else
            {
                MessageBox.Show("Update data gagal.");
            }
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
            this.Close();
        }
    }
}
