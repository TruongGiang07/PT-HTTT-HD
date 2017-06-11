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
    public partial class ChuyenTien : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnchuyentien_Click(object sender, EventArgs e)
        {
            List<khachHang> lskhchuyen = GetKH(txtMaKHChuyenThat.Text.Trim());
            khachHang khchuyen = lskhchuyen[0];
            if (khchuyen.soDuTaiKhoan > double.Parse(txtsotienchuyen.Text.Trim()))
            {
                ServiceConnector.GetDataFromServiceByPost<chuyenTien>("api/gdct/add", CreateChuyenTien(), false);
                khchuyen.soDuTaiKhoan = khchuyen.soDuTaiKhoan - double.Parse(txtsotienchuyen.Text.Trim());
                UpdateKH(khchuyen);
                List<khachHang> lskhnhan = GetKH(txtMaKHNhanThat.Text.Trim());
                khachHang khnhan = lskhnhan[0];
                khnhan.soDuTaiKhoan = khnhan.soDuTaiKhoan + double.Parse(txtsotienchuyen.Text.Trim());
                UpdateKH(khnhan);
                ClearData();
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Chuyển Tiền thành công.');", true);
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Số Tiền Chuyển Lớn Hơn Số Dư Tài Khoản!');", true);
            }
        }

        private List<khachHang> GetKH(string makh)
        {
            return ServiceConnector.GetDataFromServiceByGet<khachHang>("api/kh/id/" + makh, true);
        }

        private void UpdateKH(khachHang kh)
        {
            ServiceConnector.InsertOrUpdate<khachHang>("api/kh/upkh", kh , true);
        }

        private chuyenTien CreateChuyenTien()
        {
            var ct = new chuyenTien();
            ct.maKHChuyen = int.Parse(txtMaKHChuyenThat.Text.Trim());
            ct.ngayChuyen = DateTime.Now;
            ct.soTienChuyen = double.Parse(txtsotienchuyen.Text.Trim());
            ct.noiDung = txtnoidung.Text.Trim();
            ct.maKHNhan = int.Parse(txtMaKHNhanThat.Text.Trim());
            ct.maGDVien = SessionManager.CurrentUser.MaNV;
            return ct;
        }

        private void ClearData()
        {
            txtMaKHChuyenThat.Text = null;
            txtcmndchuyen.Text = null;
            txtsotienchuyen.Text = null;
            txtnoidung.Text = null;
            txtMaKHNhanThat.Text = null;
            txtcmndnhan.Text = null;
            txthoten.Text = null;
        }
    }

    public class chuyenTien
    {
        public int maChuyenTien { get; set; }
        public Double soTienChuyen { get; set; }
        public DateTime ngayChuyen { get; set; }
        public String noiDung { get; set; }
        public int maKHChuyen { get; set; }
        public int maKHNhan { get; set; }
        public int maGDVien { get; set; }
    }

}