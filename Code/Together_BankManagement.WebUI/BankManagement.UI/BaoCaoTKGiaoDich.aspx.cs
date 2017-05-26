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
    public partial class BaoCaoTKGiaoDich : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindRefData();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            var filter = new
            {
                fromDate = DateTime.ParseExact(dtTuNgay.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd"),
                toDate = DateTime.ParseExact(dtDenNgay.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd")
            };

            gvBaoCaoGiaoDich.DataSource = ServiceConnector.GetDataFromServiceByPost<TKGD>("api/tongketgd/gettkgd", filter, true);
            gvBaoCaoGiaoDich.DataBind();
        }

        private void BindRefData()
        {
            cbxTruSo.DataSource = ServiceConnector.GetDataFromServiceByGet<TruSo>("api/truso/all", true);
            cbxTruSo.DataBind();

            cbxChiNhanh.DataSource = ServiceConnector.GetDataFromServiceByGet<ChiNhanh>("api/chinhanh/all", true);
            cbxChiNhanh.DataBind();
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