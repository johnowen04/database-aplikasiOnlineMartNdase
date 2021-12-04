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
    public partial class FormPegawaiDaftarMetodePembayaran : Form
    {
        public List<MetodePembayaran> listMetodePembayaran = new List<MetodePembayaran>();
        public FormPegawaiDaftarMetodePembayaran()
        {
            InitializeComponent();
        }

        private void FormatDataGrid()
        {
            dataGridViewDaftarMetodePembayaran.Columns.Clear();

            dataGridViewDaftarMetodePembayaran.Columns.Add("Id", "ID");
            dataGridViewDaftarMetodePembayaran.Columns.Add("Nama", "Nama");

            DataGridViewButtonColumn buttonColumnUbah = new DataGridViewButtonColumn();
            buttonColumnUbah.HeaderText = "Aksi";
            buttonColumnUbah.Text = "Ubah";
            buttonColumnUbah.Name = "btnUbahGrid";
            buttonColumnUbah.UseColumnTextForButtonValue = true;
            dataGridViewDaftarMetodePembayaran.Columns.Add(buttonColumnUbah);

            DataGridViewButtonColumn buttonColumnHapus = new DataGridViewButtonColumn();
            buttonColumnHapus.HeaderText = "Aksi";
            buttonColumnHapus.Text = "Hapus";
            buttonColumnHapus.Name = "btnHapusGrid";
            buttonColumnHapus.UseColumnTextForButtonValue = true;
            dataGridViewDaftarMetodePembayaran.Columns.Add(buttonColumnHapus);

            dataGridViewDaftarMetodePembayaran.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarMetodePembayaran.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewDaftarMetodePembayaran.AllowUserToAddRows = false;
            dataGridViewDaftarMetodePembayaran.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewDaftarMetodePembayaran.Rows.Clear();

            if (listMetodePembayaran.Count > 0)
            {
                foreach (MetodePembayaran mp in listMetodePembayaran)
                {
                    dataGridViewDaftarMetodePembayaran.Rows.Add(mp.Id, mp.Nama);
                }
            }
            else
            {
                dataGridViewDaftarMetodePembayaran.DataSource = null;
            }
        }
        public void FormPegawaiDaftarMetodePembayaran_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listMetodePembayaran = MetodePembayaran.ReadData("", textBoxCari.Text);
            TampilDataGrid();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormPegawaiTambahMetodePembayaran formPegawaiTambahMetodePembayaran = new FormPegawaiTambahMetodePembayaran();
            formPegawaiTambahMetodePembayaran.Owner = this;
            formPegawaiTambahMetodePembayaran.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewDaftarMetodePembayaran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pId = dataGridViewDaftarMetodePembayaran.CurrentRow.Cells["id"].Value.ToString();
            string pNama = dataGridViewDaftarMetodePembayaran.CurrentRow.Cells["nama"].Value.ToString();

            if (e.ColumnIndex == dataGridViewDaftarMetodePembayaran.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
            {
                DialogResult hasil = MessageBox.Show(this, "Apakah anda yakin ingin menghapus " + pId + "-" + pNama + "?",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    Boolean hapus = MetodePembayaran.DeleteData(pId);
                    if (hapus == true)
                    {
                        MessageBox.Show("Berhasil hapus data", "Informasi");

                        FormPegawaiDaftarMetodePembayaran_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Gagal hapus data", "Informasi");
                    }
                }
            }
            else
            {
                FormPegawaiUbahMetodePembayaran form = new FormPegawaiUbahMetodePembayaran();
                form.Owner = this;
                form.textBoxID.Text = pId;
                form.textBoxNama.Text = pNama;
                form.ShowDialog();

                FormPegawaiDaftarMetodePembayaran_Load(sender, e);
            }
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";

            switch (comboBoxCari.Text)
            {
                case "ID":
                    kriteria = "id";
                    break;
                case "Nama":
                    kriteria = "nama";
                    break;
            }

            listMetodePembayaran = MetodePembayaran.ReadData(kriteria, textBoxCari.Text);

            TampilDataGrid();
        }
    }
}
