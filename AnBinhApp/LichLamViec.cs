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
        private static int mallv;
        private static string ngaybd;
        private static string ngaykt;
        private static int ng_tao;
        private static string thoigiantao;

        internal static List<LichCaTruc> Dscatruc { get => dscatruc; set => dscatruc = value; }
        public static int Mallv { get => mallv; set => mallv = value; }
        public static string Ngaybd { get => ngaybd; set => ngaybd = value; }
        public static string Ngaykt { get => ngaykt; set => ngaykt = value; }
        public static int Ng_tao { get => ng_tao; set => ng_tao = value; }
        public static string Thoigiantao { get => thoigiantao; set => thoigiantao = value; }

        public static void khoiTao(string _ngaybd, string _ngaykt)
        {
            ngaybd = _ngaybd;
            ngaykt = _ngaykt;

            ng_tao = 0;
            thoigiantao = DateTime.Now.ToString();

            mallv = Int32.Parse(_ngaybd);
            
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
