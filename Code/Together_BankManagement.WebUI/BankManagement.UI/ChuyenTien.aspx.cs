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
            List<khachHang> lskhchuyen = GetKH(txtmakhchuyen.Text.Trim());
            khachHang khchuyen = lskhchuyen[0];
            if (khchuyen.soDuTaiKhoan > double.Parse(txtsotienchuyen.Text.Trim()))
            {
                ServiceConnector.GetDataFromServiceByPost<chuyenTien>("api/gdct/add", CreateChuyenTien(), false);
                khchuyen.soDuTaiKhoan = khchuyen.soDuTaiKhoan - double.Parse(txtsotienchuyen.Text.Trim());
                UpdateKH(khchuyen);
                List<khachHang> lskhnhan = GetKH(txtmakhnhan.Text.Trim());
                khachHang khnhan = lskhnhan[0];
                khnhan.soDuTaiKhoan = khnhan.soDuTaiKhoan + double.Parse(txtsotienchuyen.Text.Trim());
                UpdateKH(khnhan);
                ClearData();
            }
            else
            {
                Console.WriteLine("So Tien Chuyen Lon Hon So Du Tai Khoan");
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
            ct.maKHChuyen = int.Parse(txtmakhchuyen.Text.Trim());
            ct.ngayChuyen = DateTime.ParseExact(txtngaychuyen.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            ct.soTienChuyen = double.Parse(txtsotienchuyen.Text.Trim());
            ct.noiDung = txtnoidung.Text.Trim();
            ct.maKHNhan = int.Parse(txtmakhnhan.Text.Trim());
            ct.maGDVien = 1;
            return ct;
        }

        private void ClearData()
        {
            txtmakhchuyen.Text = null;
            txtcmndchuyen.Text = null;
            txtngaychuyen.Text = null;
            txtsotienchuyen.Text = null;
            txtnoidung.Text = null;
            txtmakhnhan.Text = null;
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