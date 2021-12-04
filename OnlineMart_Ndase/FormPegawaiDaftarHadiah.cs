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
    public partial class FormPegawaiDaftarHadiah : Form
    {
        private List<Hadiah> listHadiah = new List<Hadiah>();

        public FormPegawaiDaftarHadiah()
        {
            InitializeComponent();
        }

        private void FormatDataGrid()
        {
            dataGridViewDaftarHadiah.Columns.Clear();

            dataGridViewDaftarHadiah.Columns.Add("Id", "Id Promo");
            dataGridViewDaftarHadiah.Columns.Add("Nama", "Nama Promo");
            dataGridViewDaftarHadiah.Columns.Add("JumlahPoin", "Jumlah Poin");

            //DataGridViewButtonColumn buttonColumnUbah = new DataGridViewButtonColumn();
            //buttonColumnUbah.HeaderText = "Aksi";
            //buttonColumnUbah.Text = "Ubah";
            //buttonColumnUbah.Name = "btnUbahGrid";
            //buttonColumnUbah.UseColumnTextForButtonValue = true;
            //dataGridViewDaftarHadiah.Columns.Add(buttonColumnUbah);

            //DataGridViewButtonColumn buttonColumnHapus = new DataGridViewButtonColumn();
            //buttonColumnHapus.HeaderText = "Aksi";
            //buttonColumnHapus.Text = "Hapus";
            //buttonColumnHapus.Name = "btnHapusGrid";
            //buttonColumnHapus.UseColumnTextForButtonValue = true;
            //dataGridViewDaftarHadiah.Columns.Add(buttonColumnHapus);

            dataGridViewDaftarHadiah.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarHadiah.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarHadiah.Columns["JumlahPoin"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewDaftarHadiah.Columns["JumlahPoin"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewDaftarHadiah.Columns["JumlahPoin"].DefaultCellStyle.Format = "####";

            dataGridViewDaftarHadiah.AllowUserToAddRows = false;
            dataGridViewDaftarHadiah.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewDaftarHadiah.Rows.Clear();

            if (listHadiah.Count > 0)
            {
                foreach (Hadiah h in listHadiah)
                {
                    dataGridViewDaftarHadiah.Rows.Add(h.Id, h.Nama, h.JumlahPoin);
                }
            }
            else
            {
                dataGridViewDaftarHadiah.DataSource = null;
            }
        }

        public void FormPegawaiDaftarHadiah_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listHadiah = Hadiah.ReadData("", "");
            TampilDataGrid();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormPegawaiTambahHadiah formPegawaiTambahHadiah = new FormPegawaiTambahHadiah();
            formPegawaiTambahHadiah.Owner = this;
            formPegawaiTambahHadiah.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
