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
    public partial class DangNhap : Form
    {
        bool username_focus = false;
        bool password_focus = false;

        bool is_manually_close = true;
        public static bool is_login_close = false;

        public DangNhap()
        {
            InitializeComponent();
        }

        private void username_hover(object sender, EventArgs e)
        {
            if (!username_focus)
                usernameHoverLine.BackColor = Color.FromArgb(218, 232, 242);
        }

        private void username_leave(object sender, EventArgs e)
        {
            if (!username_focus)
                usernameHoverLine.BackColor = Color.FromArgb(245, 249, 252);
        }

        private void username_click(object sender, EventArgs e)
        {
            usernameHoverLine.BackColor = Color.FromArgb(73, 155, 242);
            username_focus = true;
            password_focus = false;

            password_leave(sender, e);
        }

        private void password_enter(object sender, EventArgs e)
        {
            if (!password_focus)
                passwordLine.BackColor = Color.FromArgb(218, 232, 242);
        }

        private void password_leave(object sender, EventArgs e)
        {
            if (!password_focus)
                passwordLine.BackColor = Color.FromArgb(245, 249, 252);
        }

        private void password_click(object sender, EventArgs e)
        {
            passwordLine.BackColor = Color.FromArgb(73, 155, 242);
            username_focus = false;
            password_focus = true;

            username_leave(sender, e);
        }

        private void clickRegister(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKyTK register = new DangKyTK();
            register.ShowDialog();
            register.Focus();
        }

        private void clickLogin(object sender, EventArgs e)
        {
            if (true /*login successfully*/)
            {
                TrangChu.is_login = true;
                is_manually_close = false;
                this.Close();
            }
            else
            {
                //
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && is_manually_close == true)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc là muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    is_manually_close = false;
                    is_login_close = true;
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
