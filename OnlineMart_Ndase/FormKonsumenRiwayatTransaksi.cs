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
    public partial class FormKonsumenRiwayatTransaksi : Form
    {
        FormUtama formUtama;

        private List<Order> listOrder = new List<Order>();

        public FormKonsumenRiwayatTransaksi()
        {
            InitializeComponent();
        }

        private void FormKonsumenRiwayatTransaksi_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.MdiParent;

            FormatDataGrid();

            listOrder = Order.ReadData(formUtama.ko.Id.ToString());

            TampilDataGrid();
        }

        private void buttonKeluar_Click(object sender, EventArgs e) => this.Close();

        private void FormatDataGrid()
        {
            dataGridViewRiwayatTransaksi.Columns.Clear();

            dataGridViewRiwayatTransaksi.Columns.Add("id", "No. Order");
            dataGridViewRiwayatTransaksi.Columns.Add("tanggal", "Tanggal");
            dataGridViewRiwayatTransaksi.Columns.Add("total", "Total Bayar");
            dataGridViewRiwayatTransaksi.Columns.Add("cabang", "Nama Cabang");

            DataGridViewButtonColumn buttonColumnCek = new DataGridViewButtonColumn();
            buttonColumnCek.HeaderText = "Aksi";
            buttonColumnCek.Text = "Cek Pesanan";
            buttonColumnCek.Name = "btnCekGrid";
            buttonColumnCek.UseColumnTextForButtonValue = true;
            dataGridViewRiwayatTransaksi.Columns.Add(buttonColumnCek);

            dataGridViewRiwayatTransaksi.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRiwayatTransaksi.Columns["tanggal"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRiwayatTransaksi.Columns["total"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRiwayatTransaksi.Columns["cabang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewRiwayatTransaksi.Columns["total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewRiwayatTransaksi.Columns["total"].DefaultCellStyle.Format = "#,###";

            dataGridViewRiwayatTransaksi.AllowUserToAddRows = false;
            dataGridViewRiwayatTransaksi.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewRiwayatTransaksi.Rows.Clear();

            if (listOrder.Count > 0)
            {
                foreach (Order o in listOrder)
                {
                    dataGridViewRiwayatTransaksi.Rows.Add(o.Id, o.Tanggal_Waktu, o.Total_Bayar, o.Cabang.Nama);
                }
            }
            else
            {
                dataGridViewRiwayatTransaksi.DataSource = null;
            }
        }

        private void dataGridViewRiwayatTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string tId = dataGridViewRiwayatTransaksi.CurrentRow.Cells["id"].Value.ToString();
                string tTanggal = dataGridViewRiwayatTransaksi.CurrentRow.Cells["tanggal"].Value.ToString();
                string tTotal = dataGridViewRiwayatTransaksi.CurrentRow.Cells["total"].Value.ToString();
                string tCabang = dataGridViewRiwayatTransaksi.CurrentRow.Cells["cabang"].Value.ToString();

                if (e.ColumnIndex == dataGridViewRiwayatTransaksi.Columns["btnCekGrid"].Index && e.RowIndex >= 0)
                {
                    Order selectedOrder = listOrder.Find(order => order.Id == tId);

                    FormKonsumenCekPesanan form = new FormKonsumenCekPesanan();
                    form.Owner = this;
                    form.order = selectedOrder;
                    form.labelNoOrder.Text = selectedOrder.Id;
                    form.labelAlamat.Text = selectedOrder.Alamat_Tujuan;
                    form.labelKurir.Text = selectedOrder.Kurir.Nama;
                    form.labelStatus.Text = selectedOrder.Status;
                    form.labelMetodePembayaran.Text = selectedOrder.MetodePembayaran.Nama;
                    form.labelTotal.Text = "Rp" + selectedOrder.Total_Bayar.ToString("#,###");
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
