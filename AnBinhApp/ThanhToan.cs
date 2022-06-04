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
    public partial class ThanhToan : Form
    {
        public ThanhToan()
        {
            InitializeComponent();
            hoadonMotLan.Hide();
            hoadonTraGop.Hide();
            btnThanhToan.Hide();
        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {
            ngayttMotLan.Text = DateTime.Now.ToShortDateString();
            ngayttTraGop.Text = DateTime.Now.ToShortDateString();
        }

        private void rBtnMotLan_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnMotLan.Checked)
            {
                hoadonMotLan.Show();
                btnThanhToan.Show();
                btnThanhToan.Location = new Point(1225, 470);
            }
            else
            {
                hoadonMotLan.Hide();
            }
        }

        private void rBtnTraGop_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnTraGop.Checked)
            {
                hoadonTraGop.Location = new Point(801, 179);
                hoadonTraGop.Show();
                btnThanhToan.Show();
                btnThanhToan.Location = new Point(1225, 505);
            }
            else
            {
                hoadonTraGop.Hide();
            }
        }

        private void clickXemPhieu(object sender, EventArgs e)
        {
            KiemTraPhieu phieu = new KiemTraPhieu();
            phieu.Show();
        }
    }
}
