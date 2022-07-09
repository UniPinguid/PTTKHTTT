using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Data;

namespace AnBinhApp
{
    class LichLamViec
    {
        private static List<LichCaTruc> dscatruc;
        private static string mallv;
        private static string ngaybd;
        private static string ngaykt;
        private static string ng_tao;
        private static string thoigiantao;
        private static int trangthaikhoitao;

        internal static List<LichCaTruc> Dscatruc { get => dscatruc; set => dscatruc = value; }
        
        public static string Ngaybd { get => ngaybd; set => ngaybd = value; }
        public static string Ngaykt { get => ngaykt; set => ngaykt = value; }
        
        public static string Thoigiantao { get => thoigiantao; set => thoigiantao = value; }
        public static int Trangthaikhoitao { get => trangthaikhoitao; set => trangthaikhoitao = value; }
        public static string Ng_tao { get => ng_tao; set => ng_tao = value; }
        public static string Mallv { get => mallv; set => mallv = value; }

        public static void khoiTao(string _ngaybd, string _ngaykt)
        {
            ngaybd = _ngaybd;
            ngaykt = _ngaykt;

            ng_tao = DangNhap.username;
            thoigiantao = DateTime.Now.ToString();

            
            int _maLR = 10000000;
            _maLR += DateTime.Now.Day * 100000;
            _maLR += DateTime.Now.Month * 1000000;
            _maLR += DateTime.Now.Hour * 10000;
            _maLR += DateTime.Now.Minute * 1000;
            _maLR += DateTime.Now.Second * 100;
            _maLR += DateTime.Parse(ngaybd).Day * 10;
            _maLR += DateTime.Parse(ngaybd).Month;
            mallv = _maLR.ToString();
        }
        public static void themCaTruc(LichCaTruc ct)
        {
            dscatruc.Add(ct);
        }

        public static void ghiLichLamViec()
        {
            LichLamViecDB.themLichLamViec();
        }
    }
}
