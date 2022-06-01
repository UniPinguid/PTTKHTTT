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
    public partial class Login : Form
    {
        bool username_focus = false;
        bool password_focus = false;

        public static bool is_login_closed = false;

        public Login()
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
            Register register = new Register();
            register.ShowDialog();
            register.Focus();
        }

        private void loginClosed(object sender, FormClosedEventArgs e)
        {
            is_login_closed = true;
        }
    }
}
