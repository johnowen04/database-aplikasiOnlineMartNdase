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
    public partial class FormKonsumenBarang : Form
    {
        private FormUtama formUtama;
        private List<Cabang> listCabang;

        public FormKonsumenBarang()
        {
            InitializeComponent();
        }

        private void FormatDataGrid()
        {
            dataGridViewBarang.Columns.Clear();

            dataGridViewBarang.Columns.Add("Nama", "Nama Barang");
            dataGridViewBarang.Columns.Add("Harga", "Harga Barang");
            dataGridViewBarang.Columns.Add("Kategori", "Kategori");
            dataGridViewBarang.Columns.Add("Stok", "Stok");
            dataGridViewBarang.Columns.Add("Cabang", "Cabang");

            DataGridViewButtonColumn buttonColumnKeranjang = new DataGridViewButtonColumn();
            buttonColumnKeranjang.HeaderText = "Aksi";
            buttonColumnKeranjang.Text = "+";
            buttonColumnKeranjang.Name = "btnKeranjangGrid";
            buttonColumnKeranjang.UseColumnTextForButtonValue = true;
            dataGridViewBarang.Columns.Add(buttonColumnKeranjang);

            dataGridViewBarang.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["Harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["Kategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["Stok"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["Cabang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewBarang.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewBarang.Columns["Harga"].DefaultCellStyle.Format = "#,###";

            dataGridViewBarang.Columns["Stok"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewBarang.Columns["Stok"].DefaultCellStyle.Format = "##";

            dataGridViewBarang.AllowUserToAddRows = false;
            dataGridViewBarang.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewBarang.Rows.Clear();

            if (listCabang.Count > 0)
            {
                foreach (Cabang c in listCabang)
                {
                    foreach (StokBarang sb in c.ListStokBarang)
                    {
                        dataGridViewBarang.Rows.Add(sb.Barang.Nama,
                        sb.Barang.Harga, sb.Barang.Kategori.Nama, sb.Stok, c.Nama);
                    }
                }
            }
            else
            {
                dataGridViewBarang.DataSource = null;
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormKonsumenBarang_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.MdiParent;
            FormatDataGrid();
            listCabang = Cabang.ReadData("", "");
            TampilDataGrid();
        }

        private void dataGridViewBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                string pNamaBarang = dataGridViewBarang.CurrentRow.Cells["nama"].Value.ToString();
                string pHargaBarang = dataGridViewBarang.CurrentRow.Cells["harga"].Value.ToString();
                string pKategoriBarang = dataGridViewBarang.CurrentRow.Cells["kategori"].Value.ToString();
                string pCabang = dataGridViewBarang.CurrentRow.Cells["cabang"].Value.ToString();

                if (e.ColumnIndex == dataGridViewBarang.Columns["btnKeranjangGrid"].Index && e.RowIndex >= 0)
                {
                    Cabang cabangDipilih = listCabang.Find(cabang => cabang.Nama == pCabang);
                    StokBarang stokBarangDipilih = cabangDipilih.ListStokBarang.Find(stokBarang => stokBarang.Barang.Nama == pNamaBarang);

                    if (formUtama.ko.ListKeranjangBarang.Find(kb => kb.Cabang.Nama == cabangDipilih.Nama && kb.Barang.Nama == stokBarangDipilih.Barang.Nama) != null)
                    {
                        formUtama.ko.ListKeranjangBarang.Find(kb => kb.Cabang.Nama == cabangDipilih.Nama && kb.Barang.Nama == stokBarangDipilih.Barang.Nama).Quantity += 1;
                        //MessageBox.Show("Quantity barang berhasil ditambahkan nama barang:"
                        //            + stokBarangDipilih.Barang.Nama
                        //            + "; qty:" + formUtama.ko.ListKeranjangBarang.Find(kb => kb.Cabang.Nama == cabangDipilih.Nama && kb.Barang.Nama == stokBarangDipilih.Barang.Nama).Quantity);
                    }
                    else
                    {
                        formUtama.ko.TambahBarangKeKeranjang(cabangDipilih, stokBarangDipilih.Barang, 1);
                        //MessageBox.Show("Barang dimasukkan ke keranjang nama barang:"
                        //            + stokBarangDipilih.Barang.Nama);
                    }

                    MessageBox.Show("Barang telah dimasukkan ke keranjang.", "Informasi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";

            switch (comboBoxCari.Text)
            {
                case "Nama Barang":
                    //kriteria = "b.nama";
                    break;
                case "Harga Barang":
                    //kriteria = "b.harga";
                    break;
                case "Nama Kategori":
                    //kriteria = "k.nama";
                    break;
                case "Nama Cabang":
                    kriteria = "c.nama";
                    break;
            }

            listCabang = Cabang.ReadData(kriteria, textBoxCari.Text);
            TampilDataGrid();
        }
    }
}
