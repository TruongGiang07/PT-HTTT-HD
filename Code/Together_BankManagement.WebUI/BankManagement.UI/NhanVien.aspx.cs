using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BankManagement.UI.Common;
using System.Globalization;

namespace BankManagement.UI
{
    public partial class NhanVien : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDSNV();
            }
        }

       

        protected void gvNhanVien_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
              gvNhanVien.PageIndex = e.NewPageIndex;
              
              LoadDSNV();
                
        }
        protected void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDSNV();
        }
   
      //private List<TKGD> GetTestData()
      //  {
      //      var res = new List<TKGD>();
      //      for (int i = 1; i <= 15; i++)
      //      {
      //          var item = new TKGD();
      //          item.maNhanVien = 1;
      //          item.hoTen = "Phạm Đăng Khoa";
      //          item.ngaySinh = DateTime.Now;
      //          item.dienThoai = "0997007909";
      //          item.diaChi = "352/40 NĐC";
      //          item.gioiTinh = false;
      //          item.chiNhanh = 1;
      //          item.tenDangNhap = "khoasathu";
      //          item.matKhau = "12345";
      //          res.Add(item);
      //      }

      //      return res;
      //  }
        
        protected void gvNhanVien_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                nhanVien row = (nhanVien)e.Row.DataItem;
                string query = string.Format("maNV={0}", row.maNhanVien);
                e.Row.Cells[0].Text = string.Format("<a onclick=\"openPopupModal('{0}')\">{1}</a>", "InsertUpdateNhanVien.aspx?" + query, row.maNhanVien);

                e.Row.Cells[5].Text = row.gioiTinh ? "Nam" : "Nữ";
            }
        }
         
      private void LoadDSNV()
      {
          string url = "api/nv/all";
          if (cbxTimKiem.SelectedValue == "MaNV")
          {
              url = "api/nv/id/" + txtTimKiem.Text.ToString();
          }
          else if (cbxTimKiem.SelectedValue == "CMND")
          {
              url = "api/nv/hoten/" + txtTimKiem.Text.ToString();
          }
          gvNhanVien.DataSource = ServiceConnector.GetDataFromServiceByGet<nhanVien>(url, true);
          gvNhanVien.DataBind();
      }    
      
    }
    public class nhanVien
    {
        public int maNhanVien { get; set; }
        public string hoTen { get; set; }
        public DateTime ngaySinh { get; set; }
        public String soDienThoai { get; set; }
        public string diaChi { get; set; }
        public bool gioiTinh { get; set; }
        public int maCNLamViec { get; set; }
        public string tenDangNhap { get; set; }
        public string matKhau { get; set; }
    }
}