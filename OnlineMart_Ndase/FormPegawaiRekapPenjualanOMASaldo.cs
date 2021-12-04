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
    public partial class FormPegawaiRekapPenjualanOMASaldo : Form
    {
        List<RiwayatIsiSaldo> listRiwayatIsiSaldo = new List<RiwayatIsiSaldo>();

        public FormPegawaiRekapPenjualanOMASaldo()
        {
            InitializeComponent();
        }

        private void FormPegawaiRekapPenjualanOMASaldo_Load(object sender, EventArgs e)
        {
            numericUpDownTahun.Value = 2021;

            FormatDataGrid();

            listRiwayatIsiSaldo = RiwayatIsiSaldo.ReadData("", "", numericUpDownTahun.Value.ToString());

            TampilDataGrid();
        }

        private void buttonKeluar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void FormatDataGrid()
        {
            dataGridViewRiwayatOMASaldo.Columns.Clear();

            dataGridViewRiwayatOMASaldo.Columns.Add("bulan", "Bulan");
            dataGridViewRiwayatOMASaldo.Columns.Add("total", "Total Transkasi");

            dataGridViewRiwayatOMASaldo.Columns["bulan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRiwayatOMASaldo.Columns["total"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewRiwayatOMASaldo.AllowUserToAddRows = false;
            dataGridViewRiwayatOMASaldo.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewRiwayatOMASaldo.Rows.Clear();

            if (listRiwayatIsiSaldo.Count > 0)
            {
                foreach (RiwayatIsiSaldo ris in listRiwayatIsiSaldo)
                {
                    dataGridViewRiwayatOMASaldo.Rows.Add(ris.Bulan, ris.TotalTransaksi);
                }
            }
            else
            {
                dataGridViewRiwayatOMASaldo.DataSource = null;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBoxBulan.Text = "";
                comboBoxBulan.Enabled = false;
            }

            else
            {
                comboBoxBulan.SelectedIndex = 0;
                comboBoxBulan.Enabled = true;
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            try
            {
                FormatDataGrid();

                if (checkBox1.Checked)
                {
                    listRiwayatIsiSaldo = RiwayatIsiSaldo.ReadData("", "", numericUpDownTahun.Value.ToString());
                }

                else
                {
                    listRiwayatIsiSaldo = RiwayatIsiSaldo.ReadData("1", comboBoxBulan.Text, numericUpDownTahun.Value.ToString());
                }

                TampilDataGrid();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Gagal menerapkan filter. \nPesan kesalahan : " + ex.Message);
            }
        }
    }
}
