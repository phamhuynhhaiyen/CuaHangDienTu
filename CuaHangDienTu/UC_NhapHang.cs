using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangDienTu
{
    public partial class UC_NhapHang : UserControl
    {
        public UC_NhapHang()
        {
            InitializeComponent();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            frmThemSP frm = new frmThemSP();
            frm.Show();
        }
    }
}
