
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.linkLabelCetak = new System.Windows.Forms.LinkLabel();
            this.labelNoOrder = new System.Windows.Forms.Label();
            this.panelRiwayatTransaksi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRiwayatTransaksi
            // 
            this.panelRiwayatTransaksi.BackColor = System.Drawing.Color.SeaShell;
            this.panelRiwayatTransaksi.Controls.Add(this.labelNoOrder);
            this.panelRiwayatTransaksi.Controls.Add(this.linkLabelCetak);
            this.panelRiwayatTransaksi.Controls.Add(this.label2);
            this.panelRiwayatTransaksi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRiwayatTransaksi.Location = new System.Drawing.Point(12, 56);
            this.panelRiwayatTransaksi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelRiwayatTransaksi.Name = "panelRiwayatTransaksi";
            this.panelRiwayatTransaksi.Size = new System.Drawing.Size(482, 178);
            this.panelRiwayatTransaksi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "No. Order :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "     Cetak Nota";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonKeluar.Location = new System.Drawing.Point(361, 242);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(133, 46);
            this.buttonKeluar.TabIndex = 7;
            this.buttonKeluar.Text = "&Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // linkLabelCetak
            // 
            this.linkLabelCetak.AutoSize = true;
            this.linkLabelCetak.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCetak.LinkColor = System.Drawing.Color.OrangeRed;
            this.linkLabelCetak.Location = new System.Drawing.Point(159, 99);
            this.linkLabelCetak.Name = "linkLabelCetak";
            this.linkLabelCetak.Size = new System.Drawing.Size(92, 21);
            this.linkLabelCetak.TabIndex = 9;
            this.linkLabelCetak.TabStop = true;
            this.linkLabelCetak.Text = "Cetak Nota";
            // 
            // labelNoOrder
            // 
            this.labelNoOrder.AutoSize = true;
            this.labelNoOrder.Location = new System.Drawing.Point(159, 54);
            this.labelNoOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoOrder.Name = "labelNoOrder";
            this.labelNoOrder.Size = new System.Drawing.Size(82, 21);
            this.labelNoOrder.TabIndex = 10;
            this.labelNoOrder.Text = "No. Order";
            // 
            // FormKonsumenCetakNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 296);
            this.Controls.Add(this.panelRiwayatTransaksi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormKonsumenCetakNota";
            this.Text = "Cetak Nota";
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
        private System.Windows.Forms.LinkLabel linkLabelCetak;
    }
}