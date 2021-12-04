
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
            this.buttonUbah = new System.Windows.Forms.Button();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNominal = new System.Windows.Forms.TextBox();
            this.labelSaldoSekarang = new System.Windows.Forms.Label();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
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
            this.panelIsiSaldo.Location = new System.Drawing.Point(13, 70);
            this.panelIsiSaldo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelIsiSaldo.Name = "panelIsiSaldo";
            this.panelIsiSaldo.Size = new System.Drawing.Size(561, 189);
            this.panelIsiSaldo.TabIndex = 17;
            // 
            // buttonUbah
            // 
            this.buttonUbah.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonUbah.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUbah.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonUbah.Location = new System.Drawing.Point(266, 269);
            this.buttonUbah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(150, 57);
            this.buttonUbah.TabIndex = 19;
            this.buttonUbah.Text = "&Ubah";
            this.buttonUbah.UseVisualStyleBackColor = false;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonKeluar.Location = new System.Drawing.Point(424, 269);
            this.buttonKeluar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(150, 57);
            this.buttonKeluar.TabIndex = 18;
            this.buttonKeluar.Text = "&Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.OrangeRed;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(13, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(561, 57);
            this.label7.TabIndex = 16;
            this.label7.Text = "     Isi Saldo OMA";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Isi melalui :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nominal isi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo sekarang :";
            // 
            // textBoxNominal
            // 
            this.textBoxNominal.Location = new System.Drawing.Point(214, 83);
            this.textBoxNominal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNominal.Name = "textBoxNominal";
            this.textBoxNominal.Size = new System.Drawing.Size(298, 31);
            this.textBoxNominal.TabIndex = 20;
            // 
            // labelSaldoSekarang
            // 
            this.labelSaldoSekarang.AutoSize = true;
            this.labelSaldoSekarang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldoSekarang.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelSaldoSekarang.Location = new System.Drawing.Point(209, 30);
            this.labelSaldoSekarang.Name = "labelSaldoSekarang";
            this.labelSaldoSekarang.Size = new System.Drawing.Size(85, 29);
            this.labelSaldoSekarang.TabIndex = 21;
            this.labelSaldoSekarang.Text = "Rp 0,-";
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(214, 122);
            this.comboBoxKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(298, 32);
            this.comboBoxKategori.TabIndex = 22;
            // 
            // FormKonsumenIsiSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 335);
            this.Controls.Add(this.panelIsiSaldo);
            this.Controls.Add(this.buttonUbah);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.label7);
            this.Name = "FormKonsumenIsiSaldo";
            this.Text = "Isi Saldo";
            this.panelIsiSaldo.ResumeLayout(false);
            this.panelIsiSaldo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIsiSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUbah;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelSaldoSekarang;
        private System.Windows.Forms.TextBox textBoxNominal;
        private System.Windows.Forms.ComboBox comboBoxKategori;
    }
}