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
    public partial class FormKonsumenKodePromo : Form
    {
        public FormKonsumenKodePromo()
        {
            InitializeComponent();
        }

        private void buttonBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMasukkan_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi k = new Koneksi();

                Promo p = Promo.CekPromo(int.Parse(textBoxID.Text));

                if (!(p is null))
                {
                    FormKonsumenCheckout form = (FormKonsumenCheckout)this.Owner;
                    form.linkLabelKodePromo.Text = p.Id.ToString();
                    //form.linkLabelKodePromo.TextAlign = ContentAlignment.MiddleRight;
                    form.promo = p;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kode promo tidak valid");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan. \nPesan kesalahan : " + ex.Message, "Informasi");
            }
        }

        private void buttonBersihkan_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxID.Focus();
        }
    }
}
