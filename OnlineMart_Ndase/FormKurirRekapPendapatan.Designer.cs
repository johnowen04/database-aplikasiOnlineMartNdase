
namespace OnlineMart_Ndase
{
    partial class FormKurirRekapPendapatan
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
            this.dataGridViewPendapatan = new System.Windows.Forms.DataGridView();
            this.panelRekapPenjualanBarang = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDownTahun = new System.Windows.Forms.NumericUpDown();
            this.comboBoxBulan = new System.Windows.Forms.ComboBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendapatan)).BeginInit();
            this.panelRekapPenjualanBarang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTahun)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPendapatan
            // 
            this.dataGridViewPendapatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPendapatan.Location = new System.Drawing.Point(13, 240);
            this.dataGridViewPendapatan.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPendapatan.Name = "dataGridViewPendapatan";
            this.dataGridViewPendapatan.RowHeadersWidth = 62;
            this.dataGridViewPendapatan.Size = new System.Drawing.Size(713, 246);
            this.dataGridViewPendapatan.TabIndex = 16;
            // 
            // panelRekapPenjualanBarang
            // 
            this.panelRekapPenjualanBarang.BackColor = System.Drawing.Color.SeaShell;
            this.panelRekapPenjualanBarang.Controls.Add(this.checkBox1);
            this.panelRekapPenjualanBarang.Controls.Add(this.numericUpDownTahun);
            this.panelRekapPenjualanBarang.Controls.Add(this.comboBoxBulan);
            this.panelRekapPenjualanBarang.Controls.Add(this.buttonFilter);
            this.panelRekapPenjualanBarang.Controls.Add(this.label5);
            this.panelRekapPenjualanBarang.Controls.Add(this.label4);
            this.panelRekapPenjualanBarang.Controls.Add(this.label3);
            this.panelRekapPenjualanBarang.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRekapPenjualanBarang.Location = new System.Drawing.Point(13, 57);
            this.panelRekapPenjualanBarang.Margin = new System.Windows.Forms.Padding(4);
            this.panelRekapPenjualanBarang.Name = "panelRekapPenjualanBarang";
            this.panelRekapPenjualanBarang.Size = new System.Drawing.Size(713, 175);
            this.panelRekapPenjualanBarang.TabIndex = 15;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(125, 92);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 21);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Filter 1 tahun";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // numericUpDownTahun
            // 
            this.numericUpDownTahun.Location = new System.Drawing.Point(125, 119);
            this.numericUpDownTahun.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownTahun.Name = "numericUpDownTahun";
            this.numericUpDownTahun.Size = new System.Drawing.Size(120, 27);
            this.numericUpDownTahun.TabIndex = 15;
            // 
            // comboBoxBulan
            // 
            this.comboBoxBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBulan.FormattingEnabled = true;
            this.comboBoxBulan.Items.AddRange(new object[] {
            "Januari",
            "Februari",
            "Maret",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Agustus",
            "September",
            "Oktober",
            "November",
            "Desember"});
            this.comboBoxBulan.Location = new System.Drawing.Point(125, 63);
            this.comboBoxBulan.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxBulan.Name = "comboBoxBulan";
            this.comboBoxBulan.Size = new System.Drawing.Size(174, 27);
            this.comboBoxBulan.TabIndex = 14;
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFilter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonFilter.Location = new System.Drawing.Point(514, 80);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(133, 46);
            this.buttonFilter.TabIndex = 10;
            this.buttonFilter.Text = "&Filter";
            this.buttonFilter.UseVisualStyleBackColor = false;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tahun :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bulan :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filter";
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonKeluar.Location = new System.Drawing.Point(592, 493);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(133, 46);
            this.buttonKeluar.TabIndex = 17;
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
            this.label1.Size = new System.Drawing.Size(713, 46);
            this.label1.TabIndex = 14;
            this.label1.Text = "     Rekap Pendapatan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormKurirRekapPendapatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 550);
            this.Controls.Add(this.dataGridViewPendapatan);
            this.Controls.Add(this.panelRekapPenjualanBarang);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormKurirRekapPendapatan";
            this.Text = "Rekap Pendapatan";
            this.Load += new System.EventHandler(this.FormKurirRekapPendapatan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPendapatan)).EndInit();
            this.panelRekapPenjualanBarang.ResumeLayout(false);
            this.panelRekapPenjualanBarang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTahun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPendapatan;
        private System.Windows.Forms.Panel panelRekapPenjualanBarang;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownTahun;
        private System.Windows.Forms.ComboBox comboBoxBulan;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Label label1;
    }
}