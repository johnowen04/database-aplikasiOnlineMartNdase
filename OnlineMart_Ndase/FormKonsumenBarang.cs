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
        private List<CabangBarang> listCabangBarang = new List<CabangBarang>();

        private FormUtama formUtama;

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
            dataGridViewBarang.Columns["Cabang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewBarang.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewBarang.Columns["Harga"].DefaultCellStyle.Format = "#,###";

            dataGridViewBarang.AllowUserToAddRows = false;
            dataGridViewBarang.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewBarang.Rows.Clear();

            if (listCabangBarang.Count > 0)
            {
                foreach (CabangBarang cb in listCabangBarang)
                {
                    dataGridViewBarang.Rows.Add(cb.Barang.Nama, cb.Barang.Harga, 
                        cb.Barang.Kategori.Nama, cb.Cabang.Nama);
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
            listCabangBarang = CabangBarang.ReadData("", "");
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
                    List<Barang> barangDipilih = Barang.ReadData("b.nama", pNamaBarang);
                    List<Cabang> cabangBarangDipilih = Cabang.ReadData("c.nama", pCabang);

                    if (barangDipilih.Count > 0 && cabangBarangDipilih.Count > 0)
                    { 
                        CabangBarang barangMasukKeranjang = new CabangBarang(barangDipilih[0], cabangBarangDipilih[0], 1);

                        List<CabangBarang> stokBarang = CabangBarang.ReadData("b.id", barangMasukKeranjang.Barang.Id.ToString());

                        if (stokBarang.Count > 0)
                        {
                            if (stokBarang[0].Stok > 0)
                            {
                                formUtama.keranjang.Add(barangMasukKeranjang);
                                MessageBox.Show("Barang dimasukkan ke keranjang nama barang:"
                                    + barangMasukKeranjang.Barang.Nama);
                            }
                            else
                            {
                                MessageBox.Show("Stok barang tidak tersedia.", "Informasi");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Barang tidak tersedia di cabang manapun.", "Informasi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Barang tidak ditemukan.", "Informasi");
                    }
                }
                else
                {
                
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
                    kriteria = "b.nama";
                    break;
                case "Harga Barang":
                    kriteria = "b.harga";
                    break;
                case "Nama Kategori":
                    kriteria = "k.nama";
                    break;
                case "Nama Cabang":
                    kriteria = "c.nama";
                    break;
            }
        }
    }
}
