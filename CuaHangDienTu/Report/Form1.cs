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
    public partial class Form1 : Form
    {
        public Form1(long mahd)
        {
            InitializeComponent();
            LoadData(mahd);
        }

        private void LoadData(long mahd)
        {
            CuaHangDienTuEntities entities = new CuaHangDienTuEntities();

            var cthd = from X in entities.CTHDs
                       where X.MaHD == mahd
                       select new
                       {
                           // MaHD = X.MaHD,
                           TenSP = X.SanPham.TenSP,
                           MaSP = X.MaSP,
                           DonGia = X.DonGia,
                           SoLuong = X.SoLuong,
                           ThanhTien = X.ThanhTien
                       };
            List<CTHD1> cTHDs = new List<CTHD1>();
            foreach (var item in cthd)
            {
                CTHD1 cTHD = new CTHD1();
                cTHD.TenSP1 = item.TenSP;
                cTHD.Soluong1 = (int) item.SoLuong;
                cTHD.Dongia1 = (long) item.DonGia;
                cTHD.ThanhTien1 = (long) item.ThanhTien;
                cTHDs.Add(cTHD);
                
            }

            entities.HoaDons.Find(mahd);

            ReportParameter[] param = new ReportParameter[4];
            param[0] = new ReportParameter("MaHD", "" + entities.HoaDons.Find(mahd).MaHD);
            param[3] = new ReportParameter("NgayLap", string.Format("Ngày " +
                entities.HoaDons.Find(mahd).NgayLap));
            param[1] = new ReportParameter("KhachHang", "" + entities.HoaDons.Find(mahd).KhachHang.TenKH);
            param[2] = new ReportParameter("NhanVien", "" + entities.HoaDons.Find(mahd).NhanVien.TenNV);           
         
            
            var reportDataSource = new ReportDataSource("DataSet1",cTHDs);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            //tên hiển thị
            // this.reportViewer1.LocalReport.DisplayName = "Phiếu giao hàng";

            this.reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.RefreshReport();
        }

        
    }
}
