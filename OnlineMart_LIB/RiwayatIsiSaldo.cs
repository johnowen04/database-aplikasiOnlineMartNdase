using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class RiwayatIsiSaldo
    {
        private int id;
        private DateTime waktuIsi;
        private float saldo;
        private Konsumen konsumen;

        public RiwayatIsiSaldo()
        {
            Id = 0;
            WaktuIsi = DateTime.Now;
            Saldo = 0;
            Konsumen = null;
        }

        public RiwayatIsiSaldo(DateTime waktuIsi, float saldo, Konsumen konsumen)
        {
            WaktuIsi = waktuIsi;
            Saldo = saldo;
            Konsumen = konsumen;
        }
        public RiwayatIsiSaldo(int id, DateTime waktuIsi, float saldo, Konsumen konsumen)
        {
            Id = id;
            WaktuIsi = waktuIsi;
            Saldo = saldo;
            Konsumen = konsumen;
        }

        public int Id { get => id; set => id = value; }
        public DateTime WaktuIsi { get => waktuIsi; set => waktuIsi = value; }
        public float Saldo { get => saldo; set => saldo = value; }
        public Konsumen Konsumen { get => konsumen; set => konsumen = value; }

        public static void CreateData(RiwayatIsiSaldo ris)
        {
            string sql = "insert into riwayat_isi_saldos (waktu, isi_saldo, pelanggans_id) " +
                "values (now(), " + ris.Saldo + "," + ris.Konsumen.Id + ")";

            Koneksi.JalankanPerintahDML(sql);
        }

        public static List<RiwayatIsiSaldo> ReadData() => ReadData("", "");

        public static List<RiwayatIsiSaldo> ReadData(string kriteria, string nilaiKriteria)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "select ris.id, ris.waktu, ris.saldo, p.id, p.nama, p.email, p.password, p.telepon, p.saldo, p.poin " +
                    "from riwayat_isi_saldos as ris inner join pelanggans as p";
            }
            else
            {
                sql = "select ris.id, ris.waktu, ris.saldo, p.id, p.nama, p.email, p.password, p.telepon, p.saldo, p.poin " +
                    "from riwayat_isi_saldos as ris inner join pelanggans as p " +
                    "where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<RiwayatIsiSaldo> listRiwayatIsiSaldo = new List<RiwayatIsiSaldo>();

            while (hasil.Read() == true)
            {
                Konsumen k = new Konsumen(hasil.GetInt32(3), hasil.GetString(4), hasil.GetString(5), hasil.GetString(6), hasil.GetString(7), hasil.GetFloat(8), hasil.GetInt32(9));

                RiwayatIsiSaldo ris = new RiwayatIsiSaldo(hasil.GetInt32(0), hasil.GetDateTime(1), hasil.GetInt32(2), k);

                listRiwayatIsiSaldo.Add(ris);
            }
            return listRiwayatIsiSaldo;
        }
    }
}
