using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnBinhApp
{
    class CaRanh
    {
        private static string sothutu;
        private static string ngay;
        private static string ca;
        private static string thu;

        public static string Sothutu { get => sothutu; set => sothutu = value; }
        public static string Ngay { get => ngay; set => ngay = value; }
        public static string Ca { get => ca; set => ca = value; }
        public static string Thu { get => thu; set => thu = value; }

        public static int taoSoThuTu()
        {
            int kq = 0;
            if (thu == "Thứ Hai")
            {
                kq = 20;
            }
            if (thu == "Thứ Ba")
            {
                kq = 30;
            }
            if (thu == "Thứ Tư")
            {
                kq = 40;
            }
            if (thu == "Thứ Năm")
            {
                kq = 50;
            }
            if (thu == "Thứ Sáu")
            {
                kq = 60;
            }
            if (thu == "Thứ Bảy")
            {
                kq = 70;
            }
            if (thu == "Chủ Nhật")
            {
                kq = 80;
            }
            else
            {
                kq = 90;
            }
            if (ca == "Sáng")
            {
                kq += 1;
            }
            if (ca == "Chiều")
            {
                kq += 2;
            }
            if (ca == "Tối")
            {
                kq += 3;
            }
            else
            {
                kq += 4;
            }
            return kq;
        }
        public static void khoiTao(string _thu, string _ngay, string _ca)
        {
            thu = _thu;
            ngay = _ngay;
            ca = _ca;
            sothutu = taoSoThuTu().ToString();
        }

        public static void themChiTietLichRanh()
        {
            LichRanhDB.themChiTietLichRanh();
        }
    }
}
