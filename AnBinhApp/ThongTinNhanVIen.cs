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
    public partial class ThongTinNhanVIen : Form
    {
        private static string pdid = null;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        public ThongTinNhanVIen()
        {
            InitializeComponent();
        }

        private void clickClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongTinNhanVIen_Load(object sender, EventArgs e)
        {
            pdid = DSNhanVien.getid();

            if (pdid != null)
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                adapter = new SqlDataAdapter("exec getdetailInfoNV @nv = " + pdid , conn);
                dt = new DataTable();
                adapter.Fill(dt);

                Tenlbl.Text = dt.Rows[0][1].ToString();
                vitrilbl.Text = dt.Rows[0][7].ToString();
                label14.Text = dt.Rows[0][2].ToString();
                label9.Text = dt.Rows[0][4].ToString();
                label11.Text = dt.Rows[0][6].ToString();
                CMNDlbl.Text = dt.Rows[0][3].ToString();
                VaiTrolbl.Text = dt.Rows[0][7].ToString() + " " + dt.Rows[0][9].ToString();
                Trungtamlbl.Text = dt.Rows[0][13].ToString();
                sbtlbl.Text = dt.Rows[0][11].ToString();
                Emaillbl.Text = dt.Rows[0][5].ToString();
                adapter = new SqlDataAdapter("EXEC getBangCap @kh = " + pdid, conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView3.DataSource = dt;
            }
        }
    }
}
