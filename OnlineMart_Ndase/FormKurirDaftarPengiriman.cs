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
    public partial class FormKurirDaftarPengiriman : Form
    {
        public FormKurirDaftarPengiriman()
        {
            InitializeComponent();
        }

        private void FormKurirDaftarPengiriman_Load(object sender, EventArgs e)
        {
            // Select data from DB
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
