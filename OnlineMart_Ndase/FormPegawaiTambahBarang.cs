using OnlineMart_LIB;
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
    public partial class FormPegawaiTambahBarang : Form
    {
        public List<Kategori> listKategori = new List<Kategori>();
        public List<Cabang> listCabang = new List<Cabang>();

        public FormPegawaiTambahBarang()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Kategori kategoriDipilih = (Kategori)comboBoxKategori.SelectedItem;
                Barang b = new Barang(int.Parse(textBoxID.Text), textBoxNama.Text, textBoxHarga.Text, kategoriDipilih);

                Barang.CreateData(b);

                MessageBox.Show("Data Barang telah tersimpan", "Informasi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. \nPesan Kesalahan : " + ex.Message, "Informasi");
            }
        }

        private void buttonBersihkan_Click(object sender, EventArgs e)
        {
            textBoxNama.Clear();
            textBoxHarga.Clear();
            comboBoxKategori.Text = "";
            comboBoxCabang.Text = "";
            textBoxNama.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormPegawaiDaftarBarang form = (FormPegawaiDaftarBarang)this.Owner;
            form.FormPegawaiDaftarBarang_Load(sender, e);

            this.Close();
        }

        private void FormPegawaiTambahBarang_Load(object sender, EventArgs e)
        {
            listKategori = Kategori.ReadData("", "");
            listCabang = Cabang.ReadData("", "");

            comboBoxKategori.DataSource = listKategori;
            comboBoxKategori.DisplayMember = "nama";

            comboBoxCabang.DataSource = listCabang;
            comboBoxCabang.DisplayMember = "nama";
        }
    }
}
