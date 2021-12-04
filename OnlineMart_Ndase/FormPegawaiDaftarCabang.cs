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
    public partial class FormPegawaiDaftarCabang : Form
    {
        public List<Cabang> listCabang = new List<Cabang>();

        public FormPegawaiDaftarCabang()
        {
            InitializeComponent();
        }

        private void FormatDataGrid()
        {
            dataGridViewDaftarCabang.Columns.Clear();

            dataGridViewDaftarCabang.Columns.Add("Id", "Id Cabang");
            dataGridViewDaftarCabang.Columns.Add("Nama", "Nama Cabang");
            dataGridViewDaftarCabang.Columns.Add("Alamat", "Alamat");
            dataGridViewDaftarCabang.Columns.Add("Pegawai", "Pegawai");

            DataGridViewButtonColumn buttonColumnUbah = new DataGridViewButtonColumn();
            buttonColumnUbah.HeaderText = "Aksi";
            buttonColumnUbah.Text = "Ubah";
            buttonColumnUbah.Name = "btnUbahGrid";
            buttonColumnUbah.UseColumnTextForButtonValue = true;
            dataGridViewDaftarCabang.Columns.Add(buttonColumnUbah);

            DataGridViewButtonColumn buttonColumnHapus = new DataGridViewButtonColumn();
            buttonColumnHapus.HeaderText = "Aksi";
            buttonColumnHapus.Text = "Hapus";
            buttonColumnHapus.Name = "btnHapusGrid";
            buttonColumnHapus.UseColumnTextForButtonValue = true;
            dataGridViewDaftarCabang.Columns.Add(buttonColumnHapus);

            dataGridViewDaftarCabang.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarCabang.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarCabang.Columns["Alamat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarCabang.Columns["Pegawai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewDaftarCabang.AllowUserToAddRows = false;
            dataGridViewDaftarCabang.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewDaftarCabang.Rows.Clear();

            if (listCabang.Count > 0)
            {
                foreach (Cabang c in listCabang)
                {
                    dataGridViewDaftarCabang.Rows.Add(c.Id, c.Nama,
                        c.Alamat, c.Pegawai.Nama);
                }
            }
            else
            {
                dataGridViewDaftarCabang.DataSource = null;
            }
        }

        private void dataGridViewDaftarCabang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pId = dataGridViewDaftarCabang.CurrentRow.Cells["id"].Value.ToString();
            string pNama = dataGridViewDaftarCabang.CurrentRow.Cells["nama"].Value.ToString();
            string pAlamat = dataGridViewDaftarCabang.CurrentRow.Cells["alamat"].Value.ToString();
            string pNamaPegawai = dataGridViewDaftarCabang.CurrentRow.Cells["pegawai"].Value.ToString();

            if (e.ColumnIndex == dataGridViewDaftarCabang.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
            {
                DialogResult hasil = MessageBox.Show(this, "Apakah anda yakin ingin menghapus " + pId + "-" + pNama + "-" + pAlamat + "-" + pNamaPegawai + "?",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    Boolean hapus = Cabang.DeleteData(pId);
                    if (hapus == true)
                    {
                        MessageBox.Show("Berhasil hapus data", "Informasi");

                        FormPegawaiDaftarCabang_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Gagal hapus data", "Kesalahan");
                    }
                }
            }
            else
            {
                FormPegawaiUbahCabang form = new FormPegawaiUbahCabang();
                form.Owner = this;
                form.textBoxID.Text = pId;
                form.textBoxNama.Text = pNama;
                form.textBoxAlamat.Text = pAlamat;
                form.comboBoxPegawai.Text = pNamaPegawai;
                form.ShowDialog();
            }
        }

        public void FormPegawaiDaftarCabang_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listCabang = Cabang.ReadData("", textBoxCari.Text);
            TampilDataGrid();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormPegawaiTambahCabang formPegawaiTambahCabang = new FormPegawaiTambahCabang();
            formPegawaiTambahCabang.Owner = this;
            formPegawaiTambahCabang.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";

            switch(comboBoxCari.Text)
            {
                case "ID Cabang":
                    kriteria = "c.id";
                    break;
                case "Nama Cabang":
                    kriteria = "C.nama";
                    break;
                case "Alamat Cabang":
                    kriteria = "c.alamat";
                    break;
                case "Nama Pegawai":
                    kriteria = "p.nama";
                    break;
            }

            listCabang = Cabang.ReadData(kriteria, textBoxCari.Text);

            TampilDataGrid();
        }
    }
}
