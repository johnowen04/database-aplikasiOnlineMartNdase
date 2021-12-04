
namespace OnlineMart_Ndase
{
    partial class FormPegawaiTambahKategori
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
            this.panelTambahKategori = new System.Windows.Forms.Panel();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonBersihkan = new System.Windows.Forms.Button();
            this.panelTambahKategori.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTambahKategori
            // 
            this.panelTambahKategori.BackColor = System.Drawing.Color.SeaShell;
            this.panelTambahKategori.Controls.Add(this.textBoxNama);
            this.panelTambahKategori.Controls.Add(this.label6);
            this.panelTambahKategori.Controls.Add(this.textBoxID);
            this.panelTambahKategori.Controls.Add(this.label2);
            this.panelTambahKategori.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTambahKategori.Location = new System.Drawing.Point(12, 49);
            this.panelTambahKategori.Name = "panelTambahKategori";
            this.panelTambahKategori.Size = new System.Drawing.Size(335, 89);
            this.panelTambahKategori.TabIndex = 1;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(115, 48);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(200, 23);
            this.textBoxNama.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nama :";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(115, 19);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 23);
            this.textBoxID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID :";
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonTambah.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTambah.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonTambah.Location = new System.Drawing.Point(12, 144);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(100, 37);
            this.buttonTambah.TabIndex = 2;
            this.buttonTambah.Text = "&Tambah";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "     Tambah Kategori";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonKeluar.Location = new System.Drawing.Point(247, 144);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(100, 37);
            this.buttonKeluar.TabIndex = 4;
            this.buttonKeluar.Text = "&Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonBersihkan
            // 
            this.buttonBersihkan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBersihkan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBersihkan.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonBersihkan.Location = new System.Drawing.Point(118, 144);
            this.buttonBersihkan.Name = "buttonBersihkan";
            this.buttonBersihkan.Size = new System.Drawing.Size(100, 37);
            this.buttonBersihkan.TabIndex = 4;
            this.buttonBersihkan.Text = "&Bersihkan";
            this.buttonBersihkan.UseVisualStyleBackColor = false;
            this.buttonBersihkan.Click += new System.EventHandler(this.buttonBersihkan_Click);
            // 
            // FormPegawaiTambahKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 191);
            this.Controls.Add(this.buttonBersihkan);
            this.Controls.Add(this.panelTambahKategori);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Name = "FormPegawaiTambahKategori";
            this.Text = "Tambah Kategori";
            this.panelTambahKategori.ResumeLayout(false);
            this.panelTambahKategori.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTambahKategori;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonBersihkan;
    }
}