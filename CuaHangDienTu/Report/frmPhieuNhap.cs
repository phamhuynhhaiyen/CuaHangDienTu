using CuaHangDienTu.Database;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangDienTu.Report
{
    public partial class frmPhieuNhap : Form
    {
        public long maphieunhap;
        public frmPhieuNhap(long maPN)
        {
            InitializeComponent();
            this.maphieunhap = maPN;
        }
        public List<CTPN> GetList()
        {           
            CuaHangDienTuEntities entities = new CuaHangDienTuEntities();
            List<CTPN>  ctpn = (from c in entities.CTPNs where c.MaPhieuNhap == maphieunhap select c).ToList();           
            return ctpn;
        }
        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            CuaHangDienTuEntities entities = new CuaHangDienTuEntities();
            
            ReportParameter[] param = new ReportParameter[4];
            param[0] = new ReportParameter("MaPN", Convert.ToString(maphieunhap));
            param[1] = new ReportParameter("TenNV", entities.PhieuNhaps.Find(maphieunhap).NhanVien.TenNV);
            param[2] = new ReportParameter("NgayLap", string.Format("Ngày " + entities.PhieuNhaps.Find(maphieunhap).NgayLap));
            param[3] = new ReportParameter("TongTien", Convert.ToString(entities.PhieuNhaps.Find(maphieunhap).TongTien));
            this.reportViewer1.LocalReport.SetParameters(param);
            List<CTPN> ctpn = GetList();
            ReportDataSource rds = new ReportDataSource("DatasetPhieuNhap", ctpn);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();

        }
    }
}
