
namespace OnlineMart_Ndase
{
    partial class FormKonsumenRiwayatTransaksi
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
            this.dataGridViewRiwayatTransaksi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRiwayatTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRiwayatTransaksi
            // 
            this.dataGridViewRiwayatTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRiwayatTransaksi.Location = new System.Drawing.Point(16, 61);
            this.dataGridViewRiwayatTransaksi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewRiwayatTransaksi.Name = "dataGridViewRiwayatTransaksi";
            this.dataGridViewRiwayatTransaksi.RowHeadersWidth = 62;
            this.dataGridViewRiwayatTransaksi.Size = new System.Drawing.Size(713, 246);
            this.dataGridViewRiwayatTransaksi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(713, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "     Riwayat Transaksi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonKeluar.Location = new System.Drawing.Point(596, 314);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(133, 46);
            this.buttonKeluar.TabIndex = 3;
            this.buttonKeluar.Text = "&Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // FormKonsumenRiwayatTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 374);
            this.Controls.Add(this.dataGridViewRiwayatTransaksi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormKonsumenRiwayatTransaksi";
            this.Text = "Riwayat Transaksi";
            this.Load += new System.EventHandler(this.FormKonsumenRiwayatTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRiwayatTransaksi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewRiwayatTransaksi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
    }
}