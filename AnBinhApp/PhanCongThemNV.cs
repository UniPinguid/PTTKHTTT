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
    public partial class PhanCongThemNV : Form
    {
        private static string thu;
        public PhanCongThemNV(string _thu)
        {
            InitializeComponent();
            thu = _thu;
        }

        private void clickClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchForm_TextChanged(object sender, EventArgs e)
        {
            LichRanhTongHop.docLichRanhCoDieuKien(thu, cbb_TrungTam.Text, searchForm.Text);
            dataGridView1.DataSource = LichRanhTongHop.LichRanh;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LichRanhTongHop.docLichRanhCoDieuKien(thu, cbb_TrungTam.Text, searchForm.Text);
            dataGridView1.DataSource = LichRanhTongHop.LichRanh;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int manv = Int32.Parse(dataGridView1.SelectedRows[0].Cells["MANV"].Value.ToString());
            LichCaTruc.themNhanVien(manv);
            LichRanhTongHop.LichRanh.Rows.Add(dataGridView1.SelectedRows[0]);
        }


    }
}
