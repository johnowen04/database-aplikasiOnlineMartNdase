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
    public partial class FormPegawaiTambahPromo : Form
    {
        public FormPegawaiTambahPromo()
        {
            InitializeComponent();
        }

        private void FormPegawaiTambahPromo_Load(object sender, EventArgs e)
        {

        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Promo p = new Promo(int.Parse(textBoxID.Text), textBoxTipe.Text, textBoxNama.Text, int.Parse(textBoxDiskon.Text), int.Parse(textBoxMaksimalDiskon.Text), float.Parse(textBoxMinimalPembelian.Text));

                Boolean hasil = Promo.CreateData(p);

                if (hasil)
                    MessageBox.Show("Data Promo telah tersimpan", "Informasi");
                else
                    MessageBox.Show("Penyimpanan data gagal.", "Informasi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan. Pesan kesalahan: " + ex.Message, "Kesalahan");
            }
        }

        private void buttonBersihkan_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
            textBoxTipe.Text = "";
            textBoxDiskon.Text = "";
            textBoxMaksimalDiskon.Text = "";
            textBoxMinimalPembelian.Text = "";
            textBoxNama.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormPegawaiDaftarPromo form = (FormPegawaiDaftarPromo)this.Owner;
            form.FormPegawaiDaftarPromo_Load(sender, e);

            this.Close();
        }
    }
}
