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
            textBoxID.Enabled = false;
            // Select data from DB
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                //Pegawai p = (Pegawai)textBoxIdPegawai.;
                //Cabang c = new Cabang(int.Parse(textBoxID.Text), textBoxNama.Text, textBoxAlamat.Text, int.Parse(textBoxIdPegawai.Text));

                //Cabang.UpdateData(c);

                MessageBox.Show("Berhasil mengubah data Cabang.", "Informasi");
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
            textBoxIdPegawai.Text = "";
            textBoxNama.Focus();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            // Need more implementation
            this.Close();
        }
    }
}
