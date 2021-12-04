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
    public partial class FormKonsumenProfil : Form
    {
        public FormUtama formUtama;
        public List<Konsumen> listKonsumen;

        public FormKonsumenProfil()
        {
            InitializeComponent();
        }

        public void FormKonsumenProfil_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.MdiParent;
            listKonsumen = Konsumen.ReadData("email", formUtama.ko.Email);

            if (listKonsumen.Count == 1)
            {
                labelNama.Text = ": " + listKonsumen[0].Nama;
                labelEmail.Text = ": " + listKonsumen[0].Email;
                labelTelepon.Text = ": " + listKonsumen[0].Telepon;
                labelOmaSaldo.Text = ": " + "Rp" + listKonsumen[0].Saldo.ToString("####");
                labelPoint.Text = ": " + listKonsumen[0].Poin + " poin" ;
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormKonsumenUbahProfil formKonsumenUbahProfil = new FormKonsumenUbahProfil();
            formKonsumenUbahProfil.Owner = this;
            formKonsumenUbahProfil.textBoxNama.Text = listKonsumen[0].Nama;
            formKonsumenUbahProfil.textBoxEmail.Text = listKonsumen[0].Email;
            formKonsumenUbahProfil.textBoxTelepon.Text = listKonsumen[0].Telepon;
            formKonsumenUbahProfil.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
