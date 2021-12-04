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
    public partial class FormPegawaiDaftarPromo : Form
    {
        private List<Promo> listPromo = new List<Promo>();

        public FormPegawaiDaftarPromo()
        {
            InitializeComponent();
        }

        private void FormatDataGrid()
        {
            dataGridViewDaftarPromo.Columns.Clear();

            dataGridViewDaftarPromo.Columns.Add("Id", "Id Promo");
            dataGridViewDaftarPromo.Columns.Add("Tipe", "Tipe Promo");
            dataGridViewDaftarPromo.Columns.Add("Nama", "Nama Promo");
            dataGridViewDaftarPromo.Columns.Add("Diskon", "Diskon");
            dataGridViewDaftarPromo.Columns.Add("MaxDiskon", "Max. Diskon");
            dataGridViewDaftarPromo.Columns.Add("MinBelanja", "Min. Belanja");

            DataGridViewButtonColumn buttonColumnUbah = new DataGridViewButtonColumn();
            buttonColumnUbah.HeaderText = "Aksi";
            buttonColumnUbah.Text = "Ubah";
            buttonColumnUbah.Name = "btnUbahGrid";
            buttonColumnUbah.UseColumnTextForButtonValue = true;
            dataGridViewDaftarPromo.Columns.Add(buttonColumnUbah);

            DataGridViewButtonColumn buttonColumnHapus = new DataGridViewButtonColumn();
            buttonColumnHapus.HeaderText = "Aksi";
            buttonColumnHapus.Text = "Hapus";
            buttonColumnHapus.Name = "btnHapusGrid";
            buttonColumnHapus.UseColumnTextForButtonValue = true;
            dataGridViewDaftarPromo.Columns.Add(buttonColumnHapus);

            dataGridViewDaftarPromo.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarPromo.Columns["Tipe"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarPromo.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarPromo.Columns["Diskon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarPromo.Columns["MaxDiskon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarPromo.Columns["MinBelanja"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewDaftarPromo.Columns["Diskon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewDaftarPromo.Columns["Diskon"].DefaultCellStyle.Format = "#";

            dataGridViewDaftarPromo.Columns["MaxDiskon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewDaftarPromo.Columns["MaxDiskon"].DefaultCellStyle.Format = "#,###";

            dataGridViewDaftarPromo.Columns["MinBelanja"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewDaftarPromo.Columns["MinBelanja"].DefaultCellStyle.Format = "#,###";

            dataGridViewDaftarPromo.AllowUserToAddRows = false;
            dataGridViewDaftarPromo.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewDaftarPromo.Rows.Clear();

            if (listPromo.Count > 0)
            {
                foreach (Promo p in listPromo)
                {
                    if (p.Id != 0)
                    {
                        dataGridViewDaftarPromo.Rows.Add(p.Id, p.Tipe, p.Nama,
                        p.Diskon, p.MaxDiskon, p.MinBelanja);
                    }
                }
            }
            else
            {
                dataGridViewDaftarPromo.DataSource = null;
            }
        }

        public void FormPegawaiDaftarPromo_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listPromo = Promo.ReadData("", "");
            TampilDataGrid();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormPegawaiTambahPromo formPegawaiTambahPromo = new FormPegawaiTambahPromo();
            formPegawaiTambahPromo.Owner = this;
            formPegawaiTambahPromo.Show();
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
                case "ID Promo":
                    kriteria = "id";
                    break;
                case "Nama Promo":
                    kriteria = "nama";
                    break;
                case "Tipe Promo":
                    kriteria = "tipe";
                    break;
                case "Diskon":
                    kriteria = "diskon";
                    break;
                case "Diskon Maksimal":
                    kriteria = "diskon_max";
                    break;
                case "Minimal Belanja":
                    kriteria = "minimal_belanja";
                    break;
            }

            listPromo = Promo.ReadData(kriteria, textBoxCari.Text);

            TampilDataGrid();
        }

        private void dataGridViewDaftarPromo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pId = dataGridViewDaftarPromo.CurrentRow.Cells["Id"].Value.ToString();
            string pNama = dataGridViewDaftarPromo.CurrentRow.Cells["Nama"].Value.ToString();
            string pTipe = dataGridViewDaftarPromo.CurrentRow.Cells["Tipe"].Value.ToString();
            string pDiskon = dataGridViewDaftarPromo.CurrentRow.Cells["Diskon"].Value.ToString();
            string pMaks = dataGridViewDaftarPromo.CurrentRow.Cells["MaxDiskon"].Value.ToString();
            string pMinimal = dataGridViewDaftarPromo.CurrentRow.Cells["MinBelanja"].Value.ToString();

            if (e.ColumnIndex == dataGridViewDaftarPromo.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
            {
                DialogResult hasil = MessageBox.Show(this, "Apakah anda yakin ingin menghapus " + pId + "-" + pNama + "?",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    Boolean hapus = Promo.DeleteData(pId);
                    if (hapus == true)
                    {
                        MessageBox.Show("Berhasil hapus data", "Informasi");

                        FormPegawaiDaftarPromo_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Gagal hapus data", "Informasi");
                    }
                }
            }
            else
            {
                FormPegawaiUbahPromo form = new FormPegawaiUbahPromo();
                form.Owner = this;
                form.textBoxID.Text = pId;
                form.textBoxNama.Text = pNama;
                form.textBoxTipe.Text = pTipe;
                form.textBoxDiskon.Text = pDiskon;
                form.textBoxMaksimalDiskon.Text = pMaks;
                form.textBoxMinimalPembelian.Text = pMinimal;
                form.ShowDialog();
                FormPegawaiDaftarPromo_Load(sender, e);
            }
        }
    }
}
