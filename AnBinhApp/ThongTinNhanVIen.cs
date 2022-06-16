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
    public partial class ThongTinNhanVIen : Form
    {
        public ThongTinNhanVIen()
        {
            InitializeComponent();
        }

        private void clickClose(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
