﻿
namespace OnlineMart_Ndase
{
    partial class FormKonsumenBarang
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
            this.dataGridViewBarang = new System.Windows.Forms.DataGridView();
            this.panelDaftarBarang = new System.Windows.Forms.Panel();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.comboBoxCari = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).BeginInit();
            this.panelDaftarBarang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBarang
            // 
            this.dataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBarang.Location = new System.Drawing.Point(13, 167);
            this.dataGridViewBarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewBarang.Name = "dataGridViewBarang";
            this.dataGridViewBarang.RowHeadersWidth = 62;
            this.dataGridViewBarang.Size = new System.Drawing.Size(802, 308);
            this.dataGridViewBarang.TabIndex = 8;
            // 
            // panelDaftarBarang
            // 
            this.panelDaftarBarang.BackColor = System.Drawing.Color.SeaShell;
            this.panelDaftarBarang.Controls.Add(this.textBoxCari);
            this.panelDaftarBarang.Controls.Add(this.comboBoxCari);
            this.panelDaftarBarang.Controls.Add(this.label2);
            this.panelDaftarBarang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDaftarBarang.Location = new System.Drawing.Point(13, 70);
            this.panelDaftarBarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDaftarBarang.Name = "panelDaftarBarang";
            this.panelDaftarBarang.Size = new System.Drawing.Size(802, 88);
            this.panelDaftarBarang.TabIndex = 7;
            // 
            // textBoxCari
            // 
            this.textBoxCari.Location = new System.Drawing.Point(458, 25);
            this.textBoxCari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(298, 31);
            this.textBoxCari.TabIndex = 2;
            // 
            // comboBoxCari
            // 
            this.comboBoxCari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCari.FormattingEnabled = true;
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
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonKeluar.Location = new System.Drawing.Point(665, 484);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(150, 57);
            this.buttonKeluar.TabIndex = 9;
            this.buttonKeluar.Text = "&Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(802, 57);
            this.label1.TabIndex = 6;
            this.label1.Text = "     Barang";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormKonsumenBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 554);
            this.Controls.Add(this.dataGridViewBarang);
            this.Controls.Add(this.panelDaftarBarang);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.label1);
            this.Name = "FormKonsumenBarang";
            this.Text = "Barang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).EndInit();
            this.panelDaftarBarang.ResumeLayout(false);
            this.panelDaftarBarang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBarang;
        private System.Windows.Forms.Panel panelDaftarBarang;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.ComboBox comboBoxCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Label label1;
    }
}