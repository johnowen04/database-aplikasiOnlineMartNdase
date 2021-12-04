
namespace OnlineMart_Ndase
{
    partial class FormPegawaiTambahBarangCabang
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
            this.panelTambahBarang = new System.Windows.Forms.Panel();
            this.comboBoxBarang = new System.Windows.Forms.ComboBox();
            this.textBoxStok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBersihkan = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTambahBarang.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTambahBarang
            // 
            this.panelTambahBarang.BackColor = System.Drawing.Color.SeaShell;
            this.panelTambahBarang.Controls.Add(this.textBoxHarga);
            this.panelTambahBarang.Controls.Add(this.label2);
            this.panelTambahBarang.Controls.Add(this.comboBoxBarang);
            this.panelTambahBarang.Controls.Add(this.textBoxStok);
            this.panelTambahBarang.Controls.Add(this.label4);
            this.panelTambahBarang.Controls.Add(this.label3);
            this.panelTambahBarang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTambahBarang.Location = new System.Drawing.Point(12, 48);
            this.panelTambahBarang.Name = "panelTambahBarang";
            this.panelTambahBarang.Size = new System.Drawing.Size(354, 128);
            this.panelTambahBarang.TabIndex = 10;
            // 
            // comboBoxBarang
            // 
            this.comboBoxBarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBarang.FormattingEnabled = true;
            this.comboBoxBarang.Location = new System.Drawing.Point(130, 20);
            this.comboBoxBarang.Name = "comboBoxBarang";
            this.comboBoxBarang.Size = new System.Drawing.Size(200, 24);
            this.comboBoxBarang.TabIndex = 10;
            this.comboBoxBarang.SelectedValueChanged += new System.EventHandler(this.comboBoxBarang_SelectedValueChanged);
            // 
            // textBoxStok
            // 
            this.textBoxStok.Location = new System.Drawing.Point(130, 84);
            this.textBoxStok.Name = "textBoxStok";
            this.textBoxStok.Size = new System.Drawing.Size(100, 23);
            this.textBoxStok.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stok :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nama Barang  :";
            // 
            // buttonBersihkan
            // 
            this.buttonBersihkan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBersihkan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBersihkan.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonBersihkan.Location = new System.Drawing.Point(118, 182);
            this.buttonBersihkan.Name = "buttonBersihkan";
            this.buttonBersihkan.Size = new System.Drawing.Size(100, 37);
            this.buttonBersihkan.TabIndex = 13;
            this.buttonBersihkan.Text = "&Bersihkan";
            this.buttonBersihkan.UseVisualStyleBackColor = false;
            this.buttonBersihkan.Click += new System.EventHandler(this.buttonBersihkan_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonTambah.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTambah.Location = new System.Drawing.Point(12, 182);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(100, 37);
            this.buttonTambah.TabIndex = 11;
            this.buttonTambah.Text = "&Tambah";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "     Tambah Barang Cabang";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonKeluar.Location = new System.Drawing.Point(266, 182);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(100, 37);
            this.buttonKeluar.TabIndex = 12;
            this.buttonKeluar.Text = "&Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Enabled = false;
            this.textBoxHarga.Location = new System.Drawing.Point(130, 52);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.ReadOnly = true;
            this.textBoxHarga.Size = new System.Drawing.Size(100, 23);
            this.textBoxHarga.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Harga :";
            // 
            // FormPegawaiTambahBarangCabang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 229);
            this.Controls.Add(this.panelTambahBarang);
            this.Controls.Add(this.buttonBersihkan);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Name = "FormPegawaiTambahBarangCabang";
            this.Text = "Tambah Barang Cabang";
            this.Load += new System.EventHandler(this.FormPegawaiTambahBarangCabang_Load);
            this.panelTambahBarang.ResumeLayout(false);
            this.panelTambahBarang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTambahBarang;
        private System.Windows.Forms.TextBox textBoxStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBersihkan;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxHarga;
        public System.Windows.Forms.ComboBox comboBoxBarang;
    }
}