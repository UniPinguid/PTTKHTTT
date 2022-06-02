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
    public partial class CheckForm : Form
    {
        public CheckForm()
        {
            InitializeComponent();

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
    }
}
