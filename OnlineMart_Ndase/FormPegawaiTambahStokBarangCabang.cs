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
    public partial class FormPegawaiTambahStokBarangCabang : Form
    {
        private FormPegawaiDaftarBarangCabang form;

        public FormPegawaiTambahStokBarangCabang()
        {
            InitializeComponent();
        }

        private void FormPegawaiTambahStokBarangCabang_Load(object sender, EventArgs e)
        {
            form = (FormPegawaiDaftarBarangCabang)this.Owner;
            textBoxTambahStok.Focus();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                int stok = int.Parse(textBoxTambahStok.Text);

                StokBarang sb = form.cabang.ListStokBarang.Find(stokBarang => stokBarang.Barang.Id.ToString() == textBoxID.Text);
                sb.Stok += stok;

                if (StokBarang.UpdateStok(sb))
                    MessageBox.Show("Stok barang " + sb.Barang.Nama + " berhasil ditambahkan.", "Informasi");
                else
                    MessageBox.Show("Terjadi kesalahan saat menambahkan stok.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan. Pesan kesalahan: " + ex.Message, "Kesalahan");
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e) => this.Close();

        private void buttonBersihkan_Click(object sender, EventArgs e)
        {
            textBoxTambahStok.Text = "";
            textBoxTambahStok.Focus();
        }
    }
}
