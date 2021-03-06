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
    class LichRanhDB
    {
        public static DataTable docLichRanh(string manv, string ngaybd)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            sqlConnection.Open();

            string query = "select ct.THU, ct.BUOI ";
            query += "from LICHLAMVIEC lv, LICHCATRUC ct, PHANCONG pc ";
            query += "where lv.MALICHLV = ct.MALICHLV AND ct.MALICHLV = pc.MALLV and ct.MACATRUC = pc.MACATRUC ";
            
            if(ngaybd != "")
            {
                query += " AND lv.NGAYBATDAU = '";
                query += ngaybd;
                query += "'";
            }
            
            if (manv != "")
            {
                query += " and pc.MANV = ";
                query += manv;
            }


            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.Text;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }

        public static void themLichRanh()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            sqlConnection.Open();


            string statement = "INSERT INTO LICHRANH(MALICHRANH, NGAYBATDAU, NGAYKETTHUC, THOIGIANDANGKY, LR_MANV) VALUES (";
            statement += LichRanh.MaLR;
            statement += ", '";
            statement += LichRanh.NgayBD;
            statement += "', '";
            statement += LichRanh.NgayKT;
            statement += "', '";
            statement += LichRanh.TgianDK;
            statement += "', ";
            statement += LichRanh.NguoiDK;
            statement += ")";


            SqlCommand sqlCommand = new SqlCommand(statement, sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.Text;

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public static void themChiTietLichRanh()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            sqlConnection.Open();


            string statement = "INSERT INTO CHITIETLICHRANH(MALICHRANH, SOTHUTU, THU, NGAY, CA) VALUES (";
            statement += LichRanh.MaLR;
            statement += ", ";
            statement += CaRanh.Sothutu;
            statement += ", N'";
            statement += CaRanh.Thu;
            statement += "', '";
            statement += CaRanh.Ngay;
            statement += "', N'";
            statement += CaRanh.Ca;
            statement += "')";

            SqlCommand sqlCommand = new SqlCommand(statement, sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.Text;

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public static int tinhSoBuoiToiThieu()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            sqlConnection.Open();


            string statement = "SELECT SOBUOITRUCTOITHIEU FROM NHANVIEN WHERE MANV = ";
            statement += DangNhap.username;

            


            SqlCommand sqlCommand = new SqlCommand(statement, sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.Text;

            int kq = Int32.Parse(sqlCommand.ExecuteScalar().ToString());

            sqlConnection.Close();

            return kq;
        }
    }
}
