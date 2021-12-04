
namespace OnlineMart_Ndase
{
    partial class FormDaftar
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
            this.linkLabelMasuk = new System.Windows.Forms.LinkLabel();
            this.textBoxKataSandiKonsumen = new System.Windows.Forms.TextBox();
            this.textBoxEmailKonsumen = new System.Windows.Forms.TextBox();
            this.panelDaftar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonKurir = new System.Windows.Forms.RadioButton();
            this.radioButtonKonsumen = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDaftar = new System.Windows.Forms.Button();
            this.textBoxNamaKonsumen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxDaftar = new System.Windows.Forms.CheckBox();
            this.panelDaftar.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabelMasuk
            // 
            this.linkLabelMasuk.AutoSize = true;
            this.linkLabelMasuk.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelMasuk.LinkColor = System.Drawing.Color.OrangeRed;
            this.linkLabelMasuk.Location = new System.Drawing.Point(53, 580);
            this.linkLabelMasuk.Name = "linkLabelMasuk";
            this.linkLabelMasuk.Size = new System.Drawing.Size(251, 24);
            this.linkLabelMasuk.TabIndex = 19;
            this.linkLabelMasuk.TabStop = true;
            this.linkLabelMasuk.Text = "Sudah punya akun ? Masuk";
            // 
            // textBoxKataSandiKonsumen
            // 
            this.textBoxKataSandiKonsumen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKataSandiKonsumen.Location = new System.Drawing.Point(141, 128);
            this.textBoxKataSandiKonsumen.Name = "textBoxKataSandiKonsumen";
            this.textBoxKataSandiKonsumen.Size = new System.Drawing.Size(300, 36);
            this.textBoxKataSandiKonsumen.TabIndex = 10;
            // 
            // textBoxEmailKonsumen
            // 
            this.textBoxEmailKonsumen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmailKonsumen.Location = new System.Drawing.Point(141, 77);
            this.textBoxEmailKonsumen.Name = "textBoxEmailKonsumen";
            this.textBoxEmailKonsumen.Size = new System.Drawing.Size(300, 36);
            this.textBoxEmailKonsumen.TabIndex = 9;
            // 
            // panelDaftar
            // 
            this.panelDaftar.Controls.Add(this.textBox1);
            this.panelDaftar.Controls.Add(this.label8);
            this.panelDaftar.Controls.Add(this.textBoxNamaKonsumen);
            this.panelDaftar.Controls.Add(this.label7);
            this.panelDaftar.Controls.Add(this.textBoxKataSandiKonsumen);
            this.panelDaftar.Controls.Add(this.textBoxEmailKonsumen);
            this.panelDaftar.Controls.Add(this.label3);
            this.panelDaftar.Controls.Add(this.label4);
            this.panelDaftar.Location = new System.Drawing.Point(59, 202);
            this.panelDaftar.Name = "panelDaftar";
            this.panelDaftar.Size = new System.Drawing.Size(500, 250);
            this.panelDaftar.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-5, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-5, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kata sandi :";
            // 
            // radioButtonKurir
            // 
            this.radioButtonKurir.AutoSize = true;
            this.radioButtonKurir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKurir.Location = new System.Drawing.Point(278, 153);
            this.radioButtonKurir.Name = "radioButtonKurir";
            this.radioButtonKurir.Size = new System.Drawing.Size(88, 33);
            this.radioButtonKurir.TabIndex = 16;
            this.radioButtonKurir.Text = "Kurir";
            this.radioButtonKurir.UseVisualStyleBackColor = true;
            // 
            // radioButtonKonsumen
            // 
            this.radioButtonKonsumen.AutoSize = true;
            this.radioButtonKonsumen.Checked = true;
            this.radioButtonKonsumen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKonsumen.Location = new System.Drawing.Point(57, 153);
            this.radioButtonKonsumen.Name = "radioButtonKonsumen";
            this.radioButtonKonsumen.Size = new System.Drawing.Size(148, 33);
            this.radioButtonKonsumen.TabIndex = 15;
            this.radioButtonKonsumen.TabStop = true;
            this.radioButtonKonsumen.Text = "Konsumen";
            this.radioButtonKonsumen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 39);
            this.label2.TabIndex = 14;
            this.label2.Text = "The Application for Online Mart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 48);
            this.label1.TabIndex = 13;
            this.label1.Text = "Selamat Datang di OMA!";
            // 
            // buttonDaftar
            // 
            this.buttonDaftar.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonDaftar.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDaftar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDaftar.Location = new System.Drawing.Point(57, 512);
            this.buttonDaftar.Name = "buttonDaftar";
            this.buttonDaftar.Size = new System.Drawing.Size(250, 60);
            this.buttonDaftar.TabIndex = 12;
            this.buttonDaftar.Text = "Daftar";
            this.buttonDaftar.UseVisualStyleBackColor = false;
            // 
            // textBoxNamaKonsumen
            // 
            this.textBoxNamaKonsumen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamaKonsumen.Location = new System.Drawing.Point(141, 26);
            this.textBoxNamaKonsumen.Name = "textBoxNamaKonsumen";
            this.textBoxNamaKonsumen.Size = new System.Drawing.Size(300, 36);
            this.textBoxNamaKonsumen.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-5, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nama :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(141, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 36);
            this.textBox1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-5, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "No. Telp. :";
            // 
            // checkBoxDaftar
            // 
            this.checkBoxDaftar.AutoSize = true;
            this.checkBoxDaftar.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDaftar.Location = new System.Drawing.Point(59, 462);
            this.checkBoxDaftar.Name = "checkBoxDaftar";
            this.checkBoxDaftar.Size = new System.Drawing.Size(811, 28);
            this.checkBoxDaftar.TabIndex = 21;
            this.checkBoxDaftar.Text = "Dengan mendaftar Anda menyetujui Syarat dan Ketentuan dan Kebijakan Privasi OMA!";
            this.checkBoxDaftar.UseVisualStyleBackColor = true;
            // 
            // FormDaftar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 650);
            this.Controls.Add(this.checkBoxDaftar);
            this.Controls.Add(this.linkLabelMasuk);
            this.Controls.Add(this.panelDaftar);
            this.Controls.Add(this.radioButtonKurir);
            this.Controls.Add(this.radioButtonKonsumen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDaftar);
            this.Name = "FormDaftar";
            this.Text = "Masuk";
            this.Load += new System.EventHandler(this.FormDaftar_Load);
            this.panelDaftar.ResumeLayout(false);
            this.panelDaftar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabelMasuk;
        private System.Windows.Forms.TextBox textBoxKataSandiKonsumen;
        private System.Windows.Forms.TextBox textBoxEmailKonsumen;
        private System.Windows.Forms.Panel panelDaftar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonKurir;
        private System.Windows.Forms.RadioButton radioButtonKonsumen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDaftar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNamaKonsumen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxDaftar;
    }
}