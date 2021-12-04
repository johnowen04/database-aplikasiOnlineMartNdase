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

        private FormUtama formUtama;

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
            formUtama = (FormUtama)this.MdiParent;
            FormatDataGrid();
            listPengiriman = Pengiriman.ReadData(formUtama.ku);
            TampilDataGrid();
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
                case "Nama Konsumen":
                    kriteria = "p.nama";
                    break;
                case "Alamat Pengiriman":
                    kriteria = "o.alamat_tujuan";
                    break;
                case "Komisi":
                    kriteria = "(o.ongkos_kirim * 0.8)";
                    break;
            }

            listPengiriman = Pengiriman.ReadData(formUtama.ku, kriteria, textBoxCari.Text);

            TampilDataGrid();
        }
    }
}
