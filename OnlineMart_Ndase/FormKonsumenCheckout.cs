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
    public partial class FormKonsumenCheckout : Form
    {
        //FormUtama formUtama;
        FormKonsumenKeranjang formKonsumenKeranjang;

        public FormKonsumenCheckout()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabelKodePromo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormKonsumenKodePromo formKonsumenKodePromo = new FormKonsumenKodePromo();
            formKonsumenKodePromo.Owner = this;
            formKonsumenKodePromo.ShowDialog();
        }

        private void FormKonsumenCheckout_Load(object sender, EventArgs e)
        {
            labelKodePromo.Visible = false;
            labelKodePromo.Enabled = false;

            buttonBayar.Enabled = false;

            formKonsumenKeranjang = (FormKonsumenKeranjang)this.Owner;
            FormatDataGrid();
            TampilDataGrid();
        }

        private void FormatDataGrid()
        {
            dataGridViewBarang.Columns.Clear();

            dataGridViewBarang.Columns.Add("Nama", "Nama Barang");
            dataGridViewBarang.Columns.Add("Harga", "Harga Barang");
            dataGridViewBarang.Columns.Add("Kategori", "Kategori");
            dataGridViewBarang.Columns.Add("Cabang", "Cabang");
            dataGridViewBarang.Columns.Add("Quantity", "Qty");

            dataGridViewBarang.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["Harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["Kategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["Cabang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewBarang.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewBarang.Columns["Harga"].DefaultCellStyle.Format = "#,###";

            dataGridViewBarang.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewBarang.Columns["Quantity"].DefaultCellStyle.Format = "##";

            dataGridViewBarang.AllowUserToAddRows = false;
            dataGridViewBarang.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewBarang.Rows.Clear();

            if (formKonsumenKeranjang.formUtama.ko.ListKeranjangBarang.Count > 0)
            {
                foreach (KeranjangBarang kb in formKonsumenKeranjang.formUtama.ko.ListKeranjangBarang)
                {
                    dataGridViewBarang.Rows.Add(kb.Barang.Nama, kb.Barang.Harga,
                        kb.Barang.Kategori.Nama, kb.Cabang.Nama, kb.Quantity);
                }
            }
            else
            {
                dataGridViewBarang.DataSource = null;
            }
        }
    }
}
