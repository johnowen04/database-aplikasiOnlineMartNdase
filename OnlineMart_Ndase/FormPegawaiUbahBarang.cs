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
    public partial class FormPegawaiUbahBarang : Form
    {
        public FormPegawaiUbahBarang()
        {
            InitializeComponent();
        }

        private void FormPegawaiUbahBarang_Load(object sender, EventArgs e)
        {
            textBoxId.Enabled = false;
            textBoxNama.Enabled = false;

            List<Kategori> listKategori = Kategori.ReadData("", "");
            comboBoxKategori.DataSource = listKategori;
            comboBoxKategori.DisplayMember = "Nama";

            List<Cabang> listCabang = Cabang.ReadData("", "");
            comboBoxCabang.DataSource = listCabang;
            comboBoxCabang.DisplayMember = "Nama";

            List<Barang> listBarang = Barang.ReadData("b.id", textBoxId.Text);
            Kategori k;

            if (listBarang.Count > 0)
                k = listBarang[0].Kategori;
            else
                throw new ArgumentException("Barang tidak ditemukan.");

            int idx = 0;
            foreach (Kategori kategori in listKategori)
            {
                if (kategori.Id == k.Id)
                {
                    idx = listKategori.IndexOf(kategori);
                }
            }

            comboBoxKategori.SelectedIndex = idx;
        }

        private void buttonBersihkan_Click(object sender, EventArgs e)
        {
            textBoxNama.Clear();
            textBoxHarga.Clear();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori k = (Kategori)comboBoxKategori.SelectedItem;
                Barang b = new Barang(int.Parse(textBoxId.Text), textBoxNama.Text, textBoxHarga.Text, k);

                Boolean hasil = Barang.UpdateData(b);

                if (hasil)
                {
                    MessageBox.Show("Berhasil mengubah data Barang.", "Informasi");
                }
                else
                {
                    MessageBox.Show("Ubah data gagal.", "Kesalahan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data Barang. \nPesan kesalahan : " + ex.Message, "Informasi");
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormPegawaiDaftarBarang form = (FormPegawaiDaftarBarang)this.Owner;
            form.FormPegawaiDaftarBarang_Load(sender, e);

            this.Close();
        }
    }
}
