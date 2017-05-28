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

namespace BankManagement.UI
{
    public partial class BaoCaoTKGiaoDich : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //BindRefData();
            gvBaoCaoGiaoDich.DataSource = GetTestData();
            gvBaoCaoGiaoDich.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            //var filter = new
            //{
            //    fromDate = DateTime.ParseExact(dtTuNgay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"),
            //    toDate = DateTime.ParseExact(dtDenNgay.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd")
            //};

            //gvBaoCaoGiaoDich.DataSource = ServiceConnector.GetDataFromServiceByPost<TKGD>("api/tongketgd/gettkgd", filter, true);
            gvBaoCaoGiaoDich.DataSource = GetTestData();
            gvBaoCaoGiaoDich.DataBind();
        }

        private void BindRefData()
        {
            cbxTruSo.DataSource = ServiceConnector.GetDataFromServiceByGet<TruSo>("api/truso/all", true);
            cbxTruSo.DataBind();

            cbxChiNhanh.DataSource = ServiceConnector.GetDataFromServiceByGet<ChiNhanh>("api/chinhanh/all", true);
            cbxChiNhanh.DataBind();
        }

        private List<TKGD> GetTestData()
        {
            var res = new List<TKGD>();
            for (int i = 1; i <= 10; i++)
            {
                var item = new TKGD();
                item.ngayGiaoDich = DateTime.Now;
                item.tenChiNhanh = "CN " + i;
                item.tenTruSo = "TS " + i;
                item.slGDRutTien = 123;
                item.soTienGDRutTien = 3454000;
                item.slGDGuiTien = 458;
                item.soTienGDGuiTien = 456000000;
                item.slGDChuyenTien = 999;
                item.soTienGDChuyenTien = 24000000;
                res.Add(item);
            }

            return res;
        }

        protected void gvBaoCaoGiaoDich_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvBaoCaoGiaoDich.PageIndex = e.NewPageIndex;
            gvBaoCaoGiaoDich.DataSource = GetTestData();
            gvBaoCaoGiaoDich.DataBind();
        }

        protected void gvBaoCaoGiaoDich_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                TKGD row = (TKGD)e.Row.DataItem;
                e.Row.Cells[3].Text = string.Format("<a href='#'>{0}</a>", row.slGDRutTien);
            }
        }
                
    }

    public class TKGD
    {
        public DateTime ngayGiaoDich { get; set; }
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
}