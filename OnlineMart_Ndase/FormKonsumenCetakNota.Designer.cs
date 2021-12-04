
namespace OnlineMart_Ndase
{
    partial class FormKonsumenCetakNota
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
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.comboBoxCari = new System.Windows.Forms.ComboBox();
            this.dataGridViewRiwayatTransaksi = new System.Windows.Forms.DataGridView();
            this.panelRiwayatTransaksi = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRiwayatTransaksi)).BeginInit();
            this.panelRiwayatTransaksi.SuspendLayout();
            this.SuspendLayout();
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
            // dataGridViewRiwayatTransaksi
            // 
            this.dataGridViewRiwayatTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRiwayatTransaksi.Location = new System.Drawing.Point(13, 167);
            this.dataGridViewRiwayatTransaksi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewRiwayatTransaksi.Name = "dataGridViewRiwayatTransaksi";
            this.dataGridViewRiwayatTransaksi.RowHeadersWidth = 62;
            this.dataGridViewRiwayatTransaksi.Size = new System.Drawing.Size(802, 308);
            this.dataGridViewRiwayatTransaksi.TabIndex = 6;
            // 
            // panelRiwayatTransaksi
            // 
            this.panelRiwayatTransaksi.BackColor = System.Drawing.Color.SeaShell;
            this.panelRiwayatTransaksi.Controls.Add(this.textBoxCari);
            this.panelRiwayatTransaksi.Controls.Add(this.comboBoxCari);
            this.panelRiwayatTransaksi.Controls.Add(this.label2);
            this.panelRiwayatTransaksi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRiwayatTransaksi.Location = new System.Drawing.Point(13, 70);
            this.panelRiwayatTransaksi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelRiwayatTransaksi.Name = "panelRiwayatTransaksi";
            this.panelRiwayatTransaksi.Size = new System.Drawing.Size(802, 88);
            this.panelRiwayatTransaksi.TabIndex = 5;
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(802, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "     Cetak Nota";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonKeluar.Location = new System.Drawing.Point(665, 484);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(150, 57);
            this.buttonKeluar.TabIndex = 7;
            this.buttonKeluar.Text = "&Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            // 
            // FormKonsumenCetakNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 553);
            this.Controls.Add(this.dataGridViewRiwayatTransaksi);
            this.Controls.Add(this.panelRiwayatTransaksi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Name = "FormKonsumenCetakNota";
            this.Text = "Cetak Nota";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRiwayatTransaksi)).EndInit();
            this.panelRiwayatTransaksi.ResumeLayout(false);
            this.panelRiwayatTransaksi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.ComboBox comboBoxCari;
        private System.Windows.Forms.DataGridView dataGridViewRiwayatTransaksi;
        private System.Windows.Forms.Panel panelRiwayatTransaksi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
    }
}