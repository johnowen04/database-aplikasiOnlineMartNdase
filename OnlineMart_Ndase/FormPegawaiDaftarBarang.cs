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
    public partial class FormPegawaiDaftarBarang : Form
    {
        public List<Barang> listBarang = new List<Barang>();

        public FormPegawaiDaftarBarang()
        {
            InitializeComponent();
        }

        private void FormatDataGrid()
        {
            dataGridViewDaftarBarang.Columns.Clear();

            dataGridViewDaftarBarang.Columns.Add("Id", "Id Barang");
            dataGridViewDaftarBarang.Columns.Add("Nama", "Nama Barang");
            dataGridViewDaftarBarang.Columns.Add("Harga", "Harga Barang");
            dataGridViewDaftarBarang.Columns.Add("Kategori", "Kategori");

            DataGridViewButtonColumn buttonColumnUbah = new DataGridViewButtonColumn();
            buttonColumnUbah.HeaderText = "Aksi";
            buttonColumnUbah.Text = "Ubah";
            buttonColumnUbah.Name = "btnUbahGrid";
            buttonColumnUbah.UseColumnTextForButtonValue = true;
            dataGridViewDaftarBarang.Columns.Add(buttonColumnUbah);

            DataGridViewButtonColumn buttonColumnHapus = new DataGridViewButtonColumn();
            buttonColumnHapus.HeaderText = "Aksi";
            buttonColumnHapus.Text = "Hapus";
            buttonColumnHapus.Name = "btnHapusGrid";
            buttonColumnHapus.UseColumnTextForButtonValue = true;
            dataGridViewDaftarBarang.Columns.Add(buttonColumnHapus);

            dataGridViewDaftarBarang.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarBarang.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarBarang.Columns["Harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarBarang.Columns["Kategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewDaftarBarang.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewDaftarBarang.Columns["Harga"].DefaultCellStyle.Format = "#,###";

            dataGridViewDaftarBarang.AllowUserToAddRows = false;
            dataGridViewDaftarBarang.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewDaftarBarang.Rows.Clear();

            if (listBarang.Count > 0)
            {
                foreach (Barang b in listBarang)
                {
                    dataGridViewDaftarBarang.Rows.Add(b.Id, b.Nama,
                        b.Harga, b.Kategori.Nama);
                }
            }
            else
            {
                dataGridViewDaftarBarang.DataSource = null;
            }
        }

        private void dataGridViewDaftarBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pId = dataGridViewDaftarBarang.CurrentRow.Cells["id"].Value.ToString();
            string pNama = dataGridViewDaftarBarang.CurrentRow.Cells["nama"].Value.ToString();
            string pHarga = dataGridViewDaftarBarang.CurrentRow.Cells["harga"].Value.ToString();
            string pKategori = dataGridViewDaftarBarang.CurrentRow.Cells["kategori"].Value.ToString();

            if (e.ColumnIndex == dataGridViewDaftarBarang.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
            {
                DialogResult hasil = MessageBox.Show(this, "Apakah anda yakin ingin menghapus " + pId + "-" + pNama + "-" + pHarga + "-" + pKategori + "?",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    Boolean hapus = Barang.DeleteData(pId);
                    if (hapus == true)
                    {
                        MessageBox.Show("Berhasil hapus data", "Informasi");

                        FormPegawaiDaftarBarang_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Gagal hapus data", "Kesalahan");
                    }
                }
            }
            else
            {
                FormPegawaiUbahBarang form = new FormPegawaiUbahBarang();
                form.Owner = this;
                form.textBoxId.Text = pId;
                form.textBoxNama.Text = pNama;
                form.textBoxHarga.Text = pHarga;
                form.ShowDialog();
            }
        }

        public void FormPegawaiDaftarBarang_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listBarang = Barang.ReadData("", "");
            TampilDataGrid();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormPegawaiTambahBarang formPegawaiTambahBarang = new FormPegawaiTambahBarang();
            formPegawaiTambahBarang.Owner = this;
            formPegawaiTambahBarang.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";

            switch (comboBoxCari.Text)
            {
                case "ID Barang":
                    kriteria = "b.id";
                    break;
                case "Nama Barang":
                    kriteria = "b.nama";
                    break;
                case "Harga Barang":
                    kriteria = "b.harga";
                    break;
                case "Nama Kategori":
                    kriteria = "k.nama";
                    break;
            }

            listBarang = Barang.ReadData(kriteria, textBoxCari.Text);

            TampilDataGrid();
        }
    }
}
