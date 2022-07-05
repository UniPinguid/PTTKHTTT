using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AnBinhApp
{
    class LichLamViecDB
    {
        public static void themLichLamViec()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            sqlConnection.Open();


            string statement = "INSERT INTO LICHLAMVIEC(MALLV, NGAYBATDAU, NGAYKETTHUC, THOIGIANTAO, LV_MANV) VALUES (";
            statement += LichLamViec.Mallv;
            statement += "'";
            statement += LichLamViec.Ngaybd;
            statement += "', '";
            statement += LichLamViec.Ngaykt;
            statement += "', '";
            statement += LichLamViec.Thoigiantao;
            statement += "', ";
            statement += LichLamViec.Ng_tao;
            statement += ")";


            SqlCommand sqlCommand = new SqlCommand(statement, sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.Text;

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

        }
        public static void themLichCaTruc()
        {
            string statement = "INSERT INTO LICHCATRUC(MACATRUC, MALLV, NGAY, THU, BUOI) VALUES (";
            statement += LichCaTruc.MaCaTruc;
            statement += ", ";
            statement += LichLamViec.Mallv;
            statement += ", '";
            statement += LichCaTruc.Ngay;
            statement += "', '";
            statement += LichCaTruc.Thu;
            statement += ", '";
            statement += LichCaTruc.Buoi;
            statement += "')";

            string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(statement, sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.Text;

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
    }
}
