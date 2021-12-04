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
    public partial class FormPegawaiDaftarKategori : Form
    {
        public List<Kategori> listKategori = new List<Kategori>();

        public FormPegawaiDaftarKategori()
        {
            InitializeComponent();
        }
        private void FormatDataGrid()
        {
            dataGridViewDaftarKategori.Columns.Clear();

            dataGridViewDaftarKategori.Columns.Add("Id", "Id Kategori");
            dataGridViewDaftarKategori.Columns.Add("Nama", "Nama Kategori");

            DataGridViewButtonColumn buttonColumnUbah = new DataGridViewButtonColumn();
            buttonColumnUbah.HeaderText = "Aksi";
            buttonColumnUbah.Text = "Ubah";
            buttonColumnUbah.Name = "btnUbahGrid";
            buttonColumnUbah.UseColumnTextForButtonValue = true;
            dataGridViewDaftarKategori.Columns.Add(buttonColumnUbah);

            DataGridViewButtonColumn buttonColumnHapus = new DataGridViewButtonColumn();
            buttonColumnHapus.HeaderText = "Aksi";
            buttonColumnHapus.Text = "Hapus";
            buttonColumnHapus.Name = "btnHapusGrid";
            buttonColumnHapus.UseColumnTextForButtonValue = true;
            dataGridViewDaftarKategori.Columns.Add(buttonColumnHapus);

            dataGridViewDaftarKategori.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarKategori.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewDaftarKategori.AllowUserToAddRows = false;
            dataGridViewDaftarKategori.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewDaftarKategori.Rows.Clear();

            if (listKategori.Count > 0)
            {
                foreach (Kategori k in listKategori)
                {
                    dataGridViewDaftarKategori.Rows.Add(k.Id, k.Nama);
                }
            }
            else
            {
                dataGridViewDaftarKategori.DataSource = null;
            }
        }

        private void dataGridViewDaftarKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pId = dataGridViewDaftarKategori.CurrentRow.Cells["id"].Value.ToString();
            string pNama = dataGridViewDaftarKategori.CurrentRow.Cells["nama"].Value.ToString();

            if (e.ColumnIndex == dataGridViewDaftarKategori.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
            {
                DialogResult hasil = MessageBox.Show(this, "Apakah anda yakin ingin menghapus " + pId + "-" + pNama + "?",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    Boolean hapus = Kategori.DeleteData(pId);
                    if (hapus == true)
                    {
                        MessageBox.Show("Berhasil hapus data", "Informasi");

                        FormPegawaiDaftarKategori_Load(sender, e);
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

        public void FormPegawaiDaftarKategori_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listKategori = Kategori.ReadData("", textBoxCari.Text);
            TampilDataGrid();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormPegawaiTambahKategori formPegawaiTambahKategori = new FormPegawaiTambahKategori();
            formPegawaiTambahKategori.Owner = this;
            formPegawaiTambahKategori.Show();
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
                case "ID Kategori":
                    kriteria = "id";
                    break;
                case "Nama Kategori":
                    kriteria = "nama";
                    break;
            }

            listKategori = Kategori.ReadData(kriteria, textBoxCari.Text);

            TampilDataGrid();
        }
    }
}
