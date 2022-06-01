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
    public partial class Register : Form
    {
        public static bool is_register_closed = false;

        public Register()
        {
            InitializeComponent();
        }

        private void clickLogin(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void registerClosed(object sender, FormClosedEventArgs e)
        {
            is_register_closed = true;
        }
    }
}
