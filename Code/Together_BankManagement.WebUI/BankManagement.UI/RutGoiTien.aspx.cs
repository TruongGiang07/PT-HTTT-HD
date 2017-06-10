using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BankManagement.UI.Common;
using System.Globalization;
namespace BankManagement.UI
{
    public partial class RutGoiTien : System.Web.UI.Page
    {
        private int _LoaiGiaoDich
        {
            get
            {
                if (Request.QueryString.Count > 0)
                {
                    int maLoaiGiaoDich;
                    if (int.TryParse(Request.QueryString["loaiGD"].Trim(), out maLoaiGiaoDich))
                    {
                        return maLoaiGiaoDich;
                    }
                }
                return -1;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (_LoaiGiaoDich == 1)
            {
                maKhachHang.Text = "Mã Khách Hàng Rút Tiền: ";
                hoTen.Text = "Khách Hàng Rút Tiền: ";
                cMND.Text = "Chứng Minh Nhân Dân: ";
                soTien.Text = "Số Tiền Cần Rút: ";
                btnRutGoi.Text = "Rút Tiền";
            }
            if (_LoaiGiaoDich == 2)
            {
                maKhachHang.Text = "Mã Khách Hàng Gởi Tiền: ";
                hoTen.Text = "Khách Hàng Gởi Tiền: ";
                cMND.Text = "Chứng Minh Nhân Dân: ";
                soTien.Text = "Số Tiền Cần Gởi: ";
                btnRutGoi.Text = "Gởi Tiền";
            }
        }

        protected void btnRutGoi_Click(object sender, EventArgs e)
        {
            List<khachHang> lskh = GetKH(int.Parse(txtMaKhachHangThiet.Text.Trim().ToString()));
            khachHang kh = lskh[0];
            if (_LoaiGiaoDich == 1)
            {
                // Kiểm tra còn tiền rút hay ko
                if (kh.soDuTaiKhoan > double.Parse(txtSoTien.Text.Trim()))
                {
                    ServiceConnector.GetDataFromServiceByPost<giaoDich>("api/gd/add", CreateGiaoDich(), false);
                    kh.soDuTaiKhoan = kh.soDuTaiKhoan - double.Parse(txtSoTien.Text.Trim());
                    UpdateKH(kh);
                    ClearData();
                }
                else
                {
                    Console.WriteLine("So Tien Rut Lon Hon So Du Tai Khoan");
                }
            }
            else
            {
                if (_LoaiGiaoDich == 2)
                {
                    // Gởi tiền ko cần kiểm tra
                    ServiceConnector.GetDataFromServiceByPost<giaoDich>("api/gd/add", CreateGiaoDich(), false);
                    kh.soDuTaiKhoan = kh.soDuTaiKhoan + double.Parse(txtSoTien.Text.Trim());
                    UpdateKH(kh);
                    ClearData();
                }
            }

        }
        private void ClearData()
        {
            txtMaKhachHang.Text = null;
            txtHoTenKhachHang.Text = null;
            txtCMND.Text = null;
            txtSoTien.Text = null;
        }
        private void UpdateKH(khachHang kh)
        {
            ServiceConnector.InsertOrUpdate<khachHang>("api/kh/upkh", kh, true);
        }
        private giaoDich CreateGiaoDich()
        {
            var ct = new giaoDich();
            ct.maKHGiaoDich = int.Parse(txtMaKhachHangThiet.Text.Trim().ToString());
            //ct.ngayGiaoDich = DateTime.ParseExact(DateTime.Now.ToString().Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            ct.ngayGiaoDich = DateTime.Now;
            ct.soTienGiaoDich = double.Parse(txtSoTien.Text.Trim());
            ct.maGDVien = 1;
            if (_LoaiGiaoDich==1)
            {
                ct.maLoaiGD = 1;
            }
            else
            {
                ct.maLoaiGD = 2;
            }
            return ct;
        }
        private List<khachHang> GetKH(int makh)
        {
            return ServiceConnector.GetDataFromServiceByGet<khachHang>("api/kh/id/" + makh, true);
        }


    }
    public class giaoDich
    {
        public int maGiaoDich { get; set; }
        public Double soTienGiaoDich { get; set; }
        public DateTime ngayGiaoDich { get; set; }
        public int maKHGiaoDich { get; set; }
        public int maGDVien { get; set; }
        public int maLoaiGD { get; set; }
    }
}