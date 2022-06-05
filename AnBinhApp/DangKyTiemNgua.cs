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
    public partial class DangKyTiemNgua : Form
    {
        bool co_can_giam_ho = false;

        public DangKyTiemNgua()
        {
            InitializeComponent();
            HienThiInputGiamHo(co_can_giam_ho);
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

        private void clickQuayLaiGoiLe(object sender, EventArgs e)
        {
            if (packageCheck.Checked)
                tab.SelectTab("packageTab");
            else if (singleCheck.Checked)
                tab.SelectTab("singleVacTab");
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
    }
}
