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
    public partial class FormKonsumenCekPesanan : Form
    {
        public Order order;

        public FormKonsumenCekPesanan()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e) => this.Close();

        private void FormKonsumenCekPesanan_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            TampilDataGrid();
        }

        private void FormatDataGrid()
        {
            dataGridViewCekPesanan.Columns.Clear();

            dataGridViewCekPesanan.Columns.Add("nama", "Nama Barang");
            dataGridViewCekPesanan.Columns.Add("jumlah", "Jumlah");
            dataGridViewCekPesanan.Columns.Add("harga", "Harga Satuan");
            dataGridViewCekPesanan.Columns.Add("subtotal", "Sub Total");

            dataGridViewCekPesanan.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCekPesanan.Columns["jumlah"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCekPesanan.Columns["harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCekPesanan.Columns["subtotal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewCekPesanan.Columns["harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCekPesanan.Columns["harga"].DefaultCellStyle.Format = "#,###";

            dataGridViewCekPesanan.Columns["subtotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCekPesanan.Columns["subtotal"].DefaultCellStyle.Format = "#,###";

            dataGridViewCekPesanan.AllowUserToAddRows = false;
            dataGridViewCekPesanan.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewCekPesanan.Rows.Clear();

            if (order.ListBarangOrder.Count > 0)
            {
                foreach (BarangOrder bo in order.ListBarangOrder)
                {
                    dataGridViewCekPesanan.Rows.Add(bo.Barang.Nama, bo.Jumlah, bo.Harga, (bo.Jumlah * bo.Harga));
                }
            }
            else
            {
                dataGridViewCekPesanan.DataSource = null;
            }
        }

        private void buttonCetakNota_Click(object sender, EventArgs e)
        {
            FormKonsumenCetakNota form = new FormKonsumenCetakNota();
            form.noOrder = order.Id;
            form.ShowDialog();
        }

        private void buttonChat_Click(object sender, EventArgs e)
        {
            FormKonsumenChat form = new FormKonsumenChat();
            form.ShowDialog();
        }
    }
}
