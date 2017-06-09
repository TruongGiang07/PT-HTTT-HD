using BankManagement.UI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankManagement.UI
{
    public partial class BCTKGD_XemDSKhachHang : System.Web.UI.Page
    {
        private DateTime _NgayGD
        {
            get
            {
                if (Request.QueryString.Count > 0)
                {
                    DateTime ngayGD;
                    if (!DateTime.TryParse(Request.QueryString["ngayGD"], out ngayGD))
                    {
                        ngayGD = DateTime.Now;
                    }
                    return ngayGD;
                }
                return DateTime.Now;
            }
        }
        private int _MaTruSo
        {
            get
            {
                if (Request.QueryString.Count > 0)
                {
                    int maTS;
                    if (!int.TryParse(Request.QueryString["truSo"].Trim(), out maTS))
                    {
                        maTS = -1;
                    }
                    return maTS;
                }
                return -1;
            }
        }
        private int _MaChiNhanh
        {
            get
            {
                if (Request.QueryString.Count > 0)
                {
                    int maCN;
                    if (!int.TryParse(Request.QueryString["chiNhanh"].Trim(), out maCN))
                    {
                        maCN = -1;
                    }
                    return maCN;
                }
                return -1;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetDataSource();
                lblNgay.Text = string.Format("Ngày: {0}", _NgayGD.ToString("dd/MM/yyyy"));
            }
        }

        protected void gvDSGiaoDich_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvDSGiaoDich.PageIndex = e.NewPageIndex;
            GetDataSource();
        }

        private void GetDataSource()
        {
            var filter = new
            {
                ngayGiaoDich = _NgayGD.ToString("yyyy-MM-dd"),
                maTruSo = _MaTruSo,
                maChiNhanh = _MaChiNhanh
            };
            gvDSGiaoDich.DataSource = ServiceConnector.GetDataFromServiceByPost<TKGDDetail>("api/tongketgd/getDSGDByNgay", filter, true);
            gvDSGiaoDich.DataBind();
        }

        protected void gvDSGiaoDich_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                TKGDDetail row = (TKGDDetail)e.Row.DataItem;
                string tenGD = "Rút tiền";
                if (row.loaiGD == "2")
                {
                    tenGD = "Gửi tiền";
                }
                else if (row.loaiGD == "3")
                {
                    tenGD = "Chuyển tiền";
                }
                e.Row.Cells[4].Text = tenGD;
            }
        }
    }

    public class TKGDDetail
    {
        public int maKhachHang { get; set; }
        public string hoTen { get; set; }
        public string soCMND { get; set; }
        public double soTienGD { get; set; }
        public string loaiGD { get; set; }
    }
}