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

            //DataGridViewButtonColumn buttonColumnUbah = new DataGridViewButtonColumn();
            //buttonColumnUbah.HeaderText = "Aksi";
            //buttonColumnUbah.Text = "Ubah";
            //buttonColumnUbah.Name = "btnUbahGrid";
            //buttonColumnUbah.UseColumnTextForButtonValue = true;
            //dataGridViewDaftarPromo.Columns.Add(buttonColumnUbah);

            //DataGridViewButtonColumn buttonColumnHapus = new DataGridViewButtonColumn();
            //buttonColumnHapus.HeaderText = "Aksi";
            //buttonColumnHapus.Text = "Hapus";
            //buttonColumnHapus.Name = "btnHapusGrid";
            //buttonColumnHapus.UseColumnTextForButtonValue = true;
            //dataGridViewDaftarPromo.Columns.Add(buttonColumnHapus);

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
                    dataGridViewDaftarPromo.Rows.Add(p.Id, p.Tipe, p.Nama,
                        p.Diskon, p.MaxDiskon, p.MinBelanja);
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
    }
}
