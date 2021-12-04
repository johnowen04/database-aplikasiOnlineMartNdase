
namespace OnlineMart_Ndase
{
    partial class FormPegawaiUbahKategori
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
            this.panelUbahKategori = new System.Windows.Forms.Panel();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUbah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonBersihkan = new System.Windows.Forms.Button();
            this.panelUbahKategori.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUbahKategori
            // 
            this.panelUbahKategori.BackColor = System.Drawing.Color.SeaShell;
            this.panelUbahKategori.Controls.Add(this.textBoxNama);
            this.panelUbahKategori.Controls.Add(this.label6);
            this.panelUbahKategori.Controls.Add(this.textBoxID);
            this.panelUbahKategori.Controls.Add(this.label2);
            this.panelUbahKategori.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelUbahKategori.Location = new System.Drawing.Point(18, 75);
            this.panelUbahKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelUbahKategori.Name = "panelUbahKategori";
            this.panelUbahKategori.Size = new System.Drawing.Size(502, 137);
            this.panelUbahKategori.TabIndex = 1;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(172, 74);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(298, 31);
            this.textBoxNama.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nama :";
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(172, 29);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(148, 31);
            this.textBoxID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID :";
            // 
            // buttonUbah
            // 
            this.buttonUbah.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonUbah.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUbah.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonUbah.Location = new System.Drawing.Point(18, 222);
            this.buttonUbah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(150, 57);
            this.buttonUbah.TabIndex = 2;
            this.buttonUbah.Text = "&Ubah";
            this.buttonUbah.UseVisualStyleBackColor = false;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "     Ubah Kategori";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonKeluar.Location = new System.Drawing.Point(370, 222);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(150, 57);
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
            this.buttonBersihkan.Location = new System.Drawing.Point(177, 222);
            this.buttonBersihkan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBersihkan.Name = "buttonBersihkan";
            this.buttonBersihkan.Size = new System.Drawing.Size(150, 57);
            this.buttonBersihkan.TabIndex = 4;
            this.buttonBersihkan.Text = "&Bersihkan";
            this.buttonBersihkan.UseVisualStyleBackColor = false;
            this.buttonBersihkan.Click += new System.EventHandler(this.buttonBersihkan_Click);
            // 
            // FormPegawaiUbahKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 295);
            this.Controls.Add(this.buttonBersihkan);
            this.Controls.Add(this.panelUbahKategori);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPegawaiUbahKategori";
            this.Text = "Ubah Kategori";
            this.Load += new System.EventHandler(this.FormPegawaiUbahKategori_Load);
            this.panelUbahKategori.ResumeLayout(false);
            this.panelUbahKategori.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUbahKategori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Button buttonBersihkan;
        public System.Windows.Forms.TextBox textBoxNama;
        public System.Windows.Forms.TextBox textBoxID;
    }
}