using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMart_LIB
{
    class Chat
    {
        private Konsumen konsumen;
        private Pegawai pegawai;
        private List<string> listPesan;

        public Chat()
        {
            Konsumen = null;
            Pegawai = null;
            ListPesan = new List<string>();
        }

        public Chat(Konsumen konsumen, Pegawai pegawai)
        {
            Konsumen = konsumen;
            Pegawai = pegawai;
            ListPesan = new List<string>();
        }

        public Konsumen Konsumen { get => konsumen; set => konsumen = value; }
        public Pegawai Pegawai { get => pegawai; set => pegawai = value; }
        public List<string> ListPesan { get => listPesan; set => listPesan = value; }
    }
}
