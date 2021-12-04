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
    public partial class FormPegawaiTambahCabang : Form
    {
        public List<Pegawai> listPegawai = new List<Pegawai>();
        public FormPegawaiTambahCabang()
        {
            InitializeComponent();
        }

        private void buttonBuat_Click(object sender, EventArgs e)
        {
            try
            {
                Pegawai p = (Pegawai)comboBoxPegawai.SelectedItem;

                Cabang c = new Cabang(int.Parse(textBoxID.Text), textBoxNama.Text, textBoxAlamat.Text, p);

                Cabang.CreateData(c);

                MessageBox.Show("Data Cabang telah tersimpan");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Penyimpanan gagal. Pesan Kesalahan : " + ex.Message, "Kesalahan");
            }
        }

        private void buttonBersihkan_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxNama.Text = "";
            textBoxAlamat.Text = "";
            comboBoxPegawai.Text = "";
            textBoxID.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            FormPegawaiDaftarCabang form = (FormPegawaiDaftarCabang)this.Owner;
            form.FormPegawaiDaftarCabang_Load(sender, e);

            this.Close();
        }

        private void FormPegawaiTambahCabang_Load(object sender, EventArgs e)
        {
            listPegawai = Pegawai.ReadData("", "");

            comboBoxPegawai.DataSource = listPegawai;
            comboBoxPegawai.DisplayMember = "nama";
        }
    }
}
