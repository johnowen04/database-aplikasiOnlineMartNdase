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
            dataGridViewKeranjang.Columns.Add("Quantity", "Qty");

            dataGridViewKeranjang.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewKeranjang.Columns["Harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewKeranjang.Columns["Kategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewKeranjang.Columns["Cabang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewKeranjang.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewKeranjang.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewKeranjang.Columns["Harga"].DefaultCellStyle.Format = "#,###";

            dataGridViewKeranjang.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewKeranjang.Columns["Quantity"].DefaultCellStyle.Format = "##";

            dataGridViewKeranjang.AllowUserToAddRows = false;
            dataGridViewKeranjang.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewKeranjang.Rows.Clear();

            if (formUtama.ko.ListKeranjangBarang.Count > 0)
            {
                foreach (KeranjangBarang kb in formUtama.ko.ListKeranjangBarang)
                {
                    dataGridViewKeranjang.Rows.Add(kb.Barang.Nama, kb.Barang.Harga,
                        kb.Barang.Kategori.Nama, formUtama.cabang.Nama, kb.Quantity);
                }
            }
            else
            {
                dataGridViewKeranjang.DataSource = null;
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e) =>this.Close();

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
                //formKonsumenCheckout.labelKodePromo.Visible = false;
                //formKonsumenCheckout.labelKodePromo.Enabled = false;
                formKonsumenCheckout.buttonBayar.Enabled = false;
                formKonsumenCheckout.ShowDialog();
                FormKonsumenKeranjang_Load(sender, e);
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }
    }
}
