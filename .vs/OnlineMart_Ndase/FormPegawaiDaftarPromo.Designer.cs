﻿
namespace OnlineMart_Ndase
{
    partial class FormPegawaiDaftarPromo
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
            this.comboBoxCari = new System.Windows.Forms.ComboBox();
            this.dataGridViewDaftarPromo = new System.Windows.Forms.DataGridView();
            this.panelDaftarPromo = new System.Windows.Forms.Panel();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarPromo)).BeginInit();
            this.panelDaftarPromo.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCari
            // 
            this.comboBoxCari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCari.FormattingEnabled = true;
            this.comboBoxCari.Location = new System.Drawing.Point(149, 16);
            this.comboBoxCari.Name = "comboBoxCari";
            this.comboBoxCari.Size = new System.Drawing.Size(150, 24);
            this.comboBoxCari.TabIndex = 1;
            // 
            // dataGridViewDaftarPromo
            // 
            this.dataGridViewDaftarPromo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarPromo.Location = new System.Drawing.Point(9, 108);
            this.dataGridViewDaftarPromo.Name = "dataGridViewDaftarPromo";
            this.dataGridViewDaftarPromo.RowHeadersWidth = 62;
            this.dataGridViewDaftarPromo.Size = new System.Drawing.Size(535, 200);
            this.dataGridViewDaftarPromo.TabIndex = 7;
            // 
            // panelDaftarPromo
            // 
            this.panelDaftarPromo.BackColor = System.Drawing.Color.SeaShell;
            this.panelDaftarPromo.Controls.Add(this.textBoxCari);
            this.panelDaftarPromo.Controls.Add(this.comboBoxCari);
            this.panelDaftarPromo.Controls.Add(this.label2);
            this.panelDaftarPromo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDaftarPromo.Location = new System.Drawing.Point(9, 45);
            this.panelDaftarPromo.Name = "panelDaftarPromo";
            this.panelDaftarPromo.Size = new System.Drawing.Size(535, 57);
            this.panelDaftarPromo.TabIndex = 6;
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(305, 16);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(200, 23);
            this.textBoxCari.TabIndex = 2;
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
            this.buttonTambah.Location = new System.Drawing.Point(338, 314);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(100, 37);
            this.buttonTambah.TabIndex = 8;
            this.buttonTambah.Text = "&Tambah";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonKeluar.Location = new System.Drawing.Point(443, 314);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(100, 37);
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
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "     Daftar Promo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormPegawaiDaftarPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 360);
            this.Controls.Add(this.dataGridViewDaftarPromo);
            this.Controls.Add(this.panelDaftarPromo);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPegawaiDaftarPromo";
            this.Text = "Daftar Promo";
            this.Load += new System.EventHandler(this.FormPegawaiDaftarPromo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarPromo)).EndInit();
            this.panelDaftarPromo.ResumeLayout(false);
            this.panelDaftarPromo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCari;
        private System.Windows.Forms.DataGridView dataGridViewDaftarPromo;
        private System.Windows.Forms.Panel panelDaftarPromo;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Label label1;
    }
}