
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
            this.panelRiwayatTransaksi = new System.Windows.Forms.Panel();
            this.labelNoOrder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.buttonCetak = new System.Windows.Forms.Button();
            this.panelRiwayatTransaksi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRiwayatTransaksi
            // 
            this.panelRiwayatTransaksi.BackColor = System.Drawing.Color.SeaShell;
            this.panelRiwayatTransaksi.Controls.Add(this.labelNoOrder);
            this.panelRiwayatTransaksi.Controls.Add(this.label2);
            this.panelRiwayatTransaksi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRiwayatTransaksi.Location = new System.Drawing.Point(9, 46);
            this.panelRiwayatTransaksi.Name = "panelRiwayatTransaksi";
            this.panelRiwayatTransaksi.Size = new System.Drawing.Size(206, 73);
            this.panelRiwayatTransaksi.TabIndex = 5;
            // 
            // labelNoOrder
            // 
            this.labelNoOrder.AutoSize = true;
            this.labelNoOrder.Location = new System.Drawing.Point(97, 26);
            this.labelNoOrder.Name = "labelNoOrder";
            this.labelNoOrder.Size = new System.Drawing.Size(64, 16);
            this.labelNoOrder.TabIndex = 10;
            this.labelNoOrder.Text = "No. Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "No. Order :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "     Cetak Nota";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonKeluar.Location = new System.Drawing.Point(115, 125);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(100, 37);
            this.buttonKeluar.TabIndex = 7;
            this.buttonKeluar.Text = "&Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // buttonCetak
            // 
            this.buttonCetak.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonCetak.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCetak.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonCetak.Location = new System.Drawing.Point(9, 125);
            this.buttonCetak.Name = "buttonCetak";
            this.buttonCetak.Size = new System.Drawing.Size(100, 37);
            this.buttonCetak.TabIndex = 8;
            this.buttonCetak.Text = "&Cetak";
            this.buttonCetak.UseVisualStyleBackColor = false;
            this.buttonCetak.Click += new System.EventHandler(this.buttonCetak_Click);
            // 
            // FormKonsumenCetakNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 176);
            this.Controls.Add(this.buttonCetak);
            this.Controls.Add(this.panelRiwayatTransaksi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormKonsumenCetakNota";
            this.Text = "Cetak Nota";
            this.Load += new System.EventHandler(this.FormKonsumenCetakNota_Load);
            this.panelRiwayatTransaksi.ResumeLayout(false);
            this.panelRiwayatTransaksi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelRiwayatTransaksi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Label labelNoOrder;
        private System.Windows.Forms.Button buttonCetak;
    }
}