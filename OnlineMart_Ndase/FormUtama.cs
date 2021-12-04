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

            FormMasuk formMasuk = new FormMasuk();
            formMasuk.MdiParent = this;
            formMasuk.Show();
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

        private void riwayatTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormKonsumenRiwayatTransaksi"];

            if (form == null)
            {
                FormKonsumenRiwayatTransaksi formKonsumenRiwayatTransaksi = new FormKonsumenRiwayatTransaksi();
                formKonsumenRiwayatTransaksi.MdiParent = this;
                formKonsumenRiwayatTransaksi.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void isiSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormKonsumenIsiSaldo"];

            if (form == null)
            {
                FormKonsumenIsiSaldo formKonsumenIsiSaldo = new FormKonsumenIsiSaldo();
                formKonsumenIsiSaldo.MdiParent = this;
                formKonsumenIsiSaldo.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormKonsumenProfil"];

            if (form == null)
            {
                FormKonsumenProfil formKonsumenProfil = new FormKonsumenProfil();
                formKonsumenProfil.MdiParent = this;
                formKonsumenProfil.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormPegawaiDaftarBarang"];

            if (form == null)
            {
                FormPegawaiDaftarBarang formPegawaiDaftarBarang = new FormPegawaiDaftarBarang();
                formPegawaiDaftarBarang.MdiParent = this;
                formPegawaiDaftarBarang.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void cabangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormPegawaiDaftarCabang"];

            if (form == null)
            {
                FormPegawaiDaftarCabang formPegawaiDaftarCabang = new FormPegawaiDaftarCabang();
                formPegawaiDaftarCabang.MdiParent = this;
                formPegawaiDaftarCabang.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void hadiahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormPegawaiDaftarHadiah"];

            if (form == null)
            {
                FormPegawaiDaftarHadiah formPegawaiDaftarHadiah = new FormPegawaiDaftarHadiah();
                formPegawaiDaftarHadiah.MdiParent = this;
                formPegawaiDaftarHadiah.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormPegawaiDaftarKategori"];

            if (form == null)
            {
                FormPegawaiDaftarKategori formPegawaiDaftarKategori = new FormPegawaiDaftarKategori();
                formPegawaiDaftarKategori.MdiParent = this;
                formPegawaiDaftarKategori.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void metodePembayaranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormPegawaiDaftarMetodePembayaran"];

            if (form == null)
            {
                FormPegawaiDaftarMetodePembayaran formPegawaiDaftarMetodePembayaran = new FormPegawaiDaftarMetodePembayaran();
                formPegawaiDaftarMetodePembayaran.MdiParent = this;
                formPegawaiDaftarMetodePembayaran.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void promoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormPegawaiDaftarPromo"];

            if (form == null)
            {
                FormPegawaiDaftarPromo formPegawaiDaftarPromo = new FormPegawaiDaftarPromo();
                formPegawaiDaftarPromo.MdiParent = this;
                formPegawaiDaftarPromo.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void penjualanBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormPegawaiRekapPenjualanBarang"];

            if (form == null)
            {
                FormPegawaiRekapPenjualanBarang formPegawaiRekapPenjualanBarang = new FormPegawaiRekapPenjualanBarang();
                formPegawaiRekapPenjualanBarang.MdiParent = this;
                formPegawaiRekapPenjualanBarang.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void penjualanOMASaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormPegawaiRekapPenjualanOMASaldo"];

            if (form == null)
            {
                FormPegawaiRekapPenjualanOMASaldo formPegawaiRekapPenjualanOMASaldo = new FormPegawaiRekapPenjualanOMASaldo();
                formPegawaiRekapPenjualanOMASaldo.MdiParent = this;
                formPegawaiRekapPenjualanOMASaldo.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void daftarPengirimanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormKurirDaftarPengiriman"];

            if (form == null)
            {
                FormKurirDaftarPengiriman formKurirDaftarPengiriman = new FormKurirDaftarPengiriman();
                formKurirDaftarPengiriman.MdiParent = this;
                formKurirDaftarPengiriman.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }

        private void rekapPendapatanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormKurirRekapPendapatan"];

            if (form == null)
            {
                FormKurirRekapPendapatan formKurirRekapPendapatan = new FormKurirRekapPendapatan();
                formKurirRekapPendapatan.MdiParent = this;
                formKurirRekapPendapatan.Show();
            }
            else
            {
                form.Show();
                form.BringToFront();
            }
        }
    }
}
