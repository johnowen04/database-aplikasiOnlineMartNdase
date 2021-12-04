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
        List<Barang> listBarang = new List<Barang>();
        public FormPegawaiDaftarBarang()
        {
            InitializeComponent();
        }

        public void FormPegawaiDaftarBarang_Load(object sender, EventArgs e)
        {
            listBarang = Barang.ReadData("", textBoxCari.Text);

            if (listBarang.Count > 0)
            {
                dataGridViewDaftarBarang.DataSource = listBarang;
                if (dataGridViewDaftarBarang.ColumnCount == 2)
                {
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "Aksi";
                    bcol.Text = "Ubah";
                    bcol.Name = "buttonUbah";
                    bcol.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarBarang.Columns.Add(bcol);

                    DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                    bcol2.HeaderText = "Aksi";
                    bcol2.Text = "Hapus";
                    bcol2.Name = "buttonHapus";
                    bcol2.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarBarang.Columns.Add(bcol2);
                }
            }
            else
            {
                dataGridViewDaftarBarang.DataSource = null;
            }
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
            if (comboBoxCari.Text == "ID Barang")
            {
                listBarang = Barang.ReadData("id", textBoxCari.Text);
            }
            else if (comboBoxCari.Text == "Nama Barang")
            {
                listBarang = Barang.ReadData("nama", textBoxCari.Text);
            }
            else if (comboBoxCari.Text == "Harga Barang")
            {
                listBarang = Barang.ReadData("harga", textBoxCari.Text);
            }
            else if (comboBoxCari.Text == "ID Kategori")
            {
                listBarang = Barang.ReadData("kategoris_id", textBoxCari.Text);
            }

            if (listBarang.Count > 0)
            {
                dataGridViewDaftarBarang.DataSource = listBarang;
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
            string pIdKategori = dataGridViewDaftarBarang.CurrentRow.Cells["kategoris_id"].Value.ToString();

            if (e.ColumnIndex == dataGridViewDaftarBarang.Columns["buttonHapus"].Index && e.RowIndex >= 0)
            {
                DialogResult hasil = MessageBox.Show(this, "Apakah anda yakin ingin menghapus " + pId + "-" + pNama + "-" + pHarga + "-" + pIdKategori + "?",
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
                        MessageBox.Show("Gagal hapus data", "Informasi");
                    }
                }
            }
            else
            {
                FormPegawaiUbahKategori form = new FormPegawaiUbahKategori();
                form.Owner = this;
                form.textBoxID.Text = pId;
                form.textBoxNama.Text = pNama;
                form.ShowDialog();
            }
        }
    }
}
