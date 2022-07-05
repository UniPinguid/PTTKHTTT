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
        public static DataTable truyVanLichRanh()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);

            sqlConnection.Open();

            string query = "SELECT nv.MANV, nv.TENNV, nv.TRUNGTAM, nv.VAITRO, c.THU, c.NGAY, c.CA ";
            query += "FROM NHANVIEN nv, LICHRANH r, CHITIETLICHRANH c ";
            query += "WHERE nv.MANV = r.NGUOIDK AND r.MALR = c.MALR ";
            query += "AND r.THOIGIANDK >= ALL (SELECT r1.THOIGIANDK FROM LICHRANH r1 WHERE r1.NGUOIDK = r.NGUOIDK) ";

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
