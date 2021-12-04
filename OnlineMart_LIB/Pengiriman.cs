using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Pengiriman
    {
        private string namaKonsumen;
        private string alamatTujuan;
        private float komisi;

        public Pengiriman()
        {
            NamaKonsumen = "";
            AlamatTujuan = "";
            Komisi = 0;
        }

        public Pengiriman(string namaKonsumen, string alamatTujuan, float komisi)
        {
            NamaKonsumen = namaKonsumen;
            AlamatTujuan = alamatTujuan;
            Komisi = komisi;
        }

        public string NamaKonsumen { get => namaKonsumen; set => namaKonsumen = value; }
        public string AlamatTujuan { get => alamatTujuan; set => alamatTujuan = value; }
        public float Komisi { get => komisi; set => komisi = value; }

        public static List<Pengiriman> ReadData(Kurir ku) => ReadData(ku, "", "");

        public static List<Pengiriman> ReadData(Kurir ku, string kriteria, string nilaiKriteria)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "select p.nama, o.alamat_tujuan, (o.ongkos_kirim * 0.8) as komisi " +
                    "from orders as o inner join pelanggans as p on o.pelanggans_id=p.id" + 
                    " where o.drivers_id = " + ku.Id;
            }
            else
            {
                sql = "select p.nama, o.alamat_tujuan, (o.ongkos_kirim * 0.8) as komisi " +
                    "from orders as o inner join pelanggans as p on o.pelanggans_id=p.id " +
                    "where " + kriteria + " like '%" + nilaiKriteria + "%' and o.drivers_id = " + ku.Id;
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Pengiriman> listPengiriman = new List<Pengiriman>();

            while (hasil.Read() == true)
            {
                Pengiriman p = new Pengiriman(hasil.GetString(0), hasil.GetString(1), float.Parse(hasil.GetString(2)));

                listPengiriman.Add(p);
            }
            return listPengiriman;
        }
    }
}
