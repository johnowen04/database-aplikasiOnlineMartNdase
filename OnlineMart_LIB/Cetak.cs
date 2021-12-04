﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;

namespace OnlineMart_LIB
{
    public class Cetak
    {
        #region FIELDS
        private Font jenisFont;
        private StreamReader fileCetak;
        private float marginKiri, marginKanan, marginAtas, marginBawah;
        #endregion

        #region CONSTRUCTORS
        public Cetak(Font jenisFont, StreamReader fileCetak, float marginKiri, float marginKanan, float marginAtas, float marginBawah)
        {
            JenisFont = jenisFont;
            FileCetak = fileCetak;
            MarginKiri = marginKiri;
            MarginKanan = marginKanan;
            MarginAtas = marginAtas;
            MarginBawah = marginBawah;
        }
        #endregion

        #region PROPERTIES
        public Font JenisFont { get => jenisFont; set => jenisFont = value; }
        public StreamReader FileCetak { get => fileCetak; set => fileCetak = value; }
        public float MarginKiri { get => marginKiri; set => marginKiri = value; }
        public float MarginKanan { get => marginKanan; set => marginKanan = value; }
        public float MarginAtas { get => marginAtas; set => marginAtas = value; }
        public float MarginBawah { get => marginBawah; set => marginBawah = value; }
        #endregion

        #region METHODS
        private void CetakTulisan(object sender, PrintPageEventArgs e)
        {
            int jumlahBarisPerHalaman = (int)((e.MarginBounds.Height - MarginBawah - MarginAtas) / jenisFont.GetHeight(e.Graphics));

            float y = MarginAtas;
            int jumlahBaris = 0;
            string tulisanCetak = FileCetak.ReadLine();

            while (jumlahBaris < jumlahBarisPerHalaman && tulisanCetak != null)
            {
                y = MarginAtas + (jumlahBaris * jenisFont.GetHeight(e.Graphics));

                e.Graphics.DrawString(tulisanCetak, JenisFont, Brushes.Black, MarginKiri, y);

                jumlahBaris++;

                tulisanCetak = FileCetak.ReadLine();
            }

            if (tulisanCetak != null)
            {
                e.HasMorePages = true;
            }

            else
            {
                e.HasMorePages = false;
            }
        }

        public void CetakKePrinter()
        {
            PrintDocument p = new PrintDocument();
            p.PrintPage += new PrintPageEventHandler(CetakTulisan);
            p.Print();
            FileCetak.Close();
        }
        #endregion
    }
}
