using OnlineMart_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMart_Ndase
{
    public partial class FormPegawaiDaftarCabang : Form
    {
        public List<Cabang> listCabang = new List<Cabang>();

        public FormPegawaiDaftarCabang()
        {
            InitializeComponent();
        }

        public void FormPegawaiDaftarCabang_Load(object sender, EventArgs e)
        {
            listCabang = Cabang.ReadData("", textBoxCari.Text);

            if (listCabang.Count > 0)
            {
                dataGridViewDaftarCabang.DataSource = listCabang;
                if (dataGridViewDaftarCabang.ColumnCount == 4)
                {
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "Aksi";
                    bcol.Text = "Ubah";
                    bcol.Name = "buttonUbah";
                    bcol.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarCabang.Columns.Add(bcol);

                    DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                    bcol2.HeaderText = "Aksi";
                    bcol2.Text = "Hapus";
                    bcol2.Name = "buttonHapus";
                    bcol2.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarCabang.Columns.Add(bcol2);
                }
            }
            else
            {
                dataGridViewDaftarCabang.DataSource = null;
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormPegawaiTambahCabang formPegawaiTambahCabang = new FormPegawaiTambahCabang();
            formPegawaiTambahCabang.Owner = this;
            formPegawaiTambahCabang.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxCari.Text == "ID Cabang")
            {
                listCabang = Cabang.ReadData("id", textBoxCari.Text);
            }
            else if (comboBoxCari.Text == "Nama Cabang")
            {
                listCabang = Cabang.ReadData("nama", textBoxCari.Text);
            }
            else if (comboBoxCari.Text == "Alamat Cabang")
            {
                listCabang = Cabang.ReadData("alamat", textBoxCari.Text);
            }
            else if (comboBoxCari.Text == "ID Pegawai")
            {
                listCabang = Cabang.ReadData("pegawais_id", textBoxCari.Text);
            }

            if (listCabang.Count > 0)
            {
                dataGridViewDaftarCabang.DataSource = listCabang;
            }
            else
            {
                dataGridViewDaftarCabang.DataSource = null;
            }
        }

        private void dataGridViewDaftarCabang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pId = dataGridViewDaftarCabang.CurrentRow.Cells["id"].Value.ToString();
            string pNama = dataGridViewDaftarCabang.CurrentRow.Cells["nama"].Value.ToString();
            string pAlamat = dataGridViewDaftarCabang.CurrentRow.Cells["alamat"].Value.ToString();
            string pIdPegawai = dataGridViewDaftarCabang.CurrentRow.Cells["pegawai"].Value.ToString();

            if (e.ColumnIndex == dataGridViewDaftarCabang.Columns["buttonHapus"].Index && e.RowIndex >= 0)
            {
                DialogResult hasil = MessageBox.Show(this, "Apakah anda yakin ingin menghapus " + pId + "-" + pNama + "-" + pAlamat + "-" + pIdPegawai + "?",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    Boolean hapus = Cabang.DeleteData(pId);
                    if (hapus == true)
                    {
                        MessageBox.Show("Berhasil hapus data", "Informasi");

                        FormPegawaiDaftarCabang_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Gagal hapus data", "Informasi");
                    }
                }
            }
            else
            {
                FormPegawaiUbahCabang form = new FormPegawaiUbahCabang();
                form.Owner = this;
                form.textBoxID.Text = pId;
                form.textBoxNama.Text = pNama;
                form.textBoxAlamat.Text = pAlamat;
                form.textBoxIdPegawai.Text = pIdPegawai;
                form.ShowDialog();
            }
        }
    }
}
