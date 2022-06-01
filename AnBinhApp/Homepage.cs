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
    public partial class Homepage : Form
    {
        bool homepage_clicked = false;
        bool vacReg_clicked = false;
        bool listVac_clicked = false;
        bool exit_clicked = false;

        bool is_login = false;
        bool is_supervisor_needed = false;

        public Homepage()
        {
            InitializeComponent();
            show_supervisor_input(is_supervisor_needed);
        }

        private void show_supervisor_input(bool check)
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
        public void EnableDoubleBuffering()
        {
            this.SetStyle(ControlStyles.DoubleBuffer |
               ControlStyles.UserPaint |
               ControlStyles.AllPaintingInWmPaint,
               true);
            this.UpdateStyles();
        }

        private void homepage_enter(object sender, EventArgs e)
        {
            if (homepage_clicked)
                panel4.BackColor = Color.FromArgb(58, 137, 222);
            else
                panel4.BackColor = Color.FromArgb(37, 58, 128);
        }

        private void homepage_leave(object sender, EventArgs e)
        {
            if (homepage_clicked)
                panel4.BackColor = Color.FromArgb(73, 155, 242);
            else
                panel4.BackColor = Color.FromArgb(38, 21, 92);
        }
        private void homepage_click(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(73, 155, 242);
            homepage_clicked = true;

            vacReg_clicked = false;
            exit_clicked = false;

            // homepage_leave(sender, e);
            vacReg_leave(sender, e);
            listVac_leave(sender, e);
            logout_leave(sender, e);
            exit_leave(sender, e);


            tab.SelectTab("homepageTab");
        }

        private void logout_enter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(37, 58, 128);
        }

        private void logout_leave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(38, 21, 92);
        }

        private void exit_enter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(37, 58, 128);
        }

        private void exit_leave(object sender, EventArgs e)
        {
            if (exit_clicked)
                panel3.BackColor = Color.FromArgb(73, 155, 242);
            else
                panel3.BackColor = Color.FromArgb(38, 21, 92);
        }

        private void exit_click(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(73, 155, 242);
            exit_clicked = true;

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc là muốn thoát không?", "Thoát An Binh", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                exit_clicked = false;
                exit_leave(sender, e);
            }
        }

        private void vacReg_enter(object sender, EventArgs e)
        {
            if (vacReg_clicked)
                panel5.BackColor = Color.FromArgb(58, 137, 222);
            else
                panel5.BackColor = Color.FromArgb(37, 58, 128);
        }

        private void vacReg_leave(object sender, EventArgs e)
        {
            if (vacReg_clicked)
                panel5.BackColor = Color.FromArgb(73, 155, 242);
            else
                panel5.BackColor = Color.FromArgb(38, 21, 92);
        }

        private void vacReg_click(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(73, 155, 242);
            vacReg_clicked = true;

            homepage_clicked = false;
            exit_clicked = false;

            homepage_leave(sender, e);
            // vacReg_leave(sender, e);
            listVac_leave(sender, e);
            logout_leave(sender, e);
            exit_leave(sender, e);

            tab.SelectTab("vaccineRegisterTab");
        }

        private void listVac_enter(object sender, EventArgs e)
        {
            if (listVac_clicked)
                panel6.BackColor = Color.FromArgb(58, 137, 222);
            else
                panel6.BackColor = Color.FromArgb(37, 58, 128);
        }

        private void listVac_leave(object sender, EventArgs e)
        {
            if (listVac_clicked)
                panel6.BackColor = Color.FromArgb(73, 155, 242);
            else
                panel6.BackColor = Color.FromArgb(38, 21, 92);
        }

        private void listVac_click(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(73, 155, 242);
            listVac_clicked = true;

            homepage_clicked = false;
            vacReg_clicked = false;
            exit_clicked = false;

            homepage_leave(sender, e);
            vacReg_leave(sender, e);
            // listVac_leave(sender, e);
            logout_leave(sender, e);
            exit_leave(sender, e);

            if (is_login)
                tab.SelectTab("listVaccinationRecTab");
            else
            {
                DialogResult dialogResult = MessageBox.Show("Hãy đăng nhập để sử dụng tính năng này.", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Login login = new Login();
                    login.Show();
                }
                else if (dialogResult == DialogResult.No)
                {
                    listVac_clicked = false;
                    listVac_leave(sender, e);
                }
            }
        }

        private void getAge(object sender, EventArgs e)
        {
            int years = DateTime.Now.Year - birthday_picker.Value.Year;
            int months = DateTime.Now.Month - birthday_picker.Value.Month;
            agePrompt.Text = "Bạn " + years.ToString() + " tuổi";

            if (years <= 12)
            {
                is_supervisor_needed = true;
                if (years <= 3)
                {
                    months += years * 12;
                    agePrompt.Text = "Bạn " + months.ToString() + " tháng tuổi";
                }
            }
            else
                is_supervisor_needed = false;

            show_supervisor_input(is_supervisor_needed);
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
            if (packageCheck.Checked)
            {
                tab.SelectTab("packageTab");
            }
            else if (singleCheck.Checked)
            {
                tab.SelectTab("singleVacTab");
            }
        }

        private void notification_click(object sender, EventArgs e)
        {
            notification.Image = Image.FromFile("../../svg/bell click.png");
        }

        private void notification_hover(object sender, EventArgs e)
        {
            notification.Image = Image.FromFile("../../svg/bell hover.png");
        }

        private void notification_leave(object sender, EventArgs e)
        {
            notification.Image = Image.FromFile("../../svg/bell.png");
        }

        private void clickContinueFinalize(object sender, EventArgs e)
        {
            tab.SelectTab("finalizationTab");
        }

        private void clickReturnPackageSingle(object sender, EventArgs e)
        {
            if (packageCheck.Checked)
                tab.SelectTab("packageTab");
            else if (singleCheck.Checked)
                tab.SelectTab("singleVacTab");
        }

        private void homepage_load(object sender, EventArgs e)
        {
            if (is_login == false)
            {
                Login login = new Login();
                login.ShowDialog();
                if (Login.is_login_closed == true)
                {
                    this.Close();
                }
            }
            else
            {
                //
            }
        }
    }
}
