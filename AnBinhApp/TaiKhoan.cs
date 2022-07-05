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
    public partial class TaiKhoan : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;

        bool is_ThongTinThem_clicked = true;
        bool is_PhieuDK_clickd = false;
        bool is_BangCap_clicked = false;

        int MaKH;
        string HoTenKH, GioiTinh, DiaChi, SDT, NgaySinh;

        int MaNV, Luong, SoBuoiTruc, MaTT;
        string HoTenNV, NgaySinhNV, CMND, SDTNV, Email, DiaChiNV, ViTri, VaiTro;

        public TaiKhoan()
        {
            InitializeComponent();

            // Nếu là khách hàng
            if (!TrangChu.is_NhanVien)
            {
                btnBangCap.Hide();
                panel6.Hide();
                panel_nguoiGH.Location = new Point(45, 29);
            }
            // Nếu là nhân viên
            else if (TrangChu.is_NhanVien)
            {
                btnPhieuDK.Hide();
                btnBangCap.Location = new Point(286, 434);
                panel_nguoiGH.Hide();
            }

            tab.SelectTab(tabThongTinThem);
            notification(TrangChu.co_ThongBao);
            sideBarCollapsible(TrangChu.ds_collapsible, TrangChu.chucnang_collapsible, TrangChu.taikhoan_collapsible);

            submitBtn.Hide();
        }

        // Start of
        // Styling and visualization

        bool is_Thoat_clicked = false;
        bool is_DSPhieuTiem_clicked = false;

        bool tab_vacxin = true;
        bool tab_loVacxin = false;
        bool tab_phieuDatMua = false;
        bool tab_phieuNhapHang = false;

        private void salaryFocus(object sender, MouseEventArgs e)
        {
            toggleSalaryVisible.Image = Image.FromFile("../../svg/eye hidden.png");
            label_salary.Text = Luong.ToString() + "đ";
        }
        private void salaryUnfocus(object sender, MouseEventArgs e)
        {
            toggleSalaryVisible.Image = Image.FromFile("../../svg/eye visible.png");
            label_salary.Text = "******";
        }


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

                panel2.Location = new Point(panel2.Location.X, panel_Thoat.Location.Y - 168);
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

                panel2.Location = new Point(panel2.Location.X, panel_Thoat.Location.Y + 168);
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

        private void clickTimKieuPhieuDK(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            using (con = new SqlConnection(connectionString))
            {
                string query = "select * " +
                           "from PHIEUDKTIEM " +
                           "where (MAKH = " + TrangChu.MaKH + " AND MAPHIEU like '%" + search_phieuDK.Text + "%') " +
                           "and NGAYTIEM between '" + fromDatePicker.Value.ToString("yyyy/MM/dd") + "' and '" + toDatePicker.Value.ToString("yyyy/MM/dd") + "'";

                SqlDataAdapter dataadapter = new SqlDataAdapter(query, connectionString);
                DataSet ds = new DataSet();
                con.Open();
                dataadapter.Fill(ds, "PhieuDK");
                dgv_phieuDK.DataSource = ds;
                dgv_phieuDK.DataMember = "PhieuDK";
                con.Close();
            }
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
        private void dsVacXin_click(object sender, EventArgs e)
        {
            if (TrangChu.is_NhanVien)
            {
                KhaNangVacxin dsVacXinForm = new KhaNangVacxin();
                dsVacXinForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Chỉ có nhân viên mới được sử dụng tính năng này!", "Thông báo");
            }
        }
        private void dsNhanVien_click(object sender, EventArgs e)
        {
            if (TrangChu.is_BoPhanDieuHanh)
            {
                DSNhanVien dsNV = new DSNhanVien();
                dsNV.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Chỉ có bộ phận điều hành mới được sử dụng tính năng này!", "Thông báo");
            }
        }

        private void datMuaVacxin_click(object sender, EventArgs e)
        {
            DatMuaVacxin datMuaVacxinForm = new DatMuaVacxin();
            datMuaVacxinForm.Show();
            this.Close();
        }
        private void xemLich_click(object sender, EventArgs e)
        {
            if (TrangChu.is_NhanVien)
            {
                XemLich xemLichForm = new XemLich();
                xemLichForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Chỉ có nhân viên mới được sử dụng tính năng này!", "Thông báo");
                is_DSPhieuTiem_clicked = false;
                dsPhieuTiem_leave(sender, e);
            }
        }
        private void phanCong_click(object sender, EventArgs e)
        {
            if (TrangChu.is_BoPhanDieuHanh)
            {
                PhanCong phanCongForm = new PhanCong();
                phanCongForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Chỉ có bộ phận điều hành mới được sử dụng tính năng này!", "Thông báo");
            }
        }

        private void DangXuat_click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc là muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                TrangChu.is_login = false;
                TrangChu.is_NhanVien = false;

                TrangChu trangChu = new TrangChu();
                trangChu.Show();
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

        private void btnThongTinThem_click(object sender, EventArgs e)
        {
            tab.SelectTab(tabThongTinThem);
            btnThongTinThem.ForeColor = Color.White;
            btnThongTinThem.BackColor = Color.FromArgb(73, 155, 242);
            btnThongTinThem.Font = new Font("Inter Medium", btnThongTinThem.Font.Size);

            btnPhieuDK.ForeColor = Color.DarkGray;
            btnPhieuDK.BackColor = Color.FromArgb(247, 249, 252);
            btnPhieuDK.Font = new Font("Inter Light", btnPhieuDK.Font.Size);

            btnBangCap.ForeColor = Color.DarkGray;
            btnBangCap.BackColor = Color.FromArgb(247, 249, 252);
            btnBangCap.Font = new Font("Inter Light", btnBangCap.Font.Size);
        }
        private void btnPhieuDK_click(object sender, EventArgs e)
        {
            tab.SelectTab(tabPhieuDK);
            btnPhieuDK.ForeColor = Color.White;
            btnPhieuDK.BackColor = Color.FromArgb(73, 155, 242);
            btnPhieuDK.Font = new Font("Inter Medium", btnPhieuDK.Font.Size);

            btnThongTinThem.ForeColor = Color.DarkGray;
            btnThongTinThem.BackColor = Color.FromArgb(247, 249, 252);
            btnThongTinThem.Font = new Font("Inter Light", btnThongTinThem.Font.Size);
        }
        private void btnBangCap_click(object sender, EventArgs e)
        {
            tab.SelectTab(tabBangCap);
            btnBangCap.ForeColor = Color.White;
            btnBangCap.BackColor = Color.FromArgb(73, 155, 242);
            btnBangCap.Font = new Font("Inter Medium", btnBangCap.Font.Size);

            btnThongTinThem.ForeColor = Color.DarkGray;
            btnThongTinThem.BackColor = Color.FromArgb(247, 249, 252);
            btnThongTinThem.Font = new Font("Inter Light", btnThongTinThem.Font.Size);
        }

        private void clickEdit(object sender, EventArgs e)
        {
            editBtn.Hide();
            submitBtn.Show();
            submitBtn.Location = new Point(985, 43);

            textBox_hoTen.ReadOnly = false;
            textBox_viTri.ReadOnly = false;
            textBox_ngaySinh.ReadOnly = false;
            textBox_sdt.ReadOnly = false;
            textBox_diaChi.ReadOnly = false;

            textBox_hoTen.BackColor = Color.FromArgb(240, 240, 240);
            textBox_viTri.BackColor = Color.FromArgb(240, 240, 240);
            textBox_ngaySinh.BackColor = Color.FromArgb(240, 240, 240);
            textBox_sdt.BackColor = Color.FromArgb(240, 240, 240);
            textBox_diaChi.BackColor = Color.FromArgb(240, 240, 240);
        }

        private void clickSubmit(object sender, EventArgs e)
        {
            submitBtn.Hide();
            editBtn.Show();

            textBox_hoTen.ReadOnly = true;
            textBox_viTri.ReadOnly = true;
            textBox_ngaySinh.ReadOnly = true;
            textBox_sdt.ReadOnly = true;
            textBox_diaChi.ReadOnly = true;

            textBox_hoTen.BackColor = Color.White;
            textBox_viTri.BackColor = Color.White;
            textBox_ngaySinh.BackColor = Color.White;
            textBox_sdt.BackColor = Color.White;
            textBox_diaChi.BackColor = Color.White;
        }

        // End of
        // Transitioning     

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            if (TrangChu.is_NhanVien)
            {
                MaNV = TrangChu.MaNV;
                HoTenNV = TrangChu.HoTenNV;
                NgaySinhNV = TrangChu.NgaySinhNV;
                CMND = TrangChu.CMND;
                SDTNV = TrangChu.SDTNV;
                Email = TrangChu.Email;
                DiaChiNV = TrangChu.DiaChiNV;
                ViTri = TrangChu.ViTri;
                Luong = TrangChu.Luong;
                VaiTro = TrangChu.VaiTro;
                MaTT = TrangChu.MaTT;
                SoBuoiTruc = TrangChu.SoBuoiTruc;

                textBox_hoTen.Text = HoTenNV;
                textBox_viTri.Text = ViTri;
                textBox_ngaySinh.Text = NgaySinhNV;
                textBox_sdt.Text = SDTNV;
                textBox_diaChi.Text = DiaChiNV;
                label_cmnd.Text = CMND;
                label_email.Text = Email;
                label_vaiTro.Text = VaiTro;
                label_trungTam.Text = MaTT.ToString();
                label_soBuoiTruc.Text = SoBuoiTruc.ToString();

                username_label.Text = HoTenNV;

                SqlConnection con = new SqlConnection();
                using (con = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM BANGCAP WHERE BC_MANV = " + DangNhap.username;
                    SqlDataAdapter dataadapter = new SqlDataAdapter(query, connectionString);
                    DataSet ds = new DataSet();
                    con.Open();
                    dataadapter.Fill(ds, "BangCap");
                    dgv_BangCap.DataSource = ds;
                    dgv_BangCap.DataMember = "BangCap";
                    con.Close();
                }
            }
            else
            {
                MaKH = TrangChu.MaKH;
                HoTenKH = TrangChu.HoTenKH;
                GioiTinh = TrangChu.GioiTinh;
                DiaChi = TrangChu.DiaChi;
                SDT = TrangChu.SDT;
                NgaySinh = TrangChu.NgaySinh;

                textBox_hoTen.Text = HoTenKH;
                textBox_viTri.Hide();
                textBox_ngaySinh.Text = NgaySinh;
                textBox_sdt.Text = SDT;
                textBox_diaChi.Text = DiaChi;

                username_label.Text = HoTenKH;

                SqlConnection con = new SqlConnection();
                using (con = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM NGUOIGIAMHO WHERE MANGH = " + DangNhap.username;
                    SqlDataAdapter dataadapter = new SqlDataAdapter(query, connectionString);
                    DataSet ds = new DataSet();
                    con.Open();
                    dataadapter.Fill(ds, "NguoiGiamHo");
                    dgv_nguoiGiamHo.DataSource = ds;
                    dgv_nguoiGiamHo.DataMember = "NguoiGiamHo";
                    con.Close();
                }
            }
        }
    }
}
