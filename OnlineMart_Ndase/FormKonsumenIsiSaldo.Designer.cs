
namespace OnlineMart_Ndase
{
    partial class FormKonsumenIsiSaldo
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
            this.panelIsiSaldo = new System.Windows.Forms.Panel();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.labelSaldoSekarang = new System.Windows.Forms.Label();
            this.textBoxNominal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonIsi = new System.Windows.Forms.Button();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panelIsiSaldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIsiSaldo
            // 
            this.panelIsiSaldo.BackColor = System.Drawing.Color.SeaShell;
            this.panelIsiSaldo.Controls.Add(this.comboBoxKategori);
            this.panelIsiSaldo.Controls.Add(this.labelSaldoSekarang);
            this.panelIsiSaldo.Controls.Add(this.textBoxNominal);
            this.panelIsiSaldo.Controls.Add(this.label1);
            this.panelIsiSaldo.Controls.Add(this.label2);
            this.panelIsiSaldo.Controls.Add(this.label3);
            this.panelIsiSaldo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelIsiSaldo.Location = new System.Drawing.Point(9, 45);
            this.panelIsiSaldo.Name = "panelIsiSaldo";
            this.panelIsiSaldo.Size = new System.Drawing.Size(374, 123);
            this.panelIsiSaldo.TabIndex = 17;
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(143, 79);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(200, 24);
            this.comboBoxKategori.TabIndex = 22;
            // 
            // labelSaldoSekarang
            // 
            this.labelSaldoSekarang.AutoSize = true;
            this.labelSaldoSekarang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldoSekarang.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelSaldoSekarang.Location = new System.Drawing.Point(139, 21);
            this.labelSaldoSekarang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSaldoSekarang.Name = "labelSaldoSekarang";
            this.labelSaldoSekarang.Size = new System.Drawing.Size(58, 19);
            this.labelSaldoSekarang.TabIndex = 21;
            this.labelSaldoSekarang.Text = "Rp 0,-";
            // 
            // textBoxNominal
            // 
            this.textBoxNominal.Location = new System.Drawing.Point(143, 53);
            this.textBoxNominal.Name = "textBoxNominal";
            this.textBoxNominal.Size = new System.Drawing.Size(200, 23);
            this.textBoxNominal.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo sekarang :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nominal isi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Isi melalui :";
            // 
            // buttonIsi
            // 
            this.buttonIsi.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonIsi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIsi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonIsi.Location = new System.Drawing.Point(177, 175);
            this.buttonIsi.Name = "buttonIsi";
            this.buttonIsi.Size = new System.Drawing.Size(100, 37);
            this.buttonIsi.TabIndex = 19;
            this.buttonIsi.Text = "&Isi";
            this.buttonIsi.UseVisualStyleBackColor = false;
            this.buttonIsi.Click += new System.EventHandler(this.buttonIsi_Click);
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonKeluar.Location = new System.Drawing.Point(283, 175);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(100, 37);
            this.buttonKeluar.TabIndex = 18;
            this.buttonKeluar.Text = "&Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.OrangeRed;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(9, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(374, 37);
            this.label7.TabIndex = 16;
            this.label7.Text = "     Isi Saldo OMA";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormKonsumenIsiSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 218);
            this.Controls.Add(this.panelIsiSaldo);
            this.Controls.Add(this.buttonIsi);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormKonsumenIsiSaldo";
            this.Text = "Isi Saldo";
            this.Load += new System.EventHandler(this.FormKonsumenIsiSaldo_Load);
            this.panelIsiSaldo.ResumeLayout(false);
            this.panelIsiSaldo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIsiSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonIsi;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNominal;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        public System.Windows.Forms.Label labelSaldoSekarang;
    }
}