using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Data;

namespace AnBinhApp
{
    class LichCaTruc
    {
        private static string buoi;
        public static List<int> dsNhanVien;
        private static int maCaTruc;
        private static string thu;

        public static string Buoi { get => buoi; set => buoi = value; }
        public static List<int> DsNhanVien { get => dsNhanVien; set => dsNhanVien = value; }
        public static int MaCaTruc { get => maCaTruc; set => maCaTruc = value; }
        public static string Ngay { get; set; }
        public static string Thu { get => thu; set => thu = value; }
        public static int taoMaCaTruc (string thu, string buoi)
        {
            int kq;
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
            if(thu == "Thứ Năm")
            {
                kq = 50;
            }
            if(thu == "Thứ Sáu")
            {
                kq = 60;
            }
            if(thu == "Thứ Bảy")
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
            if(buoi == "Sáng")
            {
                kq += 1;
            }
            if (buoi == "Chiều")
            {
                kq += 2;
            }
            if (buoi == "Tối")
            {
                kq += 3;
            }
            else
            {
                kq += 4;
            }
            return kq;
        }
        public static void khoiTao(string _ngay, string _buoi, string _thu, DataTable _data)
        {
            Ngay = _ngay;
            buoi = _buoi;
            thu = _thu;

            //if (dsNhanVien.Count != 0)
            //{
            //    dsNhanVien.Clear();
            //}
            dsNhanVien = new List<int>();
            for (int i = 0; i< _data.Rows.Count;i++)
            {
                if (_data.Rows[i]["CA"].ToString() == buoi)
                {
                    int temp = Int32.Parse(_data.Rows[i]["MANV"].ToString());
                    dsNhanVien.Add(temp);
                }
            }
            maCaTruc = LichCaTruc.taoMaCaTruc(thu, buoi);
            
        }
        public static void ghiLichCaTruc()
        {
            LichLamViecDB.themLichCaTruc();

            foreach (int t in dsNhanVien)
            {
                LichLamViecDB.themPhanCong(t);
            }
        }
        public static void themNhanVien(int maNV)
        {
            dsNhanVien.Add(maNV);
        }

        public static void xoaNhanVien(int manv)
        {
            dsNhanVien.Remove(manv);
        }
    }
    
}
