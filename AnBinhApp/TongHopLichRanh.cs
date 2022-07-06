using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace AnBinhApp
{
    class TongHopLichRanh
    {
        public static DataTable truyVanLichRanhTheoNgay(string thu)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            sqlConnection.Open();

            string query = "SELECT nv.MANV, nv.HOTEN, nv.TRUNGTAM, nv.VAITRO, c.CA ";
            query += "FROM NHANVIEN nv, LICHRANH r, CHITIETLICHRANH c ";
            query += "WHERE nv.MANV = r.LR_MANV AND r.MALICHRANH = c.MALICHRANH ";
            query += "AND r.THOIGIANDANGKY >= ALL (SELECT r1.THOIGIANDANGKY FROM LICHRANH r1 WHERE r1.LR_MANV = r.LR_MANV) ";
            query += "AND c.THU LIKE N'";
            query += thu;
            query += "'";
            
             

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.Text;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }

        public static DataTable truyVanLichRanhCoDieuKien(string thu, string trungtam, string vaitro)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            sqlConnection.Open();

            string query = "SELECT nv.MANV, nv.HOTEN, nv.TRUNGTAM, nv.VAITRO, c.CA ";
            query += "FROM NHANVIEN nv, LICHRANH r, CHITIETLICHRANH c ";
            query += "WHERE nv.MANV = r.LR_MANV AND r.MALICHRANH = c.MALICHRANH ";
            query += "AND r.THOIGIANDANGKY >= ALL (SELECT r1.THOIGIANDANGKY FROM LICHRANH r1 WHERE r1.LR_MANV = r.LR_MANV) ";
            query += "AND nv.VAITRO IS NOT NULL AND c.CA IS NOT NULL ";
            query += "AND c.THU LIKE N'";
            query += thu;
            query += "' ";
            if (trungtam != "")
            {
                query += " AND nv.TRUNGTAM = ";
                query += trungtam;
            }

            if(vaitro != "")
            {
                query += " AND nv.VAI TRO LIKE N'";
                query += trungtam;
                query += "' ";
            }



            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.Text;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            sqlConnection.Close();

            return dataTable;
        }
    }


}
