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
    public partial class FormPegawaiRekapPenjualanBarang : Form
    {
        private List<RiwayatPenjualanBarang> listRiwayatBarang = new List<RiwayatPenjualanBarang>();

        public FormPegawaiRekapPenjualanBarang()
        {
            InitializeComponent();
        }

        private void FormPegawaiRekapPenjualanBarang_Load(object sender, EventArgs e)
        {
            numericUpDownTahun.Value = 2021;

            comboBoxCabang.DataSource = Cabang.ReadData();
            comboBoxCabang.DisplayMember = "nama";
            comboBoxCabang.DropDownStyle = ComboBoxStyle.DropDownList;

            FormatDataGrid();

            listRiwayatBarang = RiwayatPenjualanBarang.ReadData("", "", numericUpDownTahun.Value.ToString(),
                        comboBoxCabang.Text);

            TampilDataGrid();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    listRiwayatBarang = RiwayatPenjualanBarang.ReadData("", "", numericUpDownTahun.Value.ToString(),
                        comboBoxCabang.Text);
                }

                else
                {
                    listRiwayatBarang = RiwayatPenjualanBarang.ReadData("1", comboBoxBulan.Text, numericUpDownTahun.Value.ToString(),
                        comboBoxCabang.Text);
                }

                TampilDataGrid();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Gagal menerapkan filter. \nPesan kesalahan : " + ex.Message);
            }
        }

        private void FormatDataGrid()
        {
            dataGridViewRiwayatOmset.Columns.Clear();

            dataGridViewRiwayatOmset.Columns.Add("bulan", "Bulan");
            dataGridViewRiwayatOmset.Columns.Add("nama", "Nama Cabang");
            dataGridViewRiwayatOmset.Columns.Add("total", "Total Omset");

            dataGridViewRiwayatOmset.Columns["bulan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRiwayatOmset.Columns["nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewRiwayatOmset.Columns["total"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewRiwayatOmset.AllowUserToAddRows = false;
            dataGridViewRiwayatOmset.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewRiwayatOmset.Rows.Clear();

            if (listRiwayatBarang.Count > 0)
            {
                foreach (RiwayatPenjualanBarang rpb in listRiwayatBarang)
                {
                    dataGridViewRiwayatOmset.Rows.Add(rpb.Bulan, rpb.NamaCabang, rpb.Total);
                }
            }
            else
            {
                dataGridViewRiwayatOmset.DataSource = null;
            }
        }
    }
}
