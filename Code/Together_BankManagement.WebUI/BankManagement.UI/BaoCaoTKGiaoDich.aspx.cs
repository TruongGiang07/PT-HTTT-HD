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
using System.Data;
using Newtonsoft.Json;

namespace BankManagement.UI
{
    public partial class BaoCaoTKGiaoDich : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dtTuNgay.Text = DateTime.Now.AddDays(-2).ToString("dd/MM/yyyy");
                dtDenNgay.Text = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy");
                dtThangOrNam.Text = DateTime.Now.ToString("dd/MM/yyyy");
                BindRefData();
                BindGrid();
            }
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            ShowHideDate();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindRefData()
        {
            cbxTruSo.DataSource = ServiceConnector.GetDataFromServiceByGet<TruSo>("api/truso/all", true);
            cbxTruSo.DataBind();

            cbxChiNhanh.DataSource = ServiceConnector.GetDataFromServiceByGet<ChiNhanh>("api/chinhanh/all", true);
            cbxChiNhanh.DataBind();
        }

        private List<T> GetTKGDData<T>() where T : class
        {            
            return ServiceConnector.GetDataFromServiceByPost<T>("api/tongketgd/gettkgd", GetFilter(), true);
        }

        protected void gvBaoCaoGiaoDich_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvBaoCaoGiaoDich.PageIndex = e.NewPageIndex;
            gvBaoCaoGiaoDich.DataSource = GetTKGDData<TKGD>();
            gvBaoCaoGiaoDich.DataBind();
        }

        protected void gvBaoCaoGiaoDich_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                TKGD row = (TKGD)e.Row.DataItem;
                string query = string.Format("ngayGD={0}&truSo={1}&chiNhanh={2}", row.ngayGiaoDich.ToShortDateString(), row.maTruSo, row.maChiNhanh);
                e.Row.Cells[0].Text = string.Format("<a href='#' onclick=\"openPopupModal('{0}')\">{1:dd/MM/yyyy}</a>", "BCTKGD_XemDSKhachHang.aspx?" + query, row.ngayGiaoDich);
            }
        }

        private void ShowHideDate()
        {
            if (rdLoaiNgay.SelectedValue == "Ngay")
            {
                dtThang.Attributes.Add("style", "display:none");
                dtNgayGiaoDich.Attributes.Add("style", "");
            }
            else
            {
                dtThang.Attributes.Add("style", "");
                dtNgayGiaoDich.Attributes.Add("style", "display:none");
            }
        }        

        private object GetFilter()
        {
            string fromDate, toDate;
            if (rdLoaiNgay.SelectedValue == "Ngay")
            {
                fromDate = dtTuNgay.Text.Trim();
                toDate = dtDenNgay.Text.Trim();
            }
            else
            {
                DateTime thangOrNam = DateTime.ParseExact(dtThangOrNam.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime beginDateOfMonth = new DateTime(thangOrNam.Year, thangOrNam.Month, 1);
                fromDate = beginDateOfMonth.ToString("dd/MM/yyyy");
                toDate = beginDateOfMonth.AddMonths(1).AddDays(-1).ToString("dd/MM/yyyy");
            }
            string from = DateTime.ParseExact(fromDate, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            string to = DateTime.ParseExact(toDate, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            var filter = new
            {
                fromDate = from,
                toDate = to,
                maTruSo = cbxTruSo.SelectedValue,
                maChiNhanh = cbxChiNhanh.SelectedValue
            };
            return filter;
        }

        private void BindGrid()
        {
            List<TKGD> source = GetTKGDData<TKGD>();
            gvBaoCaoGiaoDich.DataSource = source;
            gvBaoCaoGiaoDich.DataBind();

            if (source.Count > 0)
            {
                chartContainer.Visible = true;
                string json = JsonConvert.SerializeObject(GetFilter());
                Page.ClientScript.RegisterStartupScript(this.GetType(), "drawChart", string.Format("drawChart('{0}');", json), true);
            }
            else
            {
                chartContainer.Visible = false;
            }
        }
    }

    public class TKGD
    {
        public DateTime ngayGiaoDich { get; set; }
        public int maTruSo { get; set; }
        public int maChiNhanh { get; set; }
        public string tenChiNhanh { get; set; }
        public string tenTruSo { get; set; }
        public int slGDRutTien { get; set; }
        public double soTienGDRutTien { get; set; }
        public int slGDGuiTien { get; set; }
        public double soTienGDGuiTien { get; set; }
        public int slGDChuyenTien { get; set; }
        public double soTienGDChuyenTien { get; set; }
    }

    public class ChiNhanh
    {
        public int maChiNhanh { get; set; }
        public String tenChiNhanh { get; set; }
        public String diaChi { get; set; }
        public String soDT { get; set; }
        public int maTSTrucThuoc { get; set; }
    }

    public class TruSo
    {
        public int maTruSo { get; set; }
        public String tenTruSo { get; set; }
        public String diaChi { get; set; }
        public String soDT { get; set; }
    }

    public class TKGDTotal
    {
        public int sumSLGDRutTien { get; set; }
        public double sumSoTienGDRutTien { get; set; }
        public int sumSLGDGuiTien { get; set; }
        public double sumSoTienGDGuiTien { get; set; }
        public int sumSLGDChuyenTien { get; set; }
        public double sumSoTienGDChuyenTien { get; set; }
    }
}