﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Promo
    {
        #region FIELDS
        private int id;
        private string tipe;
        private string nama;
        private int diskon;
        private int maxDiskon;
        private float minBelanja;
        #endregion

        #region CONSTRUCTORS
        public Promo()
        {
            Id = 0;
            Tipe = "";
            Nama = "";
            Diskon = 0;
            MaxDiskon = 0;
            MinBelanja = 0.0f;
        }

        public Promo(int id, string tipe, string nama, int diskon, int maxDiskon, float minBelanja)
        {
            Id = id;
            Tipe = tipe;
            Nama = nama;
            Diskon = diskon;
            MaxDiskon = maxDiskon;
            MinBelanja = minBelanja;
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Tipe { get => tipe; set => tipe = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Diskon { get => diskon; set => diskon = value; }
        public int MaxDiskon { get => maxDiskon; set => maxDiskon = value; }
        public float MinBelanja { get => minBelanja; set => minBelanja = value; }
        #endregion

        #region METHODS
        public static void CreateData(Promo p)
        {
            string sql = "insert into promos (id, tipe, nama, diskon, diskon_max, minimal_belanja) " +
                "values (" + p.Id + ", '" + p.Tipe.Replace("'", "\\'") + "','" + p.Nama.Replace("'", "\\'") + "'," + p.Diskon+ "," + p.MaxDiskon + "," + p.MinBelanja + ")";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static List<Promo> ReadData() => ReadData("", "");

        public static List<Promo> ReadData(string kriteria, string nilaiKriteria)
        {
            string sql;

            if (kriteria == "")
            {
                sql = "select * from promos";
            }
            else
            {
                sql = "select * from promos " +
                    "where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Promo> listPromo = new List<Promo>();

            while (hasil.Read() == true)
            {
                Promo p = new Promo(int.Parse(hasil.GetString(0)), hasil.GetString(1), hasil.GetString(2),
                    int.Parse(hasil.GetString(3)), int.Parse(hasil.GetString(4)), float.Parse(hasil.GetString(5)));

                listPromo.Add(p);
            }
            return listPromo;
        }

        public static Boolean UpdateData(Promo p)
        {
            string sql = "update promos set diskon=" + p.Diskon + ", diskon_max=" + p.MaxDiskon +
                ", minimal_belanja=" + p.MinBelanja +
                " where id=" + p.Id;

            return Koneksi.JalankanPerintahDML(sql) != 0;
        }

        public static Boolean DeleteData(string id)
        {
            string sql = "delete from promos where id='" + id + "'";

            return Koneksi.JalankanPerintahDML(sql) != 0;
        }

        public static Promo CekPromo(int id)
        {
            string sql = "select id, tipe, nama, diskon, diskon_max, minimal_belanja from promos " +
                    " where id=" + id;

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            while (hasil.Read() == true)
            {
                Promo p = new Promo(int.Parse(hasil.GetString(0)), hasil.GetString(1), hasil.GetString(2),
                    int.Parse(hasil.GetString(3)), int.Parse(hasil.GetString(4)), float.Parse(hasil.GetString(5)));

                return p;
            }

            return null;
        }
        #endregion
    }
}
