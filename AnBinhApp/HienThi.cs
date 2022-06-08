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
    public partial class HienThi : Form
    {
        public HienThi()
        {
            InitializeComponent();
        }

        public void messageShow(string type, string text, string subtext)
        {
            if (type == "success")
            {
                pictureMessageType.Image = Image.FromFile("../../svg/success big.png");
                label_text.ForeColor = Color.FromArgb(113, 211, 89);
                label_text.Text = text;
                label_subtext.Text = subtext;
            }
        }
    }
}
