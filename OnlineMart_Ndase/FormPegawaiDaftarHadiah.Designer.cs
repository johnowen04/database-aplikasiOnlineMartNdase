
namespace OnlineMart_Ndase
{
    partial class FormPegawaiDaftarHadiah
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
            this.dataGridViewDaftarHadiah = new System.Windows.Forms.DataGridView();
            this.panelDaftarHadiah = new System.Windows.Forms.Panel();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.comboBoxCari = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarHadiah)).BeginInit();
            this.panelDaftarHadiah.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDaftarHadiah
            // 
            this.dataGridViewDaftarHadiah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarHadiah.Location = new System.Drawing.Point(14, 168);
            this.dataGridViewDaftarHadiah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewDaftarHadiah.Name = "dataGridViewDaftarHadiah";
            this.dataGridViewDaftarHadiah.RowHeadersWidth = 62;
            this.dataGridViewDaftarHadiah.Size = new System.Drawing.Size(802, 308);
            this.dataGridViewDaftarHadiah.TabIndex = 8;
            this.dataGridViewDaftarHadiah.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaftarHadiah_CellContentClick);
            // 
            // panelDaftarHadiah
            // 
            this.panelDaftarHadiah.BackColor = System.Drawing.Color.SeaShell;
            this.panelDaftarHadiah.Controls.Add(this.textBoxCari);
            this.panelDaftarHadiah.Controls.Add(this.comboBoxCari);
            this.panelDaftarHadiah.Controls.Add(this.label2);
            this.panelDaftarHadiah.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDaftarHadiah.Location = new System.Drawing.Point(14, 69);
            this.panelDaftarHadiah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDaftarHadiah.Name = "panelDaftarHadiah";
            this.panelDaftarHadiah.Size = new System.Drawing.Size(802, 88);
            this.panelDaftarHadiah.TabIndex = 7;
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(458, 25);
            this.textBoxCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(298, 31);
            this.textBoxCari.TabIndex = 2;
            this.textBoxCari.TextChanged += new System.EventHandler(this.textBoxCari_TextChanged);
            // 
            // comboBoxCari
            // 
            this.comboBoxCari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCari.FormattingEnabled = true;
            this.comboBoxCari.Items.AddRange(new object[] {
            "ID Hadiah",
            "Nama Hadiah",
            "Jumlah Poin"});
            this.comboBoxCari.Location = new System.Drawing.Point(224, 25);
            this.comboBoxCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxCari.Name = "comboBoxCari";
            this.comboBoxCari.Size = new System.Drawing.Size(223, 32);
            this.comboBoxCari.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cari berdasarkan :";
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonTambah.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTambah.Location = new System.Drawing.Point(507, 485);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(150, 57);
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
            this.buttonKeluar.Location = new System.Drawing.Point(664, 485);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(150, 57);
            this.buttonKeluar.TabIndex = 9;
            this.buttonKeluar.Text = "&Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(802, 57);
            this.label1.TabIndex = 6;
            this.label1.Text = "     Daftar Hadiah";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormPegawaiDaftarHadiah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 551);
            this.Controls.Add(this.dataGridViewDaftarHadiah);
            this.Controls.Add(this.panelDaftarHadiah);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.label1);
            this.Name = "FormPegawaiDaftarHadiah";
            this.Text = "Daftar Hadiah";
            this.Load += new System.EventHandler(this.FormPegawaiDaftarHadiah_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarHadiah)).EndInit();
            this.panelDaftarHadiah.ResumeLayout(false);
            this.panelDaftarHadiah.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDaftarHadiah;
        private System.Windows.Forms.Panel panelDaftarHadiah;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.ComboBox comboBoxCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Label label1;
    }
}