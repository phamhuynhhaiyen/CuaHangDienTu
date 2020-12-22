using CuaHangDienTu.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangDienTu
{
    
    public partial class Form1 : Form
    {
        private bool isCollapsed;
        public Form1()
        {
            InitializeComponent();
        }
        public void AddControl(Control c)
        {
            
            c.Dock = DockStyle.Fill;
            pnCenter.Controls.Clear();
            pnCenter.Controls.Add(c);

        }
        private void btnBanHang_Click(object sender, EventArgs e)
        {
            UC_BanHang bh = new UC_BanHang();
            AddControl(bh);
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                btnHeThong.Image = Resources.Collapse_Arrow_20px;
                panelHeThong.Height += 10;
                if (panelHeThong.Size == panelHeThong.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                btnHeThong.Image = Resources.Expand_Arrow_20px;
                panelHeThong.Height -= 10;
                if (panelHeThong.Size == panelHeThong.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                btnDanhMuc.Image = Resources.Collapse_Arrow_20px;
                pnDanhMuc.Height += 10;
                if (pnDanhMuc.Size == pnDanhMuc.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                btnDanhMuc.Image = Resources.Expand_Arrow_20px;
                pnDanhMuc.Height -= 10;
                if (pnDanhMuc.Size == pnDanhMuc.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            UC_NhanVien nv = new UC_NhanVien();
            AddControl(nv);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            UC_KhachHang kh = new UC_KhachHang();
            AddControl(kh);

        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            UC_SanPham sp = new UC_SanPham();
            AddControl(sp);
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            UC_NhaCungCap ncc = new UC_NhaCungCap();
            AddControl(ncc);
        }

        private void btnXemHoaDon_Click(object sender, EventArgs e)
        {
            UC_XemHoaDon hd = new UC_XemHoaDon();
            AddControl(hd);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            UC_NhapHang nh = new UC_NhapHang();
            AddControl(nh);
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            UC_DoiMK mk = new UC_DoiMK();
            AddControl(mk);
        }
    }
}
