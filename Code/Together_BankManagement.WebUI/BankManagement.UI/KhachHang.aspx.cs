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
    public partial class KhachHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {                
                LoadDSKH();
            }
        }

        protected void gvKhachHang_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvKhachHang.PageIndex = e.NewPageIndex;
            LoadDSKH();
        }

        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDSKH();
        }

        protected void gvKhachHang_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                khachHang row = (khachHang)e.Row.DataItem;
                string query = string.Format("maKH={0}", row.maKhachHang);
                e.Row.Cells[0].Text = string.Format("<a onclick=\"openPopupModal('{0}')\">{1}</a>", "InsertUpdateKhachHang.aspx?" + query, row.maKhachHang);

                e.Row.Cells[9].Text = row.gioiTinh ? "Nam" : "Nữ";
            }
        }

        private void LoadDSKH()
        {
            string url = "api/kh/all";
            if (cbxTimKiem.SelectedValue == "MaKH")
            {
                url = "api/kh/id/" + txtTimKiem.Text.ToString();
            }
            else if (cbxTimKiem.SelectedValue == "CMND")
            {
                url = "api/kh/cmnd/" + txtTimKiem.Text.ToString();
            }
            gvKhachHang.DataSource = ServiceConnector.GetDataFromServiceByGet<khachHang>(url, true);
            gvKhachHang.DataBind();
        }    
    }

    public class khachHang
    {
        public int maKhachHang { get; set; }
        public String hoTen { get; set; }
        public Double soDuTaiKhoan { get; set; }
        public DateTime ngaySinh { get; set; }
        public Boolean gioiTinh { get; set; }
        public String diaChiThuongTru { get; set; }
        public String diaChiLienLac { get; set; }
        public String soCMND { get; set; }
        public String dienThoai { get; set; }
        public String email { get; set; }
        public Boolean tinhTrangHonNhan { get; set; }
        public DateTime ngayLap { get; set; }
        public Boolean tinhTrangHoatDong { get; set; }
        public int maCNDangky { get; set; }
    }
}