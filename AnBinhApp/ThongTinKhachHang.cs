using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnBinhApp
{
    
    public partial class ThongTinKhachHang : Form
    {
        private static string pdid = null;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        public ThongTinKhachHang()
        {
            InitializeComponent();
        }

        private void clickClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongTinKhachHang_Load(object sender, EventArgs e)
        {
            pdid = DSKhachHang.getid();

            if (pdid != null)
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                adapter = new SqlDataAdapter("SELECT * FROM KHACHHANG WHERE MAKH = '" + pdid + "'", conn);
                dt = new DataTable();
                adapter.Fill(dt);

                label1.Text = dt.Rows[0][1].ToString();
                label14.Text = dt.Rows[0][5].ToString();
                label9.Text = dt.Rows[0][4].ToString();
                label11.Text = dt.Rows[0][3].ToString();

                adapter = new SqlDataAdapter("EXEC getGiamHo @kh = " + pdid, conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView3.DataSource = dt;

                adapter = new SqlDataAdapter("EXEC getPhieuDk @kh = " + pdid, conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
