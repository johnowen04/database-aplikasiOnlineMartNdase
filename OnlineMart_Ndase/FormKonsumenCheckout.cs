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
    public partial class FormKonsumenCheckout : Form
    {
        FormUtama formUtama;
        FormKonsumenKeranjang formKonsumenKeranjang;
        public Promo promo;
        private float potonganHarga = 0.0f;
        private float totalBelanja = 0.0f;
        private float totalBayar = 0.0f;
        private float ongkosKirim = 20000f;

        public FormKonsumenCheckout()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e) => this.Close();

        private void linkLabelKodePromo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormKonsumenKodePromo formKonsumenKodePromo = new FormKonsumenKodePromo();
            formKonsumenKodePromo.Owner = this;
            if (linkLabelKodePromo.Text != "Masukkan kode promo")
                formKonsumenKodePromo.textBoxID.Text = linkLabelKodePromo.Text;
            formKonsumenKodePromo.ShowDialog();
            FormKonsumenCheckout_Load(sender, e);
        }

        private void FormKonsumenCheckout_Load(object sender, EventArgs e)
        {
            formKonsumenKeranjang = (FormKonsumenKeranjang)this.Owner;
            formUtama = (FormUtama)formKonsumenKeranjang.MdiParent;

            //comboBoxMetodePembayaran.Items.Clear();
            comboBoxMetodePembayaran.DataSource = MetodePembayaran.ReadData();
            comboBoxMetodePembayaran.DisplayMember = "Nama";
            comboBoxMetodePembayaran.DropDownStyle = ComboBoxStyle.DropDownList;

            FormatDataGrid();
            TampilDataGrid();

            totalBelanja = HitungTotalBelanja(formKonsumenKeranjang.formUtama.ko.ListKeranjangBarang);
            potonganHarga = HitungPotonganHarga(totalBelanja, promo);
            totalBayar = totalBelanja - potonganHarga + ongkosKirim;

            labelOngkosKirim.Text = "Rp" + ongkosKirim.ToString();
            labelPotonganHarga.Text = "- Rp" + potonganHarga.ToString();
            labelTotalPembayaran.Text = "Rp" + totalBayar.ToString();
        }
        
        private void FormatDataGrid()
        {
            dataGridViewBarang.Columns.Clear();

            dataGridViewBarang.Columns.Add("Nama", "Nama Barang");
            dataGridViewBarang.Columns.Add("Harga", "Harga Barang");
            dataGridViewBarang.Columns.Add("Kategori", "Kategori");
            dataGridViewBarang.Columns.Add("Cabang", "Cabang");
            dataGridViewBarang.Columns.Add("Quantity", "Qty");

            dataGridViewBarang.Columns["Nama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["Harga"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["Kategori"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["Cabang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewBarang.Columns["Quantity"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridViewBarang.Columns["Harga"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewBarang.Columns["Harga"].DefaultCellStyle.Format = "#,###";

            dataGridViewBarang.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewBarang.Columns["Quantity"].DefaultCellStyle.Format = "##";

            dataGridViewBarang.AllowUserToAddRows = false;
            dataGridViewBarang.ReadOnly = true;
        }

        private void TampilDataGrid()
        {
            dataGridViewBarang.Rows.Clear();

            if (formKonsumenKeranjang.formUtama.ko.ListKeranjangBarang.Count > 0)
            {
                foreach (KeranjangBarang kb in formKonsumenKeranjang.formUtama.ko.ListKeranjangBarang)
                {
                    dataGridViewBarang.Rows.Add(kb.Barang.Nama, kb.Barang.Harga,
                        kb.Barang.Kategori.Nama, formUtama.cabang.Nama, kb.Quantity);
                }
            }
            else
            {
                dataGridViewBarang.DataSource = null;
            }
        }

        private float HitungPotonganHarga(float tb, Promo promo)
        {
            float potonganHarga = 0.0f;

            if (promo != null)
            {
                if (tb >= promo.MinBelanja)
                {
                    potonganHarga = tb * promo.Diskon;

                    if (potonganHarga <= promo.MaxDiskon)
                        return potonganHarga;
                    else
                        return promo.MaxDiskon;
                }

                switch (promo.Tipe)
                {
                    case "Potongan Harga":
                        break;
                    case "Cashback":
                        break;
                    case "Potongan Ongkir":
                        break;
                }
            }

            return potonganHarga;
        }

        private float HitungTotalBelanja(List<KeranjangBarang> listKeranjangBarang)
        {
            float totalBelanja = 0.0f;

            if (listKeranjangBarang.Count > 0)
            {
                foreach (KeranjangBarang kb in listKeranjangBarang)
                {
                    totalBelanja += (float.Parse(kb.Barang.Harga) * kb.Quantity);
                }
            }

            return totalBelanja;
        }

        private void comboBoxMetodePembayaran_SelectedValueChanged(object sender, EventArgs e)
        {
            buttonBayar.Enabled = false;

            if (comboBoxKurir.Text == "OMA Delivery" && comboBoxMetodePembayaran.Text == "OMA Payment")
                buttonBayar.Enabled = true;
        }

        private void buttonBayar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxAlamat.Text == "")
                {
                    throw new ArgumentException("Alamat tidak boleh kosong. Nggak punya rumah ya???");
                }

                if (formKonsumenKeranjang.formUtama.ko.Saldo >= totalBayar)
                {
                    DialogResult checkCheckout = MessageBox.Show("Anda yakin ingin checkout barang yang ada di keranjang?",
                        "Konfirmasi", MessageBoxButtons.YesNo);

                    if (checkCheckout == DialogResult.Yes)
                    {
                        Random random = new Random();
                        MetodePembayaran metodePembayaran = (MetodePembayaran)comboBoxMetodePembayaran.SelectedItem;
                        Kurir kurir = new Kurir
                        {
                            Id = random.Next(1, 5)
                        };

                        Order order = new Order(Order.GenerateNoNota(), DateTime.Now, textBoxAlamat.Text,
                            ongkosKirim, totalBayar, formUtama.cabang, kurir, formUtama.ko, promo, "Pesanan diproses", metodePembayaran);

                        if (Order.CreateData(order))
                            if (Konsumen.UpdateSaldo("checkout", formUtama.ko.Id, totalBayar))
                                MessageBox.Show("Proses checkout berhasil.", "Informasi");
                            else
                                MessageBox.Show("Checkout gagal.", "Kesalahan");
                    }
                }

                else
                {
                    MessageBox.Show("Saldo tidak cukup");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan. \nPesan kesalahan : " + ex.Message, "Informasi");
            }
        }
    }
}
