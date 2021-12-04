
namespace OnlineMart_Ndase
{
    partial class FormKonsumenChat
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonKeluar = new System.Windows.Forms.Button();
            this.panelCekPesanan = new System.Windows.Forms.Panel();
            this.labelKurir = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxChat = new System.Windows.Forms.ListBox();
            this.buttonKirim = new System.Windows.Forms.Button();
            this.textBoxChat = new System.Windows.Forms.TextBox();
            this.panelCekPesanan.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OrangeRed;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "     Chat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonKeluar
            // 
            this.buttonKeluar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonKeluar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeluar.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonKeluar.Location = new System.Drawing.Point(445, 403);
            this.buttonKeluar.Name = "buttonKeluar";
            this.buttonKeluar.Size = new System.Drawing.Size(100, 37);
            this.buttonKeluar.TabIndex = 11;
            this.buttonKeluar.Text = "&Keluar";
            this.buttonKeluar.UseVisualStyleBackColor = false;
            this.buttonKeluar.Click += new System.EventHandler(this.buttonKeluar_Click);
            // 
            // panelCekPesanan
            // 
            this.panelCekPesanan.BackColor = System.Drawing.Color.SeaShell;
            this.panelCekPesanan.Controls.Add(this.labelKurir);
            this.panelCekPesanan.Controls.Add(this.label5);
            this.panelCekPesanan.Controls.Add(this.listBoxChat);
            this.panelCekPesanan.Controls.Add(this.buttonKirim);
            this.panelCekPesanan.Controls.Add(this.textBoxChat);
            this.panelCekPesanan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCekPesanan.Location = new System.Drawing.Point(10, 48);
            this.panelCekPesanan.Name = "panelCekPesanan";
            this.panelCekPesanan.Size = new System.Drawing.Size(535, 349);
            this.panelCekPesanan.TabIndex = 9;
            // 
            // labelKurir
            // 
            this.labelKurir.AutoSize = true;
            this.labelKurir.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKurir.ForeColor = System.Drawing.Color.Black;
            this.labelKurir.Location = new System.Drawing.Point(82, 21);
            this.labelKurir.Name = "labelKurir";
            this.labelKurir.Size = new System.Drawing.Size(36, 17);
            this.labelKurir.TabIndex = 20;
            this.labelKurir.Text = "Kurir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Kepada :";
            // 
            // listBoxChat
            // 
            this.listBoxChat.FormattingEnabled = true;
            this.listBoxChat.ItemHeight = 16;
            this.listBoxChat.Location = new System.Drawing.Point(22, 63);
            this.listBoxChat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxChat.Name = "listBoxChat";
            this.listBoxChat.Size = new System.Drawing.Size(492, 196);
            this.listBoxChat.TabIndex = 13;
            // 
            // buttonKirim
            // 
            this.buttonKirim.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonKirim.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKirim.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonKirim.Location = new System.Drawing.Point(414, 288);
            this.buttonKirim.Name = "buttonKirim";
            this.buttonKirim.Size = new System.Drawing.Size(100, 37);
            this.buttonKirim.TabIndex = 12;
            this.buttonKirim.Text = "&Kirim";
            this.buttonKirim.UseVisualStyleBackColor = false;
            this.buttonKirim.Click += new System.EventHandler(this.buttonKirim_Click);
            // 
            // textBoxChat
            // 
            this.textBoxChat.Location = new System.Drawing.Point(22, 288);
            this.textBoxChat.Multiline = true;
            this.textBoxChat.Name = "textBoxChat";
            this.textBoxChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxChat.Size = new System.Drawing.Size(386, 38);
            this.textBoxChat.TabIndex = 10;
            // 
            // FormKonsumenChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKeluar);
            this.Controls.Add(this.panelCekPesanan);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormKonsumenChat";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.FormKonsumenChat_Load);
            this.panelCekPesanan.ResumeLayout(false);
            this.panelCekPesanan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonKeluar;
        private System.Windows.Forms.Panel panelCekPesanan;
        private System.Windows.Forms.Button buttonKirim;
        private System.Windows.Forms.TextBox textBoxChat;
        private System.Windows.Forms.ListBox listBoxChat;
        private System.Windows.Forms.Label labelKurir;
        private System.Windows.Forms.Label label5;
    }
}