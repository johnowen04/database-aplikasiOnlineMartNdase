
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
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabelDaftar = new System.Windows.Forms.LinkLabel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLoginInfo = new System.Windows.Forms.TextBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.labelLoginInfo = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonPegawai = new System.Windows.Forms.RadioButton();
            this.radioButtonKurir = new System.Windows.Forms.RadioButton();
            this.radioButtonKonsumen = new System.Windows.Forms.RadioButton();
            this.buttonMasuk = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(268, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Selamat Datang di OMA!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Daftar sebagai :";
            // 
            // linkLabelDaftar
            // 
            this.linkLabelDaftar.AutoSize = true;
            this.linkLabelDaftar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelDaftar.LinkColor = System.Drawing.Color.OrangeRed;
            this.linkLabelDaftar.Location = new System.Drawing.Point(26, 238);
            this.linkLabelDaftar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelDaftar.Name = "linkLabelDaftar";
            this.linkLabelDaftar.Size = new System.Drawing.Size(154, 14);
            this.linkLabelDaftar.TabIndex = 8;
            this.linkLabelDaftar.TabStop = true;
            this.linkLabelDaftar.Text = "Belum punya akun ? Daftar";
            this.linkLabelDaftar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDaftar_LinkClicked);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(78, 38);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(201, 23);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxLoginInfo
            // 
            this.textBoxLoginInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLoginInfo.Location = new System.Drawing.Point(78, 11);
            this.textBoxLoginInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLoginInfo.Name = "textBoxLoginInfo";
            this.textBoxLoginInfo.Size = new System.Drawing.Size(201, 23);
            this.textBoxLoginInfo.TabIndex = 1;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.textBoxLoginInfo);
            this.panelLogin.Controls.Add(this.labelLoginInfo);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Location = new System.Drawing.Point(29, 101);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(290, 72);
            this.panelLogin.TabIndex = 6;
            // 
            // labelLoginInfo
            // 
            this.labelLoginInfo.AutoSize = true;
            this.labelLoginInfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginInfo.Location = new System.Drawing.Point(-2, 14);
            this.labelLoginInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLoginInfo.Name = "labelLoginInfo";
            this.labelLoginInfo.Size = new System.Drawing.Size(48, 16);
            this.labelLoginInfo.TabIndex = 0;
            this.labelLoginInfo.Text = "Email :";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(-2, 41);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(76, 16);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Kata sandi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(232, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "The Application for Online Mart";
            // 
            // radioButtonPegawai
            // 
            this.radioButtonPegawai.AutoSize = true;
            this.radioButtonPegawai.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPegawai.Location = new System.Drawing.Point(276, 77);
            this.radioButtonPegawai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonPegawai.Name = "radioButtonPegawai";
            this.radioButtonPegawai.Size = new System.Drawing.Size(74, 20);
            this.radioButtonPegawai.TabIndex = 5;
            this.radioButtonPegawai.Text = "Pegawai";
            this.radioButtonPegawai.UseVisualStyleBackColor = true;
            this.radioButtonPegawai.CheckedChanged += new System.EventHandler(this.radioButtonPegawai_CheckedChanged);
            // 
            // radioButtonKurir
            // 
            this.radioButtonKurir.AutoSize = true;
            this.radioButtonKurir.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKurir.Location = new System.Drawing.Point(219, 77);
            this.radioButtonKurir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonKurir.Name = "radioButtonKurir";
            this.radioButtonKurir.Size = new System.Drawing.Size(53, 20);
            this.radioButtonKurir.TabIndex = 4;
            this.radioButtonKurir.Text = "Kurir";
            this.radioButtonKurir.UseVisualStyleBackColor = true;
            this.radioButtonKurir.CheckedChanged += new System.EventHandler(this.radioButtonKurir_CheckedChanged);
            // 
            // radioButtonKonsumen
            // 
            this.radioButtonKonsumen.AutoSize = true;
            this.radioButtonKonsumen.Checked = true;
            this.radioButtonKonsumen.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKonsumen.Location = new System.Drawing.Point(130, 77);
            this.radioButtonKonsumen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonKonsumen.Name = "radioButtonKonsumen";
            this.radioButtonKonsumen.Size = new System.Drawing.Size(85, 20);
            this.radioButtonKonsumen.TabIndex = 3;
            this.radioButtonKonsumen.TabStop = true;
            this.radioButtonKonsumen.Text = "Konsumen";
            this.radioButtonKonsumen.UseVisualStyleBackColor = true;
            this.radioButtonKonsumen.CheckedChanged += new System.EventHandler(this.radioButtonKonsumen_CheckedChanged);
            // 
            // buttonMasuk
            // 
            this.buttonMasuk.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonMasuk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMasuk.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMasuk.Location = new System.Drawing.Point(29, 187);
            this.buttonMasuk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMasuk.Name = "buttonMasuk";
            this.buttonMasuk.Size = new System.Drawing.Size(150, 37);
            this.buttonMasuk.TabIndex = 7;
            this.buttonMasuk.Text = "Masuk";
            this.buttonMasuk.UseVisualStyleBackColor = false;
            this.buttonMasuk.Click += new System.EventHandler(this.buttonMasuk_Click);
            // 
            // FormMasuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(368, 276);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLabelDaftar);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioButtonPegawai);
            this.Controls.Add(this.radioButtonKurir);
            this.Controls.Add(this.radioButtonKonsumen);
            this.Controls.Add(this.buttonMasuk);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMasuk";
            this.Text = "Masuk Ke OMA!";
            this.Load += new System.EventHandler(this.FormMasuk_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabelDaftar;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLoginInfo;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelLoginInfo;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonPegawai;
        private System.Windows.Forms.RadioButton radioButtonKurir;
        private System.Windows.Forms.RadioButton radioButtonKonsumen;
        private System.Windows.Forms.Button buttonMasuk;
    }
}

