﻿
namespace OnlineMart_Ndase
{
    partial class FormUtamaKurir
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.daftarPengirimanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rekapPendapatanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daftarPengirimanToolStripMenuItem,
            this.rekapPendapatanToolStripMenuItem,
            this.keluarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // daftarPengirimanToolStripMenuItem
            // 
            this.daftarPengirimanToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daftarPengirimanToolStripMenuItem.Name = "daftarPengirimanToolStripMenuItem";
            this.daftarPengirimanToolStripMenuItem.Size = new System.Drawing.Size(188, 32);
            this.daftarPengirimanToolStripMenuItem.Text = "Daftar Pengiriman";
            // 
            // rekapPendapatanToolStripMenuItem
            // 
            this.rekapPendapatanToolStripMenuItem.Name = "rekapPendapatanToolStripMenuItem";
            this.rekapPendapatanToolStripMenuItem.Size = new System.Drawing.Size(174, 29);
            this.rekapPendapatanToolStripMenuItem.Text = "Rekap Pendapatan";
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.keluarToolStripMenuItem.Text = "Keluar";
            // 
            // FormUtamaKurir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormUtamaKurir";
            this.Text = "FormUtamaKurir";
            this.Load += new System.EventHandler(this.FormUtamaKurir_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem daftarPengirimanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rekapPendapatanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
    }
}