using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AnBinhApp
{
    class LichRanhTongHop
    {
        private static DataTable lichRanh;

        public static DataTable LichRanh { get => lichRanh; set => lichRanh = value; }

        public static DataTable docLichRanhTheoNgay(string thu)
        {
            lichRanh = TongHopLichRanh.truyVanLichRanhTheoNgay(thu);
            return lichRanh;
        }
        public static DataTable docLichRanhCoDieuKien(string thu, string trungtam, string vaitro)
        {
            lichRanh = TongHopLichRanh.truyVanLichRanhCoDieuKien(thu,trungtam,vaitro);
            return lichRanh;
        }
        
    }
}
