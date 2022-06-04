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
    public partial class KiemTraPhieu : Form
    {
        bool is_NhanVien = TrangChu.is_NhanVien;

        public KiemTraPhieu()
        {
            InitializeComponent();

            if (!is_NhanVien)
            {
                label1.Hide();
                comboBox1.Hide();
                label2.Hide();
                textBox1.Hide();

                btnHoanTat.Location = new Point(btnHoanTat.Location.X, btnHoanTat.Location.Y - 65);
                this.Size = new Size(this.Size.Width, this.Size.Height - 55);
            }
            label2.Hide();
            textBox1.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Khác")
            {
                label2.Show();
                textBox1.Show();
            }
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
