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

        public static DataTable docLichRanh()
        {
            lichRanh = TongHopLichRanh.truyVanLichRanh();
            return lichRanh;
        }
        public static DataView dataFilter(string dk)
        {
            DataView view = lichRanh.DefaultView;
            view.RowFilter = dk;
            return view;
        }
    }
}
