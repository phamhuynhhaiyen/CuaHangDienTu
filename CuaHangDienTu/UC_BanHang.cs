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
    public partial class UC_BanHang : UserControl
    {
        public UC_BanHang()
        {
            InitializeComponent();
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            UC_LapHoaDon lhd = new UC_LapHoaDon();
            pnCenter.Controls.Clear();
            pnCenter.Controls.Add(lhd);
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            UC_LapPhieuBH lpd = new UC_LapPhieuBH();
            pnCenter.Controls.Clear();
            pnCenter.Controls.Add(lpd);
        }

        private void btnKiemTraBaoHanh_Click(object sender, EventArgs e)
        {
            UC_KiemTra kt = new UC_KiemTra();
            pnCenter.Controls.Clear();
            pnCenter.Controls.Add(kt);
        }
    }
}
