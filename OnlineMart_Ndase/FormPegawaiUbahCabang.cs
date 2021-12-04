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
    public partial class FormPegawaiUbahCabang : Form
    {
        public FormPegawaiUbahCabang()
        {
            InitializeComponent();
        }

        private void FormPegawaiUbahCabang_Load(object sender, EventArgs e)
        {
            try
            {
                textBoxID.Enabled = false;

                List<Pegawai> listPegawai = Pegawai.ReadData("", "");
                comboBoxPegawai.DataSource = listPegawai;
                comboBoxPegawai.DisplayMember = "Nama";

                List<Cabang> listCabang = Cabang.ReadData("c.id", textBoxID.Text);
                Pegawai p;

                if (listCabang.Count > 0)
                    p = listCabang[0].Pegawai;
                else
                    throw new ArgumentException("Cabang tidak ditemukan.");

                int idx = 0;
                foreach (Pegawai pegawai in listPegawai)
                {
                    if (pegawai.Id == p.Id)
                    {
                        idx = listPegawai.IndexOf(pegawai);
                    }
                }

                comboBoxPegawai.SelectedIndex = idx;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kesalahan");
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Pegawai p = (Pegawai)comboBoxPegawai.SelectedItem;
                Cabang c = new Cabang(int.Parse(textBoxID.Text), textBoxNama.Text, textBoxAlamat.Text, p);

                Boolean hasil = Cabang.UpdateData(c);

                if (hasil)
                {
                    MessageBox.Show("Berhasil mengubah data Cabang.", "Informasi");
                }
                else
                {
                    MessageBox.Show("Ubah data gagal.", "Kesalahan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data Cabang. \nPesan kesalahan : " + ex.Message, "Informasi");
            }
        }

        private void buttonBersihkan_Click(object sender, EventArgs e)
        {
            textBoxNama.Text = "";
            textBoxAlamat.Text = "";
            comboBoxPegawai.Text = "";
            textBoxNama.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormPegawaiDaftarCabang form = (FormPegawaiDaftarCabang)this.Owner;
            form.FormPegawaiDaftarCabang_Load(sender, e);

            this.Close();
        }
    }
}
