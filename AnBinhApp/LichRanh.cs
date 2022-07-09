using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;

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
            _maLR += DateTime.Now.Day * 100000;
            _maLR += DateTime.Now.Month * 1000000;
            _maLR += DateTime.Now.Hour * 10000;
            _maLR += DateTime.Now.Minute * 1000;
            _maLR += DateTime.Now.Second * 100;
            _maLR += DateTime.Parse(ngayBD).Day * 10;
            _maLR += DateTime.Parse(ngayBD).Month;
            maLR = _maLR.ToString();

        }
        public static void dangKyLichRanh()
        {
            LichRanhDB.themLichRanh();
        }

        

        public static DateTime FirstDateOfWeek(int year, int weekOfYear)
        {
            DateTime jan1 = new DateTime(year, 1, 1);
            int daysOffset = DayOfWeek.Thursday - jan1.DayOfWeek;

            // Use first Thursday in January to get first week of the year as
            // it will never be in Week 52/53
            DateTime firstThursday = jan1.AddDays(daysOffset);
            var cal = CultureInfo.CurrentCulture.Calendar;
            int firstWeek = cal.GetWeekOfYear(firstThursday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            var weekNum = weekOfYear;
            // As we're adding days to a date in Week 1,
            // we need to subtract 1 in order to get the right date for week #1
            if (firstWeek == 1)
            {
                weekNum -= 1;
            }

            // Using the first Thursday as starting week ensures that we are starting in the right year
            // then we add number of weeks multiplied with days
            var result = firstThursday.AddDays(weekNum * 7);

            // Subtract 3 days from Thursday to get Monday, which is the first weekday in ISO8601
            return result.AddDays(-3);
        }
        public static bool kiemTraSoBuoiRanh(int sobuoidangky)
        {
            int dieukien = LichRanhDB.tinhSoBuoiToiThieu();

            return sobuoidangky > dieukien;
        }
    }
    
}
