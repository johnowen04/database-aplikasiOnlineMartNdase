
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
            this.labelLoginInfo = new System.Windows.Forms.Label();
            this.labelLoginPassword = new System.Windows.Forms.Label();
            this.panelLoginInfo = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLoginInfo = new System.Windows.Forms.TextBox();
            this.linkLabelDaftar = new System.Windows.Forms.LinkLabel();
            this.panelLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMasuk
            // 
            this.buttonMasuk.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonMasuk.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMasuk.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMasuk.Location = new System.Drawing.Point(39, 242);
            this.buttonMasuk.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMasuk.Name = "buttonMasuk";
            this.buttonMasuk.Size = new System.Drawing.Size(167, 39);
            this.buttonMasuk.TabIndex = 0;
            this.buttonMasuk.Text = "Masuk";
            this.buttonMasuk.UseVisualStyleBackColor = false;
            this.buttonMasuk.Click += new System.EventHandler(this.buttonMasuk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selamat Datang Kembali di OMA!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "The Application for Online Mart";
            // 
            // radioButtonKonsumen
            // 
            this.radioButtonKonsumen.AutoSize = true;
            this.radioButtonKonsumen.Checked = true;
            this.radioButtonKonsumen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKonsumen.Location = new System.Drawing.Point(39, 112);
            this.radioButtonKonsumen.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonKonsumen.Name = "radioButtonKonsumen";
            this.radioButtonKonsumen.Size = new System.Drawing.Size(101, 23);
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
            this.radioButtonKurir.Location = new System.Drawing.Point(187, 112);
            this.radioButtonKurir.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonKurir.Name = "radioButtonKurir";
            this.radioButtonKurir.Size = new System.Drawing.Size(61, 23);
            this.radioButtonKurir.TabIndex = 5;
            this.radioButtonKurir.Text = "Kurir";
            this.radioButtonKurir.UseVisualStyleBackColor = true;
            this.radioButtonKurir.CheckedChanged += new System.EventHandler(this.radioButtonKurir_CheckedChanged);
            // 
            // radioButtonPegawai
            // 
            this.radioButtonPegawai.AutoSize = true;
            this.radioButtonPegawai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPegawai.Location = new System.Drawing.Point(290, 112);
            this.radioButtonPegawai.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonPegawai.Name = "radioButtonPegawai";
            this.radioButtonPegawai.Size = new System.Drawing.Size(85, 23);
            this.radioButtonPegawai.TabIndex = 6;
            this.radioButtonPegawai.Text = "Pegawai";
            this.radioButtonPegawai.UseVisualStyleBackColor = true;
            this.radioButtonPegawai.CheckedChanged += new System.EventHandler(this.radioButtonPegawai_CheckedChanged);
            // 
            // labelLoginInfo
            // 
            this.labelLoginInfo.AutoSize = true;
            this.labelLoginInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginInfo.Location = new System.Drawing.Point(-3, 19);
            this.labelLoginInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLoginInfo.Name = "labelLoginInfo";
            this.labelLoginInfo.Size = new System.Drawing.Size(59, 19);
            this.labelLoginInfo.TabIndex = 7;
            this.labelLoginInfo.Text = "Email :";
            // 
            // labelLoginPassword
            // 
            this.labelLoginPassword.AutoSize = true;
            this.labelLoginPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginPassword.Location = new System.Drawing.Point(-3, 52);
            this.labelLoginPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLoginPassword.Name = "labelLoginPassword";
            this.labelLoginPassword.Size = new System.Drawing.Size(92, 19);
            this.labelLoginPassword.TabIndex = 8;
            this.labelLoginPassword.Text = "Kata sandi :";
            // 
            // panelLoginInfo
            // 
            this.panelLoginInfo.Controls.Add(this.textBoxPassword);
            this.panelLoginInfo.Controls.Add(this.textBoxLoginInfo);
            this.panelLoginInfo.Controls.Add(this.labelLoginInfo);
            this.panelLoginInfo.Controls.Add(this.labelLoginPassword);
            this.panelLoginInfo.Location = new System.Drawing.Point(41, 144);
            this.panelLoginInfo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLoginInfo.Name = "panelLoginInfo";
            this.panelLoginInfo.Size = new System.Drawing.Size(333, 91);
            this.panelLoginInfo.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(94, 50);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(201, 27);
            this.textBoxPassword.TabIndex = 10;
            // 
            // textBoxLoginInfo
            // 
            this.textBoxLoginInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLoginInfo.Location = new System.Drawing.Point(94, 17);
            this.textBoxLoginInfo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLoginInfo.Name = "textBoxLoginInfo";
            this.textBoxLoginInfo.Size = new System.Drawing.Size(201, 27);
            this.textBoxLoginInfo.TabIndex = 9;
            // 
            // linkLabelDaftar
            // 
            this.linkLabelDaftar.AutoSize = true;
            this.linkLabelDaftar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelDaftar.LinkColor = System.Drawing.Color.OrangeRed;
            this.linkLabelDaftar.Location = new System.Drawing.Point(37, 286);
            this.linkLabelDaftar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelDaftar.Name = "linkLabelDaftar";
            this.linkLabelDaftar.Size = new System.Drawing.Size(175, 17);
            this.linkLabelDaftar.TabIndex = 10;
            this.linkLabelDaftar.TabStop = true;
            this.linkLabelDaftar.Text = "Belum punya akun ? Daftar";
            this.linkLabelDaftar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDaftar_LinkClicked);
            // 
            // FormMasuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(652, 354);
            this.Controls.Add(this.linkLabelDaftar);
            this.Controls.Add(this.panelLoginInfo);
            this.Controls.Add(this.radioButtonPegawai);
            this.Controls.Add(this.radioButtonKurir);
            this.Controls.Add(this.radioButtonKonsumen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMasuk);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMasuk";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormMasuk_Load);
            this.panelLoginInfo.ResumeLayout(false);
            this.panelLoginInfo.PerformLayout();
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
        private System.Windows.Forms.Label labelLoginInfo;
        private System.Windows.Forms.Label labelLoginPassword;
        private System.Windows.Forms.Panel panelLoginInfo;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLoginInfo;
        private System.Windows.Forms.LinkLabel linkLabelDaftar;
    }
}

