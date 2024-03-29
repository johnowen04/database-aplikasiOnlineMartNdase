﻿using System;
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
    public partial class FormPegawaiDaftarHadiah : Form
    {
        private List<Hadiah> listHadiah = new List<Hadiah>();

        public FormPegawaiDaftarHadiah()
        {
            InitializeComponent();
        }

        private void FormatDataGrid()
        {
            dataGridViewDaftarHadiah.Columns.Clear();

            dataGridViewDaftarHadiah.Columns.Add("Id", "Id Promo");
            dataGridViewDaftarHadiah.Columns.Add("Nama", "Nama Promo");
            dataGridViewDaftarHadiah.Columns.Add("JumlahPoin", "Jumlah Poin");

            DataGridViewButtonColumn buttonColumnUbah = new DataGridViewButtonColumn();
            buttonColumnUbah.HeaderText = "Aksi";
            buttonColumnUbah.Text = "Ubah";
            buttonColumnUbah.Name = "btnUbahGrid";
            buttonColumnUbah.UseColumnTextForButtonValue = true;
            dataGridViewDaftarHadiah.Columns.Add(buttonColumnUbah);

            DataGridViewButtonColumn buttonColumnHapus = new DataGridViewButtonColumn();
            buttonColumnHapus.HeaderText = "Aksi";
            buttonColumnHapus.Text = "Hapus";
            buttonColumnHapus.Name = "btnHapusGrid";
            buttonColumnHapus.UseColumnTextForButtonValue = true;
            dataGridViewDaftarHadiah.Columns.Add(buttonColumnHapus);

            dataGridViewDaftarHadiah.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarHadiah.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewDaftarHadiah.Columns["JumlahPoin"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewDaftarHadiah.Columns["JumlahPoin"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewDaftarHadiah.Columns["JumlahPoin"].DefaultCellStyle.Format = "####";

            dataGridViewDaftarHadiah.AllowUserToAddRows = false;
            dataGridViewDaftarHadiah.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewDaftarHadiah.Rows.Clear();

            if (listHadiah.Count > 0)
            {
                foreach (Hadiah h in listHadiah)
                {
                    dataGridViewDaftarHadiah.Rows.Add(h.Id, h.Nama, h.JumlahPoin);
                }
            }
            else
            {
                dataGridViewDaftarHadiah.DataSource = null;
            }
        }

        public void FormPegawaiDaftarHadiah_Load(object sender, EventArgs e)
        {
            FormatDataGrid();
            listHadiah = Hadiah.ReadData("", "");
            TampilDataGrid();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormPegawaiTambahHadiah formPegawaiTambahHadiah = new FormPegawaiTambahHadiah();
            formPegawaiTambahHadiah.Owner = this;
            formPegawaiTambahHadiah.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e) => this.Close();

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string kriteria = "";

            switch (comboBoxCari.Text)
            {
                case "ID Hadiah":
                    kriteria = "id";
                    break;
                case "Nama Hadiah":
                    kriteria = "nama";
                    break;
                case "Jumlah Poin":
                    kriteria = "jumlah_poin";
                    break;
            }

            listHadiah = Hadiah.ReadData(kriteria, textBoxCari.Text);

            TampilDataGrid();
        }

        private void dataGridViewDaftarHadiah_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pId = dataGridViewDaftarHadiah.CurrentRow.Cells["id"].Value.ToString();
            string pNama = dataGridViewDaftarHadiah.CurrentRow.Cells["nama"].Value.ToString();
            string pPoin = dataGridViewDaftarHadiah.CurrentRow.Cells["JumlahPoin"].Value.ToString();

            if (e.ColumnIndex == dataGridViewDaftarHadiah.Columns["btnHapusGrid"].Index && e.RowIndex >= 0)
            {
                DialogResult hasil = MessageBox.Show(this, "Apakah anda yakin ingin menghapus " + pId + "-" + pNama + "?",
                    "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (hasil == DialogResult.Yes)
                {
                    Boolean hapus = Hadiah.DeleteData(pId);
                    if (hapus == true)
                    {
                        MessageBox.Show("Berhasil hapus data", "Informasi");

                        FormPegawaiDaftarHadiah_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Gagal hapus data", "Informasi");
                    }
                }
            }
            else
            {
                FormPegawaiUbahHadiah form = new FormPegawaiUbahHadiah();
                form.Owner = this;
                form.textBoxID.Text = pId;
                form.textBoxNama.Text = pNama;
                form.textBoxJumlahPoin.Text = pPoin;
                form.ShowDialog();
                FormPegawaiDaftarHadiah_Load(sender, e);
            }
        }
    }
}
