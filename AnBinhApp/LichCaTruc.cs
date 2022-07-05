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
        private int buoi;
        private List<int> dsNhanVien;
        private int maCaTruc;
        private int maLLV;
        private string ngay;
        private string thu;

        public int Buoi { get => buoi; set => buoi = value; }
        public List<int> DsNhanVien { get => dsNhanVien; set => dsNhanVien = value; }
        public int MaCaTruc { get => maCaTruc; set => maCaTruc = value; }
        public int MaLLV { get => maLLV; set => maLLV = value; }
        public string Ngay { get => ngay; set => ngay = value; }
        public string Thu { get => thu; set => thu = value; }

        public static void khoiTao(DataTable data)
        {
            //tạo mã ca trực: ngày tháng năm + buổi


        }
    }
}
