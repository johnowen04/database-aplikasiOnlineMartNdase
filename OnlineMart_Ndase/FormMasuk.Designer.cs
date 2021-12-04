
namespace OnlineMart_Ndase
{
    partial class FormMasuk
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
            this.buttonMasuk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonKonsumen = new System.Windows.Forms.RadioButton();
            this.radioButtonKurir = new System.Windows.Forms.RadioButton();
            this.radioButtonPegawai = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelKonsumen = new System.Windows.Forms.Panel();
            this.textBoxEmailKonsumen = new System.Windows.Forms.TextBox();
            this.textBoxKataSandiKonsumen = new System.Windows.Forms.TextBox();
            this.linkLabelDaftar = new System.Windows.Forms.LinkLabel();
            this.panelKurirPegawai = new System.Windows.Forms.Panel();
            this.textBoxKataSandiKurirPegawai = new System.Windows.Forms.TextBox();
            this.textBoxUsernameKurirPegawai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelKonsumen.SuspendLayout();
            this.panelKurirPegawai.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMasuk
            // 
            this.buttonMasuk.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonMasuk.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMasuk.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMasuk.Location = new System.Drawing.Point(59, 372);
            this.buttonMasuk.Name = "buttonMasuk";
            this.buttonMasuk.Size = new System.Drawing.Size(250, 60);
            this.buttonMasuk.TabIndex = 0;
            this.buttonMasuk.Text = "Masuk";
            this.buttonMasuk.UseVisualStyleBackColor = false;
            this.buttonMasuk.Click += new System.EventHandler(this.buttonMasuk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(686, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selamat Datang Kembali di OMA!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "The Application for Online Mart";
            // 
            // radioButtonKonsumen
            // 
            this.radioButtonKonsumen.AutoSize = true;
            this.radioButtonKonsumen.Checked = true;
            this.radioButtonKonsumen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKonsumen.Location = new System.Drawing.Point(59, 173);
            this.radioButtonKonsumen.Name = "radioButtonKonsumen";
            this.radioButtonKonsumen.Size = new System.Drawing.Size(148, 33);
            this.radioButtonKonsumen.TabIndex = 4;
            this.radioButtonKonsumen.TabStop = true;
            this.radioButtonKonsumen.Text = "Konsumen";
            this.radioButtonKonsumen.UseVisualStyleBackColor = true;
            this.radioButtonKonsumen.CheckedChanged += new System.EventHandler(this.radioButtonKonsumen_CheckedChanged);
            // 
            // radioButtonKurir
            // 
            this.radioButtonKurir.AutoSize = true;
            this.radioButtonKurir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKurir.Location = new System.Drawing.Point(280, 173);
            this.radioButtonKurir.Name = "radioButtonKurir";
            this.radioButtonKurir.Size = new System.Drawing.Size(88, 33);
            this.radioButtonKurir.TabIndex = 5;
            this.radioButtonKurir.Text = "Kurir";
            this.radioButtonKurir.UseVisualStyleBackColor = true;
            this.radioButtonKurir.CheckedChanged += new System.EventHandler(this.radioButtonKurir_CheckedChanged);
            // 
            // radioButtonPegawai
            // 
            this.radioButtonPegawai.AutoSize = true;
            this.radioButtonPegawai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPegawai.Location = new System.Drawing.Point(435, 173);
            this.radioButtonPegawai.Name = "radioButtonPegawai";
            this.radioButtonPegawai.Size = new System.Drawing.Size(126, 33);
            this.radioButtonPegawai.TabIndex = 6;
            this.radioButtonPegawai.Text = "Pegawai";
            this.radioButtonPegawai.UseVisualStyleBackColor = true;
            this.radioButtonPegawai.CheckedChanged += new System.EventHandler(this.radioButtonPegawai_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-5, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-5, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kata sandi :";
            // 
            // panelKonsumen
            // 
            this.panelKonsumen.Controls.Add(this.textBoxKataSandiKonsumen);
            this.panelKonsumen.Controls.Add(this.textBoxEmailKonsumen);
            this.panelKonsumen.Controls.Add(this.label3);
            this.panelKonsumen.Controls.Add(this.label4);
            this.panelKonsumen.Location = new System.Drawing.Point(61, 222);
            this.panelKonsumen.Name = "panelKonsumen";
            this.panelKonsumen.Size = new System.Drawing.Size(500, 140);
            this.panelKonsumen.TabIndex = 9;
            // 
            // textBoxEmailKonsumen
            // 
            this.textBoxEmailKonsumen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmailKonsumen.Location = new System.Drawing.Point(141, 26);
            this.textBoxEmailKonsumen.Name = "textBoxEmailKonsumen";
            this.textBoxEmailKonsumen.Size = new System.Drawing.Size(300, 36);
            this.textBoxEmailKonsumen.TabIndex = 9;
            // 
            // textBoxKataSandiKonsumen
            // 
            this.textBoxKataSandiKonsumen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKataSandiKonsumen.Location = new System.Drawing.Point(141, 77);
            this.textBoxKataSandiKonsumen.Name = "textBoxKataSandiKonsumen";
            this.textBoxKataSandiKonsumen.Size = new System.Drawing.Size(300, 36);
            this.textBoxKataSandiKonsumen.TabIndex = 10;
            // 
            // linkLabelDaftar
            // 
            this.linkLabelDaftar.AutoSize = true;
            this.linkLabelDaftar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelDaftar.LinkColor = System.Drawing.Color.OrangeRed;
            this.linkLabelDaftar.Location = new System.Drawing.Point(55, 440);
            this.linkLabelDaftar.Name = "linkLabelDaftar";
            this.linkLabelDaftar.Size = new System.Drawing.Size(252, 24);
            this.linkLabelDaftar.TabIndex = 10;
            this.linkLabelDaftar.TabStop = true;
            this.linkLabelDaftar.Text = "Belum punya akun ? Daftar";
            this.linkLabelDaftar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDaftar_LinkClicked);
            // 
            // panelKurirPegawai
            // 
            this.panelKurirPegawai.Controls.Add(this.textBoxKataSandiKurirPegawai);
            this.panelKurirPegawai.Controls.Add(this.textBoxUsernameKurirPegawai);
            this.panelKurirPegawai.Controls.Add(this.label5);
            this.panelKurirPegawai.Controls.Add(this.label6);
            this.panelKurirPegawai.Location = new System.Drawing.Point(58, 222);
            this.panelKurirPegawai.Name = "panelKurirPegawai";
            this.panelKurirPegawai.Size = new System.Drawing.Size(500, 140);
            this.panelKurirPegawai.TabIndex = 11;
            // 
            // textBoxKataSandiKurirPegawai
            // 
            this.textBoxKataSandiKurirPegawai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKataSandiKurirPegawai.Location = new System.Drawing.Point(145, 76);
            this.textBoxKataSandiKurirPegawai.Name = "textBoxKataSandiKurirPegawai";
            this.textBoxKataSandiKurirPegawai.Size = new System.Drawing.Size(300, 36);
            this.textBoxKataSandiKurirPegawai.TabIndex = 10;
            // 
            // textBoxUsernameKurirPegawai
            // 
            this.textBoxUsernameKurirPegawai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsernameKurirPegawai.Location = new System.Drawing.Point(145, 25);
            this.textBoxUsernameKurirPegawai.Name = "textBoxUsernameKurirPegawai";
            this.textBoxUsernameKurirPegawai.Size = new System.Drawing.Size(300, 36);
            this.textBoxUsernameKurirPegawai.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Username :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-1, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kata sandi :";
            // 
            // FormMasuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.panelKurirPegawai);
            this.Controls.Add(this.linkLabelDaftar);
            this.Controls.Add(this.panelKonsumen);
            this.Controls.Add(this.radioButtonPegawai);
            this.Controls.Add(this.radioButtonKurir);
            this.Controls.Add(this.radioButtonKonsumen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMasuk);
            this.Name = "FormMasuk";
            this.Text = "OMA! The Application for Online Mart";
            this.Load += new System.EventHandler(this.FormMasuk_Load);
            this.panelKonsumen.ResumeLayout(false);
            this.panelKonsumen.PerformLayout();
            this.panelKurirPegawai.ResumeLayout(false);
            this.panelKurirPegawai.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMasuk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonKonsumen;
        private System.Windows.Forms.RadioButton radioButtonKurir;
        private System.Windows.Forms.RadioButton radioButtonPegawai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelKonsumen;
        private System.Windows.Forms.TextBox textBoxKataSandiKonsumen;
        private System.Windows.Forms.TextBox textBoxEmailKonsumen;
        private System.Windows.Forms.LinkLabel linkLabelDaftar;
        private System.Windows.Forms.Panel panelKurirPegawai;
        private System.Windows.Forms.TextBox textBoxKataSandiKurirPegawai;
        private System.Windows.Forms.TextBox textBoxUsernameKurirPegawai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

