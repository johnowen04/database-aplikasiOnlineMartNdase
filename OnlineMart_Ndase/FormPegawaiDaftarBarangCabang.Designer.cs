
namespace OnlineMart_Ndase
{
    partial class FormPegawaiDaftarBarangCabang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewDaftarBarangCabang = new System.Windows.Forms.DataGridView();
            this.panelDaftarBarang = new System.Windows.Forms.Panel();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.comboBoxCari = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarBarangCabang)).BeginInit();
            this.panelDaftarBarang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDaftarBarangCabang
            // 
            this.dataGridViewDaftarBarangCabang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarBarangCabang.Location = new System.Drawing.Point(12, 111);
            this.dataGridViewDaftarBarangCabang.Name = "dataGridViewDaftarBarangCabang";
            this.dataGridViewDaftarBarangCabang.RowHeadersWidth = 62;
            this.dataGridViewDaftarBarangCabang.Size = new System.Drawing.Size(535, 200);
            this.dataGridViewDaftarBarangCabang.TabIndex = 8;
            this.dataGridViewDaftarBarangCabang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaftarBarangCabang_CellContentClick);
            // 
            // panelDaftarBarang
            // 
            this.panelDaftarBarang.BackColor = System.Drawing.Color.SeaShell;
            this.panelDaftarBarang.Controls.Add(this.textBoxCari);
            this.panelDaftarBarang.Controls.Add(this.comboBoxCari);
            this.panelDaftarBarang.Controls.Add(this.label2);
            this.panelDaftarBarang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDaftarBarang.Location = new System.Drawing.Point(12, 48);
            this.panelDaftarBarang.Name = "panelDaftarBarang";
            this.panelDaftarBarang.Size = new System.Drawing.Size(535, 57);
            this.panelDaftarBarang.TabIndex = 7;
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(305, 16);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(200, 23);
            this.textBoxCari.TabIndex = 2;
            // 
            // comboBoxCari
            // 
            this.comboBoxCari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCari.FormattingEnabled = true;
            this.comboBoxCari.Items.AddRange(new object[] {
            "ID Barang",
            "Nama Barang",
            "Harga Barang",
            "Nama Kategori"});
            this.comboBoxCari.Location = new System.Drawing.Point(149, 16);
            this.comboBoxCari.Name = "comboBoxCari";
            this.comboBoxCari.Size = new System.Drawing.Size(150, 24);
            this.comboBoxCari.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cari berdasarkan :";
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonTambah.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTambah.Location = new System.Drawing.Point(341, 317);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(100, 37);
            this.buttonTambah.TabIndex = 10;
            this.buttonTambah.Text = "&Tambah";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonKeluar.Location = new System.Drawing.Point(447, 317);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(100, 37);
            this.buttonKeluar.TabIndex = 9;
            this.buttonKeluar.Text = "&Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.OrangeRed;
            this.labelTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTitle.Location = new System.Drawing.Point(12, 8);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(535, 37);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "     Daftar Barang";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormPegawaiDaftarBarangCabang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 363);
            this.Controls.Add(this.dataGridViewDaftarBarangCabang);
            this.Controls.Add(this.panelDaftarBarang);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormPegawaiDaftarBarangCabang";
            this.Text = "Daftar Barang";
            this.Load += new System.EventHandler(this.FormPegawaiDaftarBarangCabang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarBarangCabang)).EndInit();
            this.panelDaftarBarang.ResumeLayout(false);
            this.panelDaftarBarang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDaftarBarangCabang;
        private System.Windows.Forms.Panel panelDaftarBarang;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.ComboBox comboBoxCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonKeluar;
        public System.Windows.Forms.Label labelTitle;
    }
}