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
    public partial class FormPegawaiDaftarKategori : Form
    {
        public List<Kategori> listKategori = new List<Kategori>();

        public FormPegawaiDaftarKategori()
        {
            InitializeComponent();
        }

        public void FormPegawaiDaftarKategori_Load(object sender, EventArgs e)
        {
            listKategori = Kategori.ReadData("", textBoxCari.Text);

            if(listKategori.Count >0)
            {
                dataGridViewDaftarKategori.DataSource = listKategori;
                if(dataGridViewDaftarKategori.ColumnCount == 2)
                {
                    DataGridViewButtonColumn bcol = new DataGridViewButtonColumn();
                    bcol.HeaderText = "Aksi";
                    bcol.Text = "Ubah";
                    bcol.Name = "buttonUbah";
                    bcol.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarKategori.Columns.Add(bcol);

                    DataGridViewButtonColumn bcol2 = new DataGridViewButtonColumn();
                    bcol2.HeaderText = "Aksi";
                    bcol2.Text = "Hapus";
                    bcol2.Name = "buttonHapus";
                    bcol2.UseColumnTextForButtonValue = true;
                    dataGridViewDaftarKategori.Columns.Add(bcol2);
                }
            }
            else
            {
                dataGridViewDaftarKategori.DataSource = null;
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormPegawaiTambahKategori formPegawaiTambahKategori = new FormPegawaiTambahKategori();
            formPegawaiTambahKategori.Owner = this;
            formPegawaiTambahKategori.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxCari.Text == "ID Kategori")
            {
                listKategori = Kategori.ReadData("id", textBoxCari.Text);
            }
            else if (comboBoxCari.Text == "Nama Kategori")
            {
                listKategori = Kategori.ReadData("nama", textBoxCari.Text);
            }

            if (listKategori.Count > 0)
            {
                dataGridViewDaftarKategori.DataSource = listKategori;
            }
            else
            {
                dataGridViewDaftarKategori.DataSource = null;
            }
        }

        private void dataGridViewDaftarKategori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pId = dataGridViewDaftarKategori.CurrentRow.Cells["id"].Value.ToString();
            string pNama = dataGridViewDaftarKategori.CurrentRow.Cells["nama"].Value.ToString();

            if (e.ColumnIndex == dataGridViewDaftarKategori.Columns["buttonHapus"].Index && e.RowIndex >= 0)
            {
                DialogResult hasil = MessageBox.Show(this, "Apakah anda yakin ingin menghapus " + pId + "-" + pNama + "?",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    Boolean hapus = Kategori.DeleteData(pId);
                    if (hapus == true)
                    {
                        MessageBox.Show("Berhasil hapus data", "Informasi");

                        FormPegawaiDaftarKategori_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Gagal hapus data", "Informasi");
                    }
                }
            }
            else
            {
                FormPegawaiUbahKategori form = new FormPegawaiUbahKategori();
                form.Owner = this;
                form.textBoxID.Text = pId;
                form.textBoxNama.Text = pNama;
                form.ShowDialog();
            }
        }
    }
}
