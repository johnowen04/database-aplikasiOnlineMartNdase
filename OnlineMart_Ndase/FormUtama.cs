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
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.IsMdiContainer = true;

            FormMasuk form = new FormMasuk();
            form.MdiParent = this;
            form.Show();
        }

        private void keluarToolStripMenuItemKonsumen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void keluarToolStripMenuItemKurir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void keluarToolStripMenuItemPegawai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
