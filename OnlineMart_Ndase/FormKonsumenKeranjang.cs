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
    public partial class FormKonsumenKeranjang : Form
    {
        public FormUtama formUtama;

        public FormKonsumenKeranjang()
        {
            InitializeComponent();
        }

        private void FormatDataGrid()
        {
            dataGridViewKeranjang.Columns.Clear();

            dataGridViewKeranjang.Columns.Add("Nama", "Nama Barang");
            dataGridViewKeranjang.Columns.Add("Harga", "Harga Barang");
            dataGridViewKeranjang.Columns.Add("Kategori", "Kategori");
            dataGridViewKeranjang.Columns.Add("Cabang", "Cabang");

            dataGridViewKeranjang.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewKeranjang.Columns["Harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewKeranjang.Columns["Kategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewKeranjang.Columns["Cabang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewKeranjang.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dataGridViewKeranjang.Columns["Harga"].DefaultCellStyle.Format = "#,###";

            dataGridViewKeranjang.AllowUserToAddRows = false;
            dataGridViewKeranjang.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewKeranjang.Rows.Clear();

            if (formUtama.keranjang.Count > 0)
            {
                foreach (CabangBarang cb in formUtama.keranjang)
                {
                    dataGridViewKeranjang.Rows.Add(cb.Barang.Nama, cb.Barang.Harga,
                        cb.Barang.Kategori.Nama, cb.Cabang.Nama);
                }
            }
            else
            {
                dataGridViewKeranjang.DataSource = null;
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormKonsumenKeranjang_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.MdiParent;

            FormatDataGrid();
            TampilDataGrid();
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormKonsumenCheckout"];

            if (form == null)
            {
                FormKonsumenCheckout formKonsumenCheckout = new FormKonsumenCheckout();
                formKonsumenCheckout.Owner = this;
                formKonsumenCheckout.ShowDialog();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }
    }
}
