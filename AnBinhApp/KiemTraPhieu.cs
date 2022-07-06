using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace AnBinhApp
{
    public partial class KiemTraPhieu : Form
    {
        bool is_NhanVien = TrangChu.is_NhanVien;
        string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        public KiemTraPhieu()
        {
            InitializeComponent();

            if (!is_NhanVien)
            {
                label1.Hide();
                comboBox1.Hide();
                label2.Hide();
                textBox1.Hide();

                btnHoanTat.Location = new Point(btnHoanTat.Location.X, btnHoanTat.Location.Y - 65);
                this.Size = new Size(this.Size.Width, this.Size.Height - 55);
                SqlConnection myCon = new SqlConnection(connectionString);
                try
                {
                    myCon.Open();
                    SqlCommand cmd = new SqlCommand(
                        "select kh.MAKH, HOVATEN, GIOITINH, NGAYSINH, SDT, GOI, NGAYTIEM, DIACHI from PHIEUDKTIEM phieu join GOITIEMCHUNG goitc on phieu.GOI = goitc.TEN_GTC join KHACHHANG kh on phieu.MAKH = kh.MAKH where kh.MAKH = @username", myCon);
                    cmd.Parameters.Add("@username", SqlDbType.Int).Value = Int32.Parse(DangNhap.username);
                    SqlDataAdapter myAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    myAdapter.Fill(dt);
                    label46.Text = dt.Rows[0]["HOVATEN"].ToString();
                    label47.Text = dt.Rows[0]["GIOITINH"].ToString();
                    label48.Text = dt.Rows[0]["NGAYSINH"].ToString();
                    label49.Text = dt.Rows[0]["DIACHI"].ToString();
                    label50.Text = dt.Rows[0]["SDT"].ToString();
                    SqlCommand cm = new SqlCommand("Select datediff(yyyy,@birthday,@curdate)", myCon);
                    cm.Parameters.Add("@birthday", SqlDbType.DateTime).Value = label48.Text;
                    cm.Parameters.Add("@curdate", SqlDbType.DateTime).Value = DateTime.Now.ToString();
                    Int32 Tuoi = Int32.Parse(cm.ExecuteScalar().ToString());
                    if (Tuoi < 16)
                    {
                        SqlCommand cm2 = new SqlCommand("Select * from KHACHHANG kh join NGUOIGIAMHO ngh on kh.MAKH = ngh.MANGH where kh.MAKH = @ID", myCon);
                        cm2.Parameters.Add("@ID", SqlDbType.Int);
                        cm2.Parameters["@ID"].Value = dt.Rows[0]["MAKH"].ToString();
                        SqlDataAdapter adapter = new SqlDataAdapter(cm2);
                        DataTable dt2 = new DataTable();
                        adapter.Fill(dt2);
                        label51.Text = dt2.Rows[0]["TEN_NGH"].ToString();
                        label52.Text = dt2.Rows[0]["SDTGIAMHO"].ToString();
                        label53.Text = dt2.Rows[0]["MQH"].ToString();
                    }
                    else
                    {
                        label51.Text = "Khong co";
                        label52.Text = "Khong co";
                        label53.Text = "Khong co";
                    }
                    label54.Text = /*dt.Rows[0]["MOTA"].ToString();*/"Gói";
                    label55.Text = "Không";
                    label56.Text = dt.Rows[0]["NGAYTIEM"].ToString();
                    label57.Text = dt.Rows[0]["GOI"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra.");
                }
            }
            label2.Hide();
            textBox1.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Khác")
            {
                label2.Show();
                textBox1.Show();
            }
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
