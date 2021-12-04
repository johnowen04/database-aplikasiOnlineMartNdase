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
    public partial class FormPegawaiTambahBarangCabang : Form
    {
        private FormPegawaiDaftarBarangCabang formPegawaiDaftarBarangCabang;

        public FormPegawaiTambahBarangCabang()
        {
            InitializeComponent();
        }

        private void FormPegawaiTambahBarangCabang_Load(object sender, EventArgs e)
        {
            formPegawaiDaftarBarangCabang = (FormPegawaiDaftarBarangCabang)this.Owner;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Barang selectedBarang = (Barang)comboBoxBarang.SelectedItem;
                int stok = int.Parse(textBoxStok.Text);

                StokBarang stokBarang = new StokBarang(formPegawaiDaftarBarangCabang.cabang, selectedBarang, stok);

                if (!StokBarang.CheckDuplicate(stokBarang))
                {
                    if (StokBarang.CreateStok(stokBarang))
                        MessageBox.Show("Tambah barang " + selectedBarang.Nama + " di cabang " + formPegawaiDaftarBarangCabang.cabang.Nama + " berhasil.", "Informasi");
                    else
                        MessageBox.Show("Tambah barang gagal.", "Kesalahan");
                }
                else
                {
                    MessageBox.Show("Barang sudah ada.", "Kesalahan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan. Pesan kesalahan: " + ex.Message, "Kesalahan");
            }
        }

        private void comboBoxBarang_SelectedValueChanged(object sender, EventArgs e)
        {
            Barang selectedBarang = (Barang)comboBoxBarang.SelectedItem;
            textBoxHarga.Text = selectedBarang.Harga;
        }

        private void buttonBersihkan_Click(object sender, EventArgs e)
        {
            comboBoxBarang.Text = "";
            textBoxHarga.Text = "";
            textBoxStok.Text = "";
        }

        private void buttonKeluar_Click(object sender, EventArgs e) => this.Close();

    }
}
