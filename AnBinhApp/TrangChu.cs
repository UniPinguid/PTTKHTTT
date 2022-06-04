using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnBinhApp
{
    public partial class TrangChu : Form
    {
        bool is_TrangChu_clicked = false;
        bool is_DangKyTiem_clicked = false;
        bool is_DSPhieuTiem_clicked = false;
        bool is_Thoat_clicked = false;

        public static bool is_login = false;
        public static bool is_NhanVien = false;
        bool co_ThongBao = true;

        bool co_can_giam_ho = false;

        public TrangChu()
        {
            InitializeComponent();
            HienThiInputGiamHo(co_can_giam_ho);
        }

        private void TrangChu_load(object sender, EventArgs e)
        {
            if (co_ThongBao == false)
                picture_dauThongBao.Hide();
            else picture_dauThongBao.Show();
            if (is_login == false)
            {
                DangNhap login = new DangNhap();
                login.ShowDialog();
                if (DangNhap.is_login_close == true)
                {
                    this.Close();
                }
            }
            else
            {
                //
            }
        }

        private void HienThiInputGiamHo(bool check)
        {
            if (check == false)
            {
                label21.Hide();
                supervisorName_textBox.Hide();
                panel11.Hide();
                label19.Hide();
                supervisorNum_textBox.Hide();
                panel10.Hide();
                label18.Hide();
                supervisorRelationship_textBox.Hide();
                panel7.Hide();
            }
            else
            {
                label21.Show();
                supervisorName_textBox.Show();
                panel11.Show();
                label19.Show();
                supervisorNum_textBox.Show();
                panel10.Show();
                label18.Show();
                supervisorRelationship_textBox.Show();
                panel7.Show();
            }
        }

        private void TrangChu_enter(object sender, EventArgs e)
        {
            if (is_TrangChu_clicked)
                panel_TrangChu.BackColor = Color.FromArgb(58, 137, 222);
            else
                panel_TrangChu.BackColor = Color.FromArgb(37, 58, 128);
        }

        private void TrangChu_leave(object sender, EventArgs e)
        {
            if (is_TrangChu_clicked)
                panel_TrangChu.BackColor = Color.FromArgb(73, 155, 242);
            else
                panel_TrangChu.BackColor = Color.FromArgb(38, 21, 92);
        }
        private void TrangChu_click(object sender, EventArgs e)
        {
            panel_TrangChu.BackColor = Color.FromArgb(73, 155, 242);
            is_TrangChu_clicked = true;
            is_DSPhieuTiem_clicked = false;
            is_DangKyTiem_clicked = false;
            is_Thoat_clicked = false;

            // homepage_leave(sender, e);
            DangKyTiem_leave(sender, e);
            DSPhieuTiem_leave(sender, e);
            DangXuat_leave(sender, e);
            Thoat_leave(sender, e);

            tab.SelectTab("TrangChuTab");
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
            if (is_Thoat_clicked)
                panel_Thoat.BackColor = Color.FromArgb(73, 155, 242);
            else
                panel_Thoat.BackColor = Color.FromArgb(38, 21, 92);
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

        private void DangKyTiem_enter(object sender, EventArgs e)
        {
            if (is_DangKyTiem_clicked)
                panel_DangKyTiem.BackColor = Color.FromArgb(58, 137, 222);
            else
                panel_DangKyTiem.BackColor = Color.FromArgb(37, 58, 128);
        }

        private void DangKyTiem_leave(object sender, EventArgs e)
        {
            if (is_DangKyTiem_clicked)
                panel_DangKyTiem.BackColor = Color.FromArgb(73, 155, 242);
            else
                panel_DangKyTiem.BackColor = Color.FromArgb(38, 21, 92);
        }

        private void DangKyTiem_click(object sender, EventArgs e)
        {
            panel_DangKyTiem.BackColor = Color.FromArgb(73, 155, 242);

            is_DangKyTiem_clicked = true;
            is_DSPhieuTiem_clicked = false;
            is_TrangChu_clicked = false;
            is_Thoat_clicked = false;

            TrangChu_leave(sender, e);
            // vacReg_leave(sender, e);
            DSPhieuTiem_leave(sender, e);
            DangXuat_leave(sender, e);
            Thoat_leave(sender, e);

            tab.SelectTab("DangKyTiemTab");
        }

        private void DSPhieuTiem_enter(object sender, EventArgs e)
        {
            if (is_DSPhieuTiem_clicked)
                panel_DSPhieuTiem.BackColor = Color.FromArgb(58, 137, 222);
            else
                panel_DSPhieuTiem.BackColor = Color.FromArgb(37, 58, 128);
        }

        private void DSPhieuTiem_leave(object sender, EventArgs e)
        {
            if (is_DSPhieuTiem_clicked)
                panel_DSPhieuTiem.BackColor = Color.FromArgb(73, 155, 242);
            else
                panel_DSPhieuTiem.BackColor = Color.FromArgb(38, 21, 92);
        }

        private void DSPhieuTiem_click(object sender, EventArgs e)
        {
            panel_DSPhieuTiem.BackColor = Color.FromArgb(73, 155, 242);

            is_DSPhieuTiem_clicked = true;
            is_TrangChu_clicked = false;
            is_DangKyTiem_clicked = false;
            is_Thoat_clicked = false;

            TrangChu_leave(sender, e);
            DangKyTiem_leave(sender, e);
            // listVac_leave(sender, e);
            DangXuat_leave(sender, e);
            Thoat_leave(sender, e);

            if (is_NhanVien)
                tab.SelectTab("DSPhieuTiemTab");
            else
            {
                MessageBox.Show("Chỉ có nhân viên mới được sử dụng tính năng này!", "Thông báo");
                is_DSPhieuTiem_clicked = false;
                DSPhieuTiem_leave(sender, e);
            }
        }

        private void getAge(object sender, EventArgs e)
        {
            int years = DateTime.Now.Year - birthday_picker.Value.Year;
            int months = DateTime.Now.Month - birthday_picker.Value.Month;
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

        private void clickReturnVacRec(object sender, EventArgs e)
        {
            tab.SelectTab("vaccineRegisterTab");
        }

        private void clickContinueMethod(object sender, EventArgs e)
        {
            if (fullName_textBox.Text == "")
                MessageBox.Show("Xin vui lòng nhập đầy đủ thông tin", "Thông báo");
            if (!maleBtn.Checked && !femaleBtn.Checked && !otherGenderBtn.Checked)
                MessageBox.Show("Xin vui lòng chọn giới tính", "Thông báo");
            else if (!packageCheck.Checked && !singleCheck.Checked)
                MessageBox.Show("Xin vui lòng chọn loại tiêm ngừa", "Thông báo");
            else
            {
                if (packageCheck.Checked)
                {
                    tab.SelectTab("packageTab");
                }
                else if (singleCheck.Checked)
                {
                    tab.SelectTab("singleVacTab");
                }
            }
        }

        private void ThongBao_click(object sender, EventArgs e)
        {
            pictureThongBao.Image = Image.FromFile("../../svg/bell click.png");
            tab.SelectTab("ThongBaoTab");

            if (co_ThongBao == false)
            {
                panel18.Hide();
                pictureBox10.Location = new Point(200, 120);
            }
            else
            {
                pictureBox10.Hide();
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

        private void clickTiepTucCuoiCung(object sender, EventArgs e)
        {
            tab.SelectTab("finalizationTab");

            label46.Text = fullName_textBox.Text;
            if (maleBtn.Checked) label47.Text = "Nam";
            else if (femaleBtn.Checked) label47.Text = "Nữ";
            else if (otherGenderBtn.Checked) label47.Text = "Khác";
            label48.Text = birthday_picker.Value.ToShortDateString();
            label49.Text = textBox1.Text;
            label50.Text = textBox2.Text;
            if (supervisorName_textBox.Text == "")
                label51.Text = "Không";
            else label51.Text = supervisorName_textBox.Text;
            if (supervisorNum_textBox.Text == "")
                label52.Text = "Không";
            else label52.Text = supervisorNum_textBox.Text;
            if (supervisorRelationship_textBox.Text == "")
                label53.Text = "Không";
            else label53.Text = supervisorRelationship_textBox.Text;
            if (packageCheck.Checked) label54.Text = "Gói";
            else if (singleCheck.Checked) label51.Text = "Lẻ";
            label56.Text = vaccinationDatePicker.Value.ToShortDateString();
            label55.Text = comboBox1.Text;
            if (is_option1_select == true) label57.Text = "Gói 0 - 12 tháng tuổi";
            else if (is_option2_select == true) label57.Text = "Gói 0 - 24 tháng tuổi";
            else if (is_option3_select == true) label57.Text = "Gói thường";
            else if (is_option4_select == true) label57.Text = "Gói phụ nữ mang thai";
        }

        private void clickQuayLaiGoiLe(object sender, EventArgs e)
        {
            if (packageCheck.Checked)
                tab.SelectTab("packageTab");
            else if (singleCheck.Checked)
                tab.SelectTab("singleVacTab");
        }

        private void DongThongBao_enter(object sender, EventArgs e)
        {
            panel18.BackColor = Color.FromArgb(228, 241, 247);
        }

        private void DongThongBao_leave(object sender, EventArgs e)
        {
            panel18.BackColor = Color.WhiteSmoke;
        }

        private void clickThanhToan(object sender, EventArgs e)
        {
            ThanhToan thanhToanForm = new ThanhToan();
            this.Hide();
            thanhToanForm.ShowDialog();
        }
    }
}
