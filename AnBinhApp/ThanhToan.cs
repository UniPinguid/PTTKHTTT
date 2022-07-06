using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace AnBinhApp
{
    public partial class ThanhToan : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        public ThanhToan()
        {
            InitializeComponent();
            hoadonMotLan.Hide();
            hoadonTraGop.Hide();
            btnThanhToan.Hide();

            notification(TrangChu.co_ThongBao);
            sideBarCollapsible(TrangChu.ds_collapsible, TrangChu.chucnang_collapsible, TrangChu.taikhoan_collapsible);
        }

        // Start of
        // Styling and visualization

        bool is_Thoat_clicked = false;
        bool is_DSPhieuTiem_clicked = false;

        private void notification(bool co_ThongBao)
        {
            if (TrangChu.co_ThongBao == false)
            {
                picture_dauThongBao.Hide();
            }
            else
            {
                //
            }
        }

        private void sideBarCollapsible(bool ds_collapsible, bool chucnang_collapsible, bool taikhoan_collapsible)
        {
            if (ds_collapsible == false)
            {
                collapsible_ds.Image = Image.FromFile("../../svg/collapsible off.png");
                panel_dsKH.Hide();
                panel_DSPhieuTiem.Hide();
                panel_DSVacxin.Hide();
                panel_DSNhanVien.Hide();

                label_chucNang.Location = new Point(label_chucNang.Location.X, label_chucNang.Location.Y - 224);
                collapsible_chucNang.Location = new Point(collapsible_chucNang.Location.X, collapsible_chucNang.Location.Y - 224);
                panel_DatMuaVacXin.Location = new Point(panel_DatMuaVacXin.Location.X, panel_DatMuaVacXin.Location.Y - 224);
                panel_XemLich.Location = new Point(panel_XemLich.Location.X, panel_XemLich.Location.Y - 224);
                panel_PhanCong.Location = new Point(panel_PhanCong.Location.X, panel_PhanCong.Location.Y - 224);

                label_taiKhoan.Location = new Point(label_taiKhoan.Location.X, label_taiKhoan.Location.Y - 224);
                collapsible_taiKhoan.Location = new Point(collapsible_taiKhoan.Location.X, collapsible_taiKhoan.Location.Y - 224);
                panel_TaiKhoan.Location = new Point(panel_TaiKhoan.Location.X, panel_TaiKhoan.Location.Y - 224);
                panel_DangXuat.Location = new Point(panel_DangXuat.Location.X, panel_DangXuat.Location.Y - 224);
                panel_Thoat.Location = new Point(panel_Thoat.Location.X, panel_Thoat.Location.Y - 224);

                panel2.Location = new Point(panel2.Location.X, panel2.Location.Y - 224);
            }


            if (chucnang_collapsible == false)
            {
                collapsible_chucNang.Image = Image.FromFile("../../svg/collapsible off.png");
                panel_DatMuaVacXin.Hide();
                panel_XemLich.Hide();
                panel_PhanCong.Hide();

                label_taiKhoan.Location = new Point(label_taiKhoan.Location.X, label_taiKhoan.Location.Y - 168);
                collapsible_taiKhoan.Location = new Point(collapsible_taiKhoan.Location.X, collapsible_taiKhoan.Location.Y - 168);
                panel_TaiKhoan.Location = new Point(panel_TaiKhoan.Location.X, panel_TaiKhoan.Location.Y - 168);
                panel_DangXuat.Location = new Point(panel_DangXuat.Location.X, panel_DangXuat.Location.Y - 168);
                panel_Thoat.Location = new Point(panel_Thoat.Location.X, panel_Thoat.Location.Y - 168);

                panel2.Location = new Point(panel2.Location.X, panel2.Location.Y - 168);
            }


            if (taikhoan_collapsible == false)
            {
                collapsible_taiKhoan.Image = Image.FromFile("../../svg/collapsible off.png");
                panel_TaiKhoan.Hide();
                panel_DangXuat.Hide();
                panel_Thoat.Hide();

                panel2.Hide();
            }

        }

        private void ThongBao_enter(object sender, EventArgs e)
        {
            pictureThongBao.Image = Image.FromFile("../../svg/bell hover.png");
        }
        private void ThongBao_leave(object sender, EventArgs e)
        {
            pictureThongBao.Image = Image.FromFile("../../svg/bell.png");
        }

        private void TrangChu_enter(object sender, EventArgs e)
        {
            panel_TrangChu.BackColor = Color.FromArgb(37, 58, 128);
        }
        private void TrangChu_leave(object sender, EventArgs e)
        {
            panel_TrangChu.BackColor = Color.FromArgb(38, 21, 92);
        }
        private void DangKyTiem_enter(object sender, EventArgs e)
        {
            panel_DangKyTiem.BackColor = Color.FromArgb(37, 58, 128);
        }
        private void DangKyTiem_leave(object sender, EventArgs e)
        {
            panel_DangKyTiem.BackColor = Color.FromArgb(38, 21, 92);
        }
        private void QTTC_enter(object sender, EventArgs e)
        {
            panel_QTTC.BackColor = Color.FromArgb(37, 58, 128);
        }
        private void QTTC_leave(object sender, EventArgs e)
        {
            panel_QTTC.BackColor = Color.FromArgb(38, 21, 92);
        }

        private void dsKH_enter(object sender, EventArgs e)
        {
            panel_dsKH.BackColor = Color.FromArgb(37, 58, 128);
        }
        private void dsKH_leave(object sender, EventArgs e)
        {
            panel_dsKH.BackColor = Color.FromArgb(38, 21, 92);
        }
        private void dsPhieuTiem_enter(object sender, EventArgs e)
        {
            panel_DSPhieuTiem.BackColor = Color.FromArgb(37, 58, 128);
        }
        private void dsPhieuTiem_leave(object sender, EventArgs e)
        {
            panel_DSPhieuTiem.BackColor = Color.FromArgb(38, 21, 92);
        }
        private void dsVacXin_enter(object sender, EventArgs e)
        {
            panel_DSVacxin.BackColor = Color.FromArgb(37, 58, 128);
        }
        private void dsVacXin_leave(object sender, EventArgs e)
        {
            panel_DSVacxin.BackColor = Color.FromArgb(38, 21, 92);
        }
        private void dsNhanVien_enter(object sender, EventArgs e)
        {
            panel_DSNhanVien.BackColor = Color.FromArgb(37, 58, 128);
        }
        private void dsNhanVien_leave(object sender, EventArgs e)
        {
            panel_DSNhanVien.BackColor = Color.FromArgb(38, 21, 92);
        }

        private void datMuaVacxin_enter(object sender, EventArgs e)
        {
            panel_DatMuaVacXin.BackColor = Color.FromArgb(37, 58, 128);
        }
        private void datMuaVacxin_leave(object sender, EventArgs e)
        {
            panel_DatMuaVacXin.BackColor = Color.FromArgb(38, 21, 92);
        }
        private void xemLich_enter(object sender, EventArgs e)
        {
            panel_XemLich.BackColor = Color.FromArgb(37, 58, 128);
        }
        private void xemLich_leave(object sender, EventArgs e)
        {
            panel_XemLich.BackColor = Color.FromArgb(38, 21, 92);
        }
        private void phanCong_enter(object sender, EventArgs e)
        {
            panel_PhanCong.BackColor = Color.FromArgb(37, 58, 128);
        }
        private void phanCong_leave(object sender, EventArgs e)
        {
            panel_PhanCong.BackColor = Color.FromArgb(38, 21, 92);
        }

        private void taiKhoan_enter(object sender, EventArgs e)
        {
            panel_TaiKhoan.BackColor = Color.FromArgb(37, 58, 128);
        }
        private void taiKhoan_leave(object sender, EventArgs e)
        {
            panel_TaiKhoan.BackColor = Color.FromArgb(38, 21, 92);
        }
        private void DangXuat_enter(object sender, EventArgs e)
        {
            panel_DangXuat.BackColor = Color.FromArgb(37, 58, 128);
        }
        private void DangXuat_leave(object sender, EventArgs e)
        {
            panel_DangXuat.BackColor = Color.FromArgb(38, 21, 92);
        }
        private void Thoat_enter(object sender, EventArgs e)
        {
            panel_Thoat.BackColor = Color.FromArgb(37, 58, 128);
        }
        private void Thoat_leave(object sender, EventArgs e)
        {
            panel_Thoat.BackColor = Color.FromArgb(38, 21, 92);
        }

        private void moRongDS_click(object sender, EventArgs e)
        {
            if (TrangChu.ds_collapsible == true)
            {
                collapsible_ds.Image = Image.FromFile("../../svg/collapsible off.png");
                TrangChu.ds_collapsible = false;

                panel_dsKH.Hide();
                panel_DSPhieuTiem.Hide();
                panel_DSVacxin.Hide();
                panel_DSNhanVien.Hide();

                label_chucNang.Location = new Point(label_chucNang.Location.X, label_chucNang.Location.Y - 224);
                collapsible_chucNang.Location = new Point(collapsible_chucNang.Location.X, collapsible_chucNang.Location.Y - 224);
                panel_DatMuaVacXin.Location = new Point(panel_DatMuaVacXin.Location.X, panel_DatMuaVacXin.Location.Y - 224);
                panel_XemLich.Location = new Point(panel_XemLich.Location.X, panel_XemLich.Location.Y - 224);
                panel_PhanCong.Location = new Point(panel_PhanCong.Location.X, panel_PhanCong.Location.Y - 224);

                label_taiKhoan.Location = new Point(label_taiKhoan.Location.X, label_taiKhoan.Location.Y - 224);
                collapsible_taiKhoan.Location = new Point(collapsible_taiKhoan.Location.X, collapsible_taiKhoan.Location.Y - 224);
                panel_TaiKhoan.Location = new Point(panel_TaiKhoan.Location.X, panel_TaiKhoan.Location.Y - 224);
                panel_DangXuat.Location = new Point(panel_DangXuat.Location.X, panel_DangXuat.Location.Y - 224);
                panel_Thoat.Location = new Point(panel_Thoat.Location.X, panel_Thoat.Location.Y - 224);

                panel2.Location = new Point(panel2.Location.X, panel_Thoat.Location.Y - 224);
            }
            else
            {
                collapsible_ds.Image = Image.FromFile("../../svg/collapsible on.png");
                TrangChu.ds_collapsible = true;

                panel_dsKH.Show();
                panel_DSPhieuTiem.Show();
                panel_DSVacxin.Show();
                panel_DSNhanVien.Show();

                label_chucNang.Show();

                label_chucNang.Location = new Point(label_chucNang.Location.X, label_chucNang.Location.Y + 224);
                collapsible_chucNang.Location = new Point(collapsible_chucNang.Location.X, collapsible_chucNang.Location.Y + 224);
                panel_DatMuaVacXin.Location = new Point(panel_DatMuaVacXin.Location.X, panel_DatMuaVacXin.Location.Y + 224);
                panel_XemLich.Location = new Point(panel_XemLich.Location.X, panel_XemLich.Location.Y + 224);
                panel_PhanCong.Location = new Point(panel_PhanCong.Location.X, panel_PhanCong.Location.Y + 224);

                label_taiKhoan.Location = new Point(label_taiKhoan.Location.X, label_taiKhoan.Location.Y + 224);
                collapsible_taiKhoan.Location = new Point(collapsible_taiKhoan.Location.X, collapsible_taiKhoan.Location.Y + 224);
                panel_TaiKhoan.Location = new Point(panel_TaiKhoan.Location.X, panel_TaiKhoan.Location.Y + 224);
                panel_DangXuat.Location = new Point(panel_DangXuat.Location.X, panel_DangXuat.Location.Y + 224);
                panel_Thoat.Location = new Point(panel_Thoat.Location.X, panel_Thoat.Location.Y + 224);

                panel2.Location = new Point(panel2.Location.X, panel_Thoat.Location.Y + 224);
            }
        }
        private void moRongChucNang_click(object sender, EventArgs e)
        {
            if (TrangChu.chucnang_collapsible == true)
            {
                TrangChu.chucnang_collapsible = false;

                collapsible_chucNang.Image = Image.FromFile("../../svg/collapsible off.png");
                panel_DatMuaVacXin.Hide();
                panel_XemLich.Hide();
                panel_PhanCong.Hide();

                label_taiKhoan.Location = new Point(label_taiKhoan.Location.X, label_taiKhoan.Location.Y - 168);
                collapsible_taiKhoan.Location = new Point(collapsible_taiKhoan.Location.X, collapsible_taiKhoan.Location.Y - 168);
                panel_TaiKhoan.Location = new Point(panel_TaiKhoan.Location.X, panel_TaiKhoan.Location.Y - 168);
                panel_DangXuat.Location = new Point(panel_DangXuat.Location.X, panel_DangXuat.Location.Y - 168);
                panel_Thoat.Location = new Point(panel_Thoat.Location.X, panel_Thoat.Location.Y - 168);

                panel2.Location = new Point(panel2.Location.X, panel2.Location.Y - 168);
            }
            else
            {
                TrangChu.chucnang_collapsible = true;

                collapsible_chucNang.Image = Image.FromFile("../../svg/collapsible on.png");
                panel_DatMuaVacXin.Show();
                panel_XemLich.Show();
                panel_PhanCong.Show();

                label_taiKhoan.Location = new Point(label_taiKhoan.Location.X, label_taiKhoan.Location.Y + 168);
                collapsible_taiKhoan.Location = new Point(collapsible_taiKhoan.Location.X, collapsible_taiKhoan.Location.Y + 168);
                panel_TaiKhoan.Location = new Point(panel_TaiKhoan.Location.X, panel_TaiKhoan.Location.Y + 168);
                panel_DangXuat.Location = new Point(panel_DangXuat.Location.X, panel_DangXuat.Location.Y + 168);
                panel_Thoat.Location = new Point(panel_Thoat.Location.X, panel_Thoat.Location.Y + 168);

                panel2.Location = new Point(panel2.Location.X, panel2.Location.Y + 168);
            }
        }
        private void moRongTaiKhoan_click(object sender, EventArgs e)
        {
            if (TrangChu.taikhoan_collapsible == true)
            {
                TrangChu.taikhoan_collapsible = false;

                collapsible_taiKhoan.Image = Image.FromFile("../../svg/collapsible off.png");
                panel_TaiKhoan.Hide();
                panel_DangXuat.Hide();
                panel_Thoat.Hide();

                panel2.Hide();
            }
            else
            {
                TrangChu.taikhoan_collapsible = true;

                collapsible_taiKhoan.Image = Image.FromFile("../../svg/collapsible on.png");
                panel_TaiKhoan.Show();
                panel_DangXuat.Show();
                panel_Thoat.Show();

                panel2.Show();
            }
        }

        // End of
        // Styling and visualization


        // Start of
        // Transitioning
        private void ThongBao_click(object sender, EventArgs e)
        {
            pictureThongBao.Image = Image.FromFile("../../svg/bell click.png");
            ThongBao thongBaoForm = new ThongBao();
            thongBaoForm.Show();
            this.Close();
        }
        private void TrangChu_click(object sender, EventArgs e)
        {
            panel_TrangChu.BackColor = Color.FromArgb(73, 155, 242);

            // homepage_leave(sender, e);
            DangKyTiem_leave(sender, e);
            dsPhieuTiem_leave(sender, e);
            DangXuat_leave(sender, e);
            Thoat_leave(sender, e);

            TrangChu trangChuForm = new TrangChu();
            trangChuForm.Show();
            this.Close();
        }
        private void DangKyTiem_click(object sender, EventArgs e)
        {
            panel_DangKyTiem.BackColor = Color.FromArgb(73, 155, 242);
            is_Thoat_clicked = false;

            TrangChu_leave(sender, e);
            // vacReg_leave(sender, e);
            dsPhieuTiem_leave(sender, e);
            DangXuat_leave(sender, e);
            Thoat_leave(sender, e);

            DangKyTiemNgua dktn = new DangKyTiemNgua();
            dktn.Show();
            this.Hide();
        }
        private void dsPhieuTiem_click(object sender, EventArgs e)
        {
            panel_DSPhieuTiem.BackColor = Color.FromArgb(73, 155, 242);
            is_Thoat_clicked = false;

            TrangChu_leave(sender, e);
            DangKyTiem_leave(sender, e);
            // listVac_leave(sender, e);
            DangXuat_leave(sender, e);
            Thoat_leave(sender, e);

            if (TrangChu.is_NhanVien)
            {
                DSPhieuTiem dsPhieuTiemForm = new DSPhieuTiem();
                dsPhieuTiemForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Chỉ có nhân viên mới được sử dụng tính năng này!", "Thông báo");
                is_DSPhieuTiem_clicked = false;
                dsPhieuTiem_leave(sender, e);
            }
        }

        private void datMuaVacxin_click(object sender, EventArgs e)
        {
            DatMuaVacxin datMuaVacxinForm = new DatMuaVacxin();
            datMuaVacxinForm.Show();
            this.Close();
        }
        private void DangXuat_click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc là muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                TrangChu.is_login = false;
                TrangChu.is_NhanVien = false;

                DangNhap dangNhap = new DangNhap();
                this.Hide();
                TrangChu trangChu = new TrangChu();
                trangChu.Show();
                dangNhap.ShowDialog();
            }
            else if (dialogResult == DialogResult.No)
            {
                //
            }
        }
        private void Thoat_click(object sender, EventArgs e)
        {
            panel_Thoat.BackColor = Color.FromArgb(73, 155, 242);
            is_Thoat_clicked = true;

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc là muốn thoát không?", "Thoát An Binh", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                var formToShow = Application.OpenForms.Cast<Form>().FirstOrDefault(c => c is DangNhap);
                if (formToShow != null)
                {
                    formToShow.Show();
                    formToShow.Close();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                is_Thoat_clicked = false;
                Thoat_leave(sender, e);
            }
        }
        private void clickThanhToan(object sender, EventArgs e)
        {
            ThanhToan thanhToanForm = new ThanhToan();
            this.Hide();
            thanhToanForm.ShowDialog();
        }

        // End of
        // Transitioning

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            ngayttMotLan.Text = DateTime.Now.ToShortDateString();
            ngayttTraGop.Text = DateTime.Now.ToShortDateString();
        }

        private void rBtnMotLan_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnMotLan.Checked)
            {
                SqlConnection myCon = new SqlConnection(connectionString);
                hoadonMotLan.Show();
                btnThanhToan.Show();
                //btnThanhToan.Location = new Point(1225, 470);
                btnThanhToan.Location = new Point(1378, 588);
                try
                {
                    myCon.Open();
                    SqlDataAdapter myAdapter = new SqlDataAdapter("select top 1 * from PHIEUDKTIEM phieu join GOITIEMCHUNG goitc on phieu.GOI = goitc.TEN_GTC where TINHTRANG = N'1' and MAKH = " + DangNhap.username, myCon);
                    DataTable dt = new DataTable();
                    myAdapter.Fill(dt);
                    maPhieuDK.Text = dt.Rows[0]["MAPHIEU"].ToString();
                    donGiaMotLan.Text = dt.Rows[0]["DONGIA"].ToString();
                    phiDVMotLan.Text = "100000";
                    thanhtienMotLan.Text = (Int32.Parse(donGiaMotLan.Text) + Int32.Parse(phiDVMotLan.Text)).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn đã thanh toán thành công cho Phiếu Đăng Ký Tiêm này.");
                }
                myCon.Close();
            }
            else
            {
                hoadonMotLan.Hide();
            }
        }

        private void rBtnTraGop_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnTraGop.Checked)
            {
                //hoadonTraGop.Location = new Point(801, 179);
                //hoadonTraGop.Show();
                //btnThanhToan.Show();
                //btnThanhToan.Location = new Point(1225, 505);
                SqlConnection myCon = new SqlConnection(connectionString);
                hoadonTraGop.Location = new Point(901, 224);
                hoadonTraGop.Show();
                btnThanhToan.Show();
                btnThanhToan.Location = new Point(1378, 628);
                try
                {
                    myCon.Open();
                    SqlDataAdapter myAdapter = new SqlDataAdapter("select top 1 * from PHIEUDKTIEM phieu join GOITIEMCHUNG goitc on phieu.GOI = goitc.TEN_GTC where TINHTRANG = N'1' and MAKH = " + DangNhap.username, myCon);
                    DataTable dt = new DataTable();
                    myAdapter.Fill(dt);
                    label24.Text = dt.Rows[0]["MAPHIEU"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn đã thanh toán thành công cho Phiếu Đăng Ký Tiêm này.");
                }
                myCon.Close();
            }
            else
            {
                hoadonTraGop.Hide();
            }
        }

        private void clickXemPhieu(object sender, EventArgs e)
        {
            KiemTraPhieu phieu = new KiemTraPhieu();
            phieu.Show();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection(connectionString);
            try
            {
                myCon.Open();
                SqlCommand myCommand = new SqlCommand("sp_THANHTOAN", myCon);
                myCommand.CommandType = CommandType.StoredProcedure;
                int solanthanhtoantrongngay;
                SqlCommand sqlCommand = new SqlCommand("Select top 1 MAHD, THOIGIANTHANHTOAN from HOADON order by MAHD desc", myCon);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    string p_thoigian = reader.GetDateTime(1).ToShortDateString();
                    if (Convert.ToDateTime(DateTime.Now.ToShortDateString()) > Convert.ToDateTime(p_thoigian)) solanthanhtoantrongngay = 0;
                    else
                    {
                        string p_mahd = reader.GetInt32(0).ToString();
                        string id_mahd = p_mahd.Remove(0, 6);
                        solanthanhtoantrongngay = Int32.Parse(id_mahd);
                    }
                }
                else solanthanhtoantrongngay = 0;
                reader.Close();
                solanthanhtoantrongngay += 1;
                string mahoadon = String.Format("{0:yy}", Convert.ToDateTime(ngayttMotLan.Text)) + String.Format("{0:MM}", Convert.ToDateTime(ngayttMotLan.Text)) + String.Format("{0:dd}", Convert.ToDateTime(ngayttMotLan.Text)) + solanthanhtoantrongngay.ToString();
                if (rBtnMotLan.Checked)
                {
                    myCommand.Parameters.Add("@mahd", SqlDbType.Int).Value = Int32.Parse(mahoadon);
                    myCommand.Parameters.Add("@hinhthuc", SqlDbType.NVarChar).Value = rBtnMotLan.Text;
                    myCommand.Parameters.Add("@thanhtien", SqlDbType.Float).Value = float.Parse(thanhtienMotLan.Text);
                    myCommand.Parameters.Add("@thoigian", SqlDbType.DateTime).Value = ngayttMotLan.Text;
                    myCommand.Parameters.Add("@makh", SqlDbType.Int).Value = Int32.Parse(DangNhap.username);
                    myCommand.Parameters.Add("@maphieu", SqlDbType.Int).Value = Int32.Parse(maPhieuDK.Text);
                }
                else
                {
                    myCommand.Parameters.Add("@mahd", SqlDbType.Int).Value = Int32.Parse(mahoadon);
                    myCommand.Parameters.Add("@hinhthuc", SqlDbType.NVarChar).Value = rBtnTraGop.Text + " " + solantragop.Text + " lần";
                    myCommand.Parameters.Add("@thanhtien", SqlDbType.Float).Value = float.Parse(label17.Text);
                    myCommand.Parameters.Add("@thoigian", SqlDbType.DateTime).Value = ngayttTraGop.Text;
                    myCommand.Parameters.Add("@makh", SqlDbType.Int).Value = Int32.Parse(DangNhap.username);
                    myCommand.Parameters.Add("@maphieu", SqlDbType.Int).Value = Int32.Parse(label24.Text);
                }
                int n = myCommand.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Thanh toán thành công.");
                }
                else
                {
                    MessageBox.Show("Thanh toán KHÔNG thành công.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            myCon.Close();
        }

        private void solantragop_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection(connectionString);
            myCon.Open();
            SqlDataAdapter myAdapter = new SqlDataAdapter("select top 1 * from PHIEUDKTIEM phieu join GOITIEMCHUNG goitc on phieu.GOI = goitc.TEN_GTC where MAKH = " + DangNhap.username + " and TINHTRANG = N'1'", myCon);
            DataTable dt = new DataTable();
            myAdapter.Fill(dt);
            int solan = Int32.Parse(solantragop.Text);
            string dongia = dt.Rows[0]["DONGIA"].ToString();
            switch (solan)
            {
                case 3:
                    {
                        label18.Text = (Int32.Parse(dongia) / solan).ToString();
                        label27.Text = "300000";
                        label17.Text = (Int32.Parse(dongia) + Int32.Parse(label27.Text)).ToString();
                        break;
                    }
                case 6:
                    {
                        label18.Text = (Int32.Parse(dongia) / solan).ToString();
                        label27.Text = "600000";
                        label17.Text = (Int32.Parse(dongia) + Int32.Parse(label27.Text)).ToString();
                        break;
                    }
                case 9:
                    {
                        label18.Text = (Int32.Parse(dongia) / solan).ToString();
                        label27.Text = "900000";
                        label17.Text = (Int32.Parse(dongia) + Int32.Parse(label27.Text)).ToString();
                        break;
                    }
                case 12:
                    {
                        label18.Text = (Int32.Parse(dongia) / solan).ToString();
                        label27.Text = "1200000";
                        label17.Text = (Int32.Parse(dongia) + Int32.Parse(label27.Text)).ToString();
                        break;
                    }
            }
            myCon.Close();
        }
    }
}
