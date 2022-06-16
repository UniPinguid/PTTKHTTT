using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnBinhApp
{
    public partial class DSNhanVien : Form
    {
        public DSNhanVien()
        {
            InitializeComponent();
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

        private void ThongBao_hover(object sender, EventArgs e)
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
        private void QTTC_click(object sender, EventArgs e)
        {
            QuyTrinhTiemChung QTTCForm = new QuyTrinhTiemChung();
            QTTCForm.Show();
            this.Close();
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
                this.Close();
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

        private void taiKhoan_click(object sender, EventArgs e)
        {
            TaiKhoan tkForm = new TaiKhoan();
            tkForm.Show();
            this.Hide();
        }
        private void DangXuat_click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc là muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                TrangChu.is_login = false;
                TrangChu.is_NhanVien = false;

                this.Close();
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
    }
}
