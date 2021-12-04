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
    public partial class FormPegawaiDaftarBarangCabang : Form
    {
        public Cabang cabang;

        public FormPegawaiDaftarBarangCabang()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormPegawaiTambahBarangCabang form = new FormPegawaiTambahBarangCabang();
            form.Owner = this;
            form.comboBoxBarang.Items.Clear();
            List<Barang> listBarang = Barang.ReadData();
            form.comboBoxBarang.DataSource = listBarang;
            form.comboBoxBarang.DisplayMember = "Nama";
            form.ShowDialog();
            RefreshData();
            FormPegawaiDaftarBarangCabang_Load(sender, e);
        }

        private void FormatDataGrid()
        {
            dataGridViewDaftarBarangCabang.Columns.Clear();

            dataGridViewDaftarBarangCabang.Columns.Add("Id", "Id Barang");
            dataGridViewDaftarBarangCabang.Columns.Add("Nama", "Nama Barang");
            dataGridViewDaftarBarangCabang.Columns.Add("Harga", "Harga Barang");
            dataGridViewDaftarBarangCabang.Columns.Add("Kategori", "Kategori");
            dataGridViewDaftarBarangCabang.Columns.Add("Stok", "Stok");

            DataGridViewButtonColumn buttonColumnTambahStok = new DataGridViewButtonColumn();
            buttonColumnTambahStok.HeaderText = "Aksi";
            buttonColumnTambahStok.Text = "+";
            buttonColumnTambahStok.Name = "btnTambahStokGrid";
            buttonColumnTambahStok.UseColumnTextForButtonValue = true;
            dataGridViewDaftarBarangCabang.Columns.Add(buttonColumnTambahStok);

            dataGridViewDaftarBarangCabang.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarBarangCabang.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarBarangCabang.Columns["Harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarBarangCabang.Columns["Kategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarBarangCabang.Columns["Stok"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewDaftarBarangCabang.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewDaftarBarangCabang.Columns["Harga"].DefaultCellStyle.Format = "#,###";

            dataGridViewDaftarBarangCabang.Columns["Stok"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewDaftarBarangCabang.Columns["Stok"].DefaultCellStyle.Format = "##";

            dataGridViewDaftarBarangCabang.AllowUserToAddRows = false;
            dataGridViewDaftarBarangCabang.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewDaftarBarangCabang.Rows.Clear();

            if (cabang.ListStokBarang.Count > 0)
            {
                foreach (StokBarang sb in cabang.ListStokBarang)
                {
                    dataGridViewDaftarBarangCabang.Rows.Add(sb.Barang.Id, sb.Barang.Nama,
                        sb.Barang.Harga, sb.Barang.Kategori.Nama, sb.Stok);
                }
            }
            else
            {
                dataGridViewDaftarBarangCabang.DataSource = null;
            }
        }

        private void dataGridViewDaftarBarangCabang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string bId = dataGridViewDaftarBarangCabang.CurrentRow.Cells["id"].Value.ToString();
            string bNama = dataGridViewDaftarBarangCabang.CurrentRow.Cells["nama"].Value.ToString();
            string bHarga = dataGridViewDaftarBarangCabang.CurrentRow.Cells["harga"].Value.ToString();
            string bNamaKategori = dataGridViewDaftarBarangCabang.CurrentRow.Cells["kategori"].Value.ToString();
            string bStok = dataGridViewDaftarBarangCabang.CurrentRow.Cells["stok"].Value.ToString();

            if (e.ColumnIndex == dataGridViewDaftarBarangCabang.Columns["btnTambahStokGrid"].Index && e.RowIndex >= 0)
            {
                FormPegawaiTambahStokBarangCabang form = new FormPegawaiTambahStokBarangCabang();
                form.Owner = this;
                form.textBoxID.Text = bId;
                form.textBoxNama.Text = bNama;
                form.textBoxHarga.Text = bHarga;
                form.comboBoxKategori.DataSource = Kategori.ReadData("", "");
                form.comboBoxKategori.DisplayMember = "Nama";
                form.comboBoxKategori.SelectedIndex = form.comboBoxKategori.FindString(bNamaKategori);
                form.textBoxStok.Text = bStok;
                form.ShowDialog();
                RefreshData();
                FormPegawaiDaftarBarangCabang_Load(sender, e);
            }
        }

        private void FormPegawaiDaftarBarangCabang_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            TampilDataGrid();
        }

        private void buttonKeluar_Click(object sender, EventArgs e) => this.Close();

        private void RefreshData()
        {
            List<Cabang> refreshCabang = Cabang.ReadData("c.id", cabang.Id.ToString());
            cabang = refreshCabang.Count == 1 ? refreshCabang[0] : cabang;
        }
    }
}
