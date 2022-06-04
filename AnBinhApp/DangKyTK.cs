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
    public partial class DangKyTK : Form
    {
        public static bool is_register_closed = false;

        public DangKyTK()
        {
            InitializeComponent();
        }

        private void clickLogin(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangNhap login = new DangNhap();
            login.Show();
            this.Hide();
        }

        private void registerClosed(object sender, FormClosedEventArgs e)
        {
            is_register_closed = true;
        }
    }
}
