using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AnBinhApp
{
    class LichRanh
    {
        private static string ngayBD;
        private static string ngayKT;
        private static string tgianDK;
        private static string nguoiDK;
        private static string maLR;

        public static string NgayBD { get => ngayBD; set => ngayBD = value; }
        public static string NgayKT { get => ngayKT; set => ngayKT = value; }
        public static string TgianDK { get => tgianDK; set => tgianDK = value; }
        public static string NguoiDK { get => nguoiDK; set => nguoiDK = value; }
        public static string MaLR { get => maLR; set => maLR = value; }

        public static DataTable docLichRanh(string manv, string ngaybd)
        {
            return LichRanhDB.docLichRanh(manv, ngaybd);
        }
        public static void khoiTao(string _ngaybd, string ngaykt)
        {
            ngayBD = _ngaybd;
            ngayKT = ngaykt;
            tgianDK = DateTime.Now.ToString();
            nguoiDK = DangNhap.username;
            int _maLR = 10000000;
            _maLR += Int32.Parse(nguoiDK);
            _maLR += DateTime.Now.Hour * 10000;
            _maLR += DateTime.Now.Minute * 1000;
            maLR = _maLR.ToString();

        }
        public static void dangKyLichRanh()
        {
            LichRanhDB.themLichRanh();
        }
    }
}
