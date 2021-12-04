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
    public partial class FormKurirDaftarPengiriman : Form
    {
        private List<Pengiriman> listPengiriman = new List<Pengiriman>();

        public FormKurirDaftarPengiriman()
        {
            InitializeComponent();
        }

        private void FormatDataGrid()
        {
            dataGridViewDaftarPengiriman.Columns.Clear();

            dataGridViewDaftarPengiriman.Columns.Add("NamaKonsumen", "Nama Konsumen");
            dataGridViewDaftarPengiriman.Columns.Add("AlamatTujuan", "Alamat Tujuan");
            dataGridViewDaftarPengiriman.Columns.Add("Komisi", "Komisi");

            //DataGridViewButtonColumn buttonColumnUbah = new DataGridViewButtonColumn();
            //buttonColumnUbah.HeaderText = "Aksi";
            //buttonColumnUbah.Text = "Ubah";
            //buttonColumnUbah.Name = "btnUbahGrid";
            //buttonColumnUbah.UseColumnTextForButtonValue = true;
            //dataGridViewDaftarPengiriman.Columns.Add(buttonColumnUbah);

            //DataGridViewButtonColumn buttonColumnHapus = new DataGridViewButtonColumn();
            //buttonColumnHapus.HeaderText = "Aksi";
            //buttonColumnHapus.Text = "Hapus";
            //buttonColumnHapus.Name = "btnHapusGrid";
            //buttonColumnHapus.UseColumnTextForButtonValue = true;
            //dataGridViewDaftarPengiriman.Columns.Add(buttonColumnHapus);

            dataGridViewDaftarPengiriman.Columns["NamaKonsumen"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarPengiriman.Columns["AlamatTujuan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarPengiriman.Columns["Komisi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewDaftarPengiriman.Columns["Komisi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewDaftarPengiriman.Columns["Komisi"].DefaultCellStyle.Format = "#,###";

            dataGridViewDaftarPengiriman.AllowUserToAddRows = false;
            dataGridViewDaftarPengiriman.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewDaftarPengiriman.Rows.Clear();

            if (listPengiriman.Count > 0)
            {
                foreach (Pengiriman p in listPengiriman)
                {
                    dataGridViewDaftarPengiriman.Rows.Add(p.NamaKonsumen, p.AlamatTujuan, p.Komisi);
                }
            }
            else
            {
                dataGridViewDaftarPengiriman.DataSource = null;
            }
        }

        private void FormKurirDaftarPengiriman_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listPengiriman = Pengiriman.ReadData("", "");
            TampilDataGrid();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
