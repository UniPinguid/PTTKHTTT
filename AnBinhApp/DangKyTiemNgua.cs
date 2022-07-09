using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnBinhApp
{
    public partial class DangKyTiemNgua : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;

        bool co_can_giam_ho = false;

        // Khách hàng
        int MaKH = TrangChu.MaKH;
        string HoTenKH = TrangChu.HoTenKH;
        string GioiTinh = TrangChu.GioiTinh;
        string DiaChi = TrangChu.DiaChi;
        string SDT = TrangChu.SDT;
        string NgaySinh = TrangChu.NgaySinh;


        // Phiếu ĐK
        int MaPhieu;
        string Goi, NgayTiem, TinhTrang;

        public DangKyTiemNgua()
        {
            InitializeComponent();
            notification(TrangChu.co_ThongBao);
            HienThiInputGiamHo(co_can_giam_ho);
            sideBarCollapsible(TrangChu.ds_collapsible, TrangChu.chucnang_collapsible, TrangChu.taikhoan_collapsible);

            tab.SelectTab(DangKyTiemTab);

            hoVaTen_textBox.Text = HoTenKH;

            if (GioiTinh == "Nam")
                namBtn.Checked = true;
            else if (GioiTinh == "Nữ")
                nuBtn.Checked = true;
            else if (GioiTinh == "Khác")
                khacBtn.Checked = true;

            diaChi_textBox.Text = DiaChi;
            sdt_textBox.Text = SDT;
            ngaySinh_picker.Value = DateTime.Parse(NgaySinh);
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

        private void HienThiInputGiamHo(bool check)
        {
            if (check == false)
            {
                label21.Hide();
                tenNguoiGiamHo_textBox.Hide();
                panel11.Hide();
                label19.Hide();
                sdtNguoiGiamHo_textBox.Hide();
                panel10.Hide();
                label18.Hide();
                mqhNguoiGiamHo_textBox.Hide();
                panel7.Hide();
            }
            else
            {
                label21.Show();
                tenNguoiGiamHo_textBox.Show();
                panel11.Show();
                label19.Show();
                sdtNguoiGiamHo_textBox.Show();
                panel10.Show();
                label18.Show();
                mqhNguoiGiamHo_textBox.Show();
                panel7.Show();
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
                this.Hide();
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
            XemLich xemLichForm = new XemLich();
            xemLichForm.Show();
            this.Close();
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
            this.Close();
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

        private void clickQuayLaiPhieuDK(object sender, EventArgs e)
        {
            tab.SelectTab("DangKyTiemTab");
        }
        private void clickTiepTucPhieuDK(object sender, EventArgs e)
        {
            if (hoVaTen_textBox.Text == "")
                MessageBox.Show("Xin vui lòng nhập đầy đủ thông tin", "Thông báo");
            else if (!namBtn.Checked && !nuBtn.Checked && !khacBtn.Checked)
                MessageBox.Show("Xin vui lòng chọn giới tính", "Thông báo");
            else if (!goiCheck.Checked && !leCheck.Checked)
                MessageBox.Show("Xin vui lòng chọn loại tiêm ngừa", "Thông báo");
            else
            {
                if (goiCheck.Checked)
                {
                    tab.SelectTab("packageTab");
                }
                else if (leCheck.Checked)
                {
                    tab.SelectTab("singleVacTab");
                }
            }

            if (namBtn.Checked)
                GioiTinh = "Nam";
            else if (nuBtn.Checked)
                GioiTinh = "Nữ";
            else if (khacBtn.Checked)
                GioiTinh = "Khác";
        }
        private void clickTiepTucLe(object sender, EventArgs e)
        {
            tab.SelectTab(finalizationTab);

            label46.Text = hoVaTen_textBox.Text;
            if (namBtn.Checked) label47.Text = "Nam";
            else if (nuBtn.Checked) label47.Text = "Nữ";
            else if (khacBtn.Checked) label47.Text = "Khác";
            label48.Text = ngaySinh_picker.Value.ToShortDateString();
            label49.Text = diaChi_textBox.Text;
            label50.Text = sdt_textBox.Text;
            if (tenNguoiGiamHo_textBox.Text == "")
                label51.Text = "Không";
            else label51.Text = tenNguoiGiamHo_textBox.Text;
            if (sdtNguoiGiamHo_textBox.Text == "")
                label52.Text = "Không";
            else label52.Text = sdtNguoiGiamHo_textBox.Text;
            if (mqhNguoiGiamHo_textBox.Text == "")
                label53.Text = "Không";
            else label53.Text = mqhNguoiGiamHo_textBox.Text;
            if (goiCheck.Checked) label54.Text = "Gói";
            else if (leCheck.Checked) label54.Text = "Lẻ";
            label56.Text = vaccinationDatePicker.Value.ToShortDateString();
            label55.Text = vacxin_comboBox.Text;
            label57.Text = "Không";
        }
        private void clickQuayLaiGoiLe(object sender, EventArgs e)
        {
            if (goiCheck.Checked)
                tab.SelectTab("packageTab");
            else if (leCheck.Checked)
                tab.SelectTab("singleVacTab");
        }
        private void updateInfoKhachHang(object sender, EventArgs e)
        {
            tab.SelectTab("finalizationTab");

            label46.Text = hoVaTen_textBox.Text;
            if (namBtn.Checked) label47.Text = "Nam";
            else if (nuBtn.Checked) label47.Text = "Nữ";
            else if (khacBtn.Checked) label47.Text = "Khác";
            label48.Text = ngaySinh_picker.Value.ToShortDateString();
            label49.Text = diaChi_textBox.Text;
            label50.Text = sdt_textBox.Text;
            if (tenNguoiGiamHo_textBox.Text == "")
                label51.Text = "Không";
            else label51.Text = tenNguoiGiamHo_textBox.Text;
            if (sdtNguoiGiamHo_textBox.Text == "")
                label52.Text = "Không";
            else label52.Text = sdtNguoiGiamHo_textBox.Text;
            if (mqhNguoiGiamHo_textBox.Text == "")
                label53.Text = "Không";
            else label53.Text = mqhNguoiGiamHo_textBox.Text;
            if (goiCheck.Checked) label54.Text = "Gói";
            else if (leCheck.Checked) label51.Text = "Lẻ";
            label56.Text = vaccinationDatePicker.Value.ToShortDateString();
            label55.Text = vacxin_comboBox.Text;

            if (is_option1_select)
                Goi += "Gói tiêm trẻ em 0 - 12 tháng tuổi, ";
            if (is_option2_select)
                Goi += "Gói tiêm trẻ em 0 - 12 tháng tuổi, ";
            if (is_option3_select)
                Goi += "Gói tiêm thường, ";
            if (is_option4_select)
                Goi += "Gói phụ nữ mang thai";

            if (Goi[Goi.Length - 1].Equals(" ") && Goi[Goi.Length - 2].Equals(","))
            {
                Goi = Goi.Substring(0, Goi.Length - 2);
            }

            label57.Text = Goi;
        }

        // End of
        // Transitioning


        // Start of 
        // selecting package

        bool is_option1_select = false;
        bool is_option2_select = false;
        bool is_option3_select = false;
        bool is_option4_select = false;

        private void option1_click(object sender, EventArgs e)
        {
            if (is_option1_select == false)
            {
                is_option1_select = true;
                option1.Image = Image.FromFile("../../svg/package option1 activated.png");
            }
            else
            {
                is_option1_select = false;
                option1.Image = Image.FromFile("../../svg/package option1.png");
            }
        }
        private void option2_click(object sender, EventArgs e)
        {
            if (is_option2_select == false)
            {
                is_option2_select = true;
                option2.Image = Image.FromFile("../../svg/package option2 activated.png");
            }
            else
            {
                is_option2_select = false;
                option2.Image = Image.FromFile("../../svg/package option2.png");
            }
        }
        private void option3_click(object sender, EventArgs e)
        {
            if (is_option3_select == false)
            {
                is_option3_select = true;
                option3.Image = Image.FromFile("../../svg/package option3 activated.png");
            }
            else
            {
                is_option3_select = false;
                option3.Image = Image.FromFile("../../svg/package option3.png");
            }
        }
        private void option4_click(object sender, EventArgs e)
        {
            if (is_option4_select == false)
            {
                is_option4_select = true;
                option4.Image = Image.FromFile("../../svg/package option4 activated.png");
            }
            else
            {
                is_option4_select = false;
                option4.Image = Image.FromFile("../../svg/package option4.png");
            }
        }

        // End of
        // Selecting package

        private void getAge(object sender, EventArgs e)
        {
            int years = DateTime.Now.Year - ngaySinh_picker.Value.Year;
            int months = DateTime.Now.Month - ngaySinh_picker.Value.Month;
            agePrompt.Text = "Bạn " + years.ToString() + " tuổi";

            if (years <= 12)
            {
                co_can_giam_ho = true;
                if (years <= 3)
                {
                    months += years * 12;
                    agePrompt.Text = "Bạn " + months.ToString() + " tháng tuổi";
                }
            }
            else
                co_can_giam_ho = false;

            HienThiInputGiamHo(co_can_giam_ho);
        }        
        private void clickHoanTat(object sender, EventArgs e)
        {
            Random rnd = new Random();
            MaKH = rnd.Next(0, 99999999);
            MaPhieu = rnd.Next(0, 99999999);            

            NgayTiem = thoiGianTiem_picker.Value.ToShortDateString();
            TinhTrang = "CD";

            SqlConnection con = new SqlConnection();          
            using (con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    SqlCommand sql_cmnd = new SqlCommand("themPhieuDKTiem", con);
                    sql_cmnd.CommandType = CommandType.StoredProcedure;
                    sql_cmnd.Parameters.AddWithValue("@MaKH", SqlDbType.Int).Value = MaKH;
                    sql_cmnd.Parameters.AddWithValue("@MaPhieu", SqlDbType.Int).Value = MaPhieu;
                    sql_cmnd.Parameters.AddWithValue("@Goi", SqlDbType.NVarChar).Value = Goi;
                    sql_cmnd.Parameters.AddWithValue("@NgayTiem", SqlDbType.NVarChar).Value = DateTime.Parse(NgayTiem);
                    sql_cmnd.Parameters.AddWithValue("@TinhTrang", SqlDbType.NVarChar).Value = TinhTrang;
                    sql_cmnd.ExecuteNonQuery();
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Không thể thêm phiếu mới.", "Thông báo");
                }
            }

            HienThi hienThiForm = new HienThi();
            hienThiForm.messageShow("success", "Đăng ký tiêm ngừa thành công!", "Hệ thống sẽ duyệt và gửi kết quả cho bạn trong vòng 24 giờ.");
            this.Close();
            hienThiForm.Show();
        }       
    }
}
