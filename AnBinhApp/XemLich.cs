using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnBinhApp
{
    public partial class XemLich : Form
    {
        DateTime today = DateTime.Today;
        DateTime date = DateTime.Today;

        bool is_DKLichRanh_clicked = false;

        public XemLich()
        {
            InitializeComponent();
            notification(TrangChu.co_ThongBao);
            sideBarCollapsible(TrangChu.ds_collapsible, TrangChu.chucnang_collapsible, TrangChu.taikhoan_collapsible);
            weekCalendar(today);

            btnHoanTat.Hide();
            btnHuy.Hide();
            label27.Hide();

            get_cell_status();
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

        private void lastWeek_enter(object sender, EventArgs e)
        {
            label_lastWeek.ForeColor = Color.FromArgb(38, 21, 92);
        }
        private void lastWeek_leave(object sender, EventArgs e)
        {
            label_lastWeek.Font = new Font("Inter Light", label_lastWeek.Font.Size);
            label_lastWeek.ForeColor = Color.DarkGray;
        }
        private void nextWeek_enter(object sender, EventArgs e)
        {
            label_nextWeek.ForeColor = Color.FromArgb(38, 21, 92);
        }
        private void nextWeek_leave(object sender, EventArgs e)
        {
            label_nextWeek.Font = new Font("Inter Light", label_nextWeek.Font.Size);
            label_nextWeek.ForeColor = Color.DarkGray;
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
            }
            else if (dialogResult == DialogResult.No)
            {
                is_Thoat_clicked = false;
                Thoat_leave(sender, e);
            }
        }

        // End of
        // Transitioning        


        // Start of
        // Calendar

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

        private void resetButton()
        {
            c2M.BackColor = Color.Gainsboro;
            c2A.BackColor = Color.Gainsboro;
            c2E.BackColor = Color.Gainsboro;

            c3M.BackColor = Color.Gainsboro;
            c3A.BackColor = Color.Gainsboro;
            c3E.BackColor = Color.Gainsboro;

            c4M.BackColor = Color.Gainsboro;
            c4A.BackColor = Color.Gainsboro;
            c4E.BackColor = Color.Gainsboro;

            c5M.BackColor = Color.Gainsboro;
            c5A.BackColor = Color.Gainsboro;
            c5E.BackColor = Color.Gainsboro;

            c6M.BackColor = Color.Gainsboro;
            c6A.BackColor = Color.Gainsboro;
            c6E.BackColor = Color.Gainsboro;

            c7M.BackColor = Color.Gainsboro;
            c7A.BackColor = Color.Gainsboro;
            c7E.BackColor = Color.Gainsboro;

            c8M.BackColor = Color.Gainsboro;
            c8A.BackColor = Color.Gainsboro;
            c8E.BackColor = Color.Gainsboro;
        }

        private void weekCalendar(DateTime date)
        {
            Calendar cal = new CultureInfo("en-US").Calendar;
            int week = cal.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            DateTime firstMonday = FirstDateOfWeek(2022, week - 1);

            label_T2.Text = firstMonday.ToShortDateString();
            label_T3.Text = firstMonday.AddDays(1).ToShortDateString();
            label_T4.Text = firstMonday.AddDays(2).ToShortDateString();
            label_T5.Text = firstMonday.AddDays(3).ToShortDateString();
            label_T6.Text = firstMonday.AddDays(4).ToShortDateString();
            label_T7.Text = firstMonday.AddDays(5).ToShortDateString();
            label_CN.Text = firstMonday.AddDays(6).ToShortDateString();

            if (date.DayOfWeek == DayOfWeek.Monday && today == firstMonday)
            {
                c2M.BackColor = Color.FromArgb(196, 220, 245);
                c2A.BackColor = Color.FromArgb(196, 220, 245);
                c2E.BackColor = Color.FromArgb(196, 220, 245);
            }
            else if (date.DayOfWeek == DayOfWeek.Tuesday && today == firstMonday.AddDays(1))
            {
                c3M.BackColor = Color.FromArgb(196, 220, 245);
                c3A.BackColor = Color.FromArgb(196, 220, 245);
                c3E.BackColor = Color.FromArgb(196, 220, 245);
            }
            else if (date.DayOfWeek == DayOfWeek.Wednesday && today == firstMonday.AddDays(2))
            {
                c4M.BackColor = Color.FromArgb(196, 220, 245);
                c4A.BackColor = Color.FromArgb(196, 220, 245);
                c4E.BackColor = Color.FromArgb(196, 220, 245);
            }
            else if (date.DayOfWeek == DayOfWeek.Thursday && today == firstMonday.AddDays(3))
            {
                c5M.BackColor = Color.FromArgb(196, 220, 245);
                c5A.BackColor = Color.FromArgb(196, 220, 245);
                c5E.BackColor = Color.FromArgb(196, 220, 245);
            }
            else if (date.DayOfWeek == DayOfWeek.Friday && today == firstMonday.AddDays(4))
            {
                c6M.BackColor = Color.FromArgb(196, 220, 245);
                c6A.BackColor = Color.FromArgb(196, 220, 245);
                c6E.BackColor = Color.FromArgb(196, 220, 245);
            }
            else if (date.DayOfWeek == DayOfWeek.Saturday && today == firstMonday.AddDays(5))
            {
                c7M.BackColor = Color.FromArgb(196, 220, 245);
                c7A.BackColor = Color.FromArgb(196, 220, 245);
                c7E.BackColor = Color.FromArgb(196, 220, 245);
            }
            else if (date.DayOfWeek == DayOfWeek.Sunday && today == firstMonday.AddDays(6))
            {
                c8M.BackColor = Color.FromArgb(196, 220, 245);
                c8A.BackColor = Color.FromArgb(196, 220, 245);
                c8E.BackColor = Color.FromArgb(196, 220, 245);
            }
        }

        private void click_lastWeek(object sender, EventArgs e)
        {
            label_lastWeek.Font = new Font("Inter Medium", label_lastWeek.Font.Size);
            resetButton();
            date = date.AddDays(-7);
            weekCalendar(date);
            get_cell_status();
        }

        private void click_nextWeek(object sender, EventArgs e)
        {
            label_nextWeek.Font = new Font("Inter Medium", label_nextWeek.Font.Size);
            resetButton();
            date = date.AddDays(7);
            weekCalendar(date);
            get_cell_status();
        }

        private void click_returnToday(object sender, EventArgs e)
        {
            resetButton();
            date = today;
            weekCalendar(date);
        }

        private void click_DKLichRanh(object sender, EventArgs e)
        {
            is_DKLichRanh_clicked = true;

            btnDKLichRanh.Hide();

            btnHoanTat.Show();
            btnHoanTat.Location = new Point(btnHoanTat.Location.X, 607);
            btnHuy.Show();
            btnHuy.Location = new Point(btnHuy.Location.X, 607);

            label8.Text = "Đăng ký lịch rảnh";
            label27.Show();
        }

        private void click_Huy(object sender, EventArgs e)
        {
            is_DKLichRanh_clicked = false;

            btnDKLichRanh.Show();
            btnHoanTat.Hide();
            btnHuy.Hide();

            label8.Text = "Xem lịch làm việc";
            label27.Hide();
        }

        private void click_HoanTat(object sender, EventArgs e)
        {
            is_DKLichRanh_clicked = false;

            HienThi dkLichSuccess = new HienThi();
            dkLichSuccess.Show();
            dkLichSuccess.messageShow("successDKLichRanh", "Đăng ký lịch rảnh thành công!", "Hãy chờ bộ phận điều hành duyệt\ntrong vòng 24 giờ.");
            this.Close();
        }

        // End of
        // Calendar


        // Start of
        // Đăng ký lịch rảnh

        // status 0 là chưa xác định, 1 là đã chọn, 2 là rảnh, 3 là bận
        // status 2 và 3 không thể bỏ chọn

        short c2M_status = 0;
        short c2A_status = 2;
        short c2E_status = 3;

        private void get_cell_status()
        {
            // hàm đọc dữ liệu từ database
            // và nhập vào từng cX_status

            cell_color(c2M, c2M_status);
            cell_color(c2A, c2A_status);
            cell_color(c2E, c2E_status);
            // copy paste hết 21 ô...
        }

        private void cell_color(Button cell, short cell_status)
        {
            if (cell_status == 0) cell.BackColor = Color.Gainsboro;
            else if (cell_status == 2) cell.BackColor = Color.FromArgb(176, 224, 173);
            else if (cell_status == 3) cell.BackColor = Color.FromArgb(237, 185, 191);
        }

        private short cell_click(Button cell, short cell_checked)
        {
            if (is_DKLichRanh_clicked && cell_checked == 0)
            {
                cell_checked = 1;
                cell.BackColor = Color.FromArgb(180, 232, 240);
                cell.FlatAppearance.BorderSize = 3;
                cell.FlatAppearance.BorderColor = Color.FromArgb(137, 188, 204);
            }
            else if (is_DKLichRanh_clicked && cell_checked == 1)
            {
                cell_checked = 0;
                cell.BackColor = Color.Gainsboro;
                cell.FlatAppearance.BorderSize = 0;
            }
            else if (is_DKLichRanh_clicked && cell_checked == 2)
            {
                MessageBox.Show("Không thể chọn trùng lịch rảnh.","Thông báo"); 
            }
            else if (is_DKLichRanh_clicked && cell_checked == 3)
            {
                MessageBox.Show("Không thể chọn lịch rảnh trùng với lịch làm việc.", "Thông báo");
            }

            return cell_checked;
        }

        private void c2M_click(object sender, EventArgs e)
        {
            c2M_status = cell_click(c2M, c2M_status);
            // copy paste hết 21 ô...
        }

        // End of
        // Đăng ký lịch rảnh
    }
}
