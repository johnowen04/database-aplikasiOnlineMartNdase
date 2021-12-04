
namespace OnlineMart_Ndase
{
    partial class FormKonsumenCekPesanan
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
            this.dataGridViewCekPesanan = new System.Windows.Forms.DataGridView();
            this.panelCekPesanan = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCekPesanan)).BeginInit();
            this.panelCekPesanan.SuspendLayout();
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
            // dataGridViewCekPesanan
            // 
            this.dataGridViewCekPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCekPesanan.Location = new System.Drawing.Point(13, 167);
            this.dataGridViewCekPesanan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewCekPesanan.Name = "dataGridViewCekPesanan";
            this.dataGridViewCekPesanan.RowHeadersWidth = 62;
            this.dataGridViewCekPesanan.Size = new System.Drawing.Size(802, 308);
            this.dataGridViewCekPesanan.TabIndex = 6;
            // 
            // panelCekPesanan
            // 
            this.panelCekPesanan.BackColor = System.Drawing.Color.SeaShell;
            this.panelCekPesanan.Controls.Add(this.textBoxCari);
            this.panelCekPesanan.Controls.Add(this.comboBoxCari);
            this.panelCekPesanan.Controls.Add(this.label2);
            this.panelCekPesanan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCekPesanan.Location = new System.Drawing.Point(13, 70);
            this.panelCekPesanan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelCekPesanan.Name = "panelCekPesanan";
            this.panelCekPesanan.Size = new System.Drawing.Size(802, 88);
            this.panelCekPesanan.TabIndex = 5;
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
            this.label1.Text = "     Cek Pesanan";
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
            // FormKonsumenCekPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 553);
            this.Controls.Add(this.dataGridViewCekPesanan);
            this.Controls.Add(this.panelCekPesanan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Name = "FormKonsumenCekPesanan";
            this.Text = "Cek Pesanan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCekPesanan)).EndInit();
            this.panelCekPesanan.ResumeLayout(false);
            this.panelCekPesanan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.ComboBox comboBoxCari;
        private System.Windows.Forms.DataGridView dataGridViewCekPesanan;
        private System.Windows.Forms.Panel panelCekPesanan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
    }
}