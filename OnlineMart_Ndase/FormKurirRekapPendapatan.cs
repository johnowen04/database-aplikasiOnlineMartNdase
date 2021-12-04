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
    public partial class FormKurirRekapPendapatan : Form
    {
        FormUtama formUtama;

        private List<RekapPendapatanKurir> listPendapatan = new List<RekapPendapatanKurir>();

        public FormKurirRekapPendapatan()
        {
            InitializeComponent();
        }

        private void FormKurirRekapPendapatan_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.MdiParent;

            numericUpDownTahun.Value = 2021;

            FormatDataGrid();

            listPendapatan = RekapPendapatanKurir.ReadData("", "", numericUpDownTahun.Value.ToString(), formUtama.ku.Id.ToString());

            TampilDataGrid();
        }

        private void FormatDataGrid()
        {
            dataGridViewPendapatan.Columns.Clear();

            dataGridViewPendapatan.Columns.Add("bulan", "Bulan");
            dataGridViewPendapatan.Columns.Add("total_pendapatan", "Gajian");

            dataGridViewPendapatan.Columns["bulan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPendapatan.Columns["total_pendapatan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewPendapatan.Columns["total_pendapatan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewPendapatan.Columns["total_pendapatan"].DefaultCellStyle.Format = "#,###";

            dataGridViewPendapatan.AllowUserToAddRows = false;
            dataGridViewPendapatan.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewPendapatan.Rows.Clear();

            if (listPendapatan.Count > 0)
            {
                foreach (RekapPendapatanKurir rpk in listPendapatan)
                {
                    dataGridViewPendapatan.Rows.Add(rpk.Bulan, rpk.Gajian);
                }
            }
            else
            {
                dataGridViewPendapatan.DataSource = null;
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            try
            {
                FormatDataGrid();

                if (checkBox1.Checked)
                {
                    listPendapatan = RekapPendapatanKurir.ReadData("", "", numericUpDownTahun.Value.ToString(), formUtama.ku.Id.ToString());
                }

                else
                {
                    listPendapatan = RekapPendapatanKurir.ReadData("1", comboBoxBulan.Text, numericUpDownTahun.Value.ToString(), formUtama.ku.Id.ToString());
                }

                TampilDataGrid();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Gagal menerapkan filter. \nPesan kesalahan : " + ex.Message);
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
    }
}
