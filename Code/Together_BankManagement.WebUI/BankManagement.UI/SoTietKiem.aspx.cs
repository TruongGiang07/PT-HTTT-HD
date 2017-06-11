using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BankManagement.UI.Common;

namespace BankManagement.UI
{
    public partial class SoTietKiems : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridData();
            }
        }

        protected void gvSoTietKiem_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvSoTietKiem.PageIndex = e.NewPageIndex;
            BindGridData();
        }

        private void BindGridData()
        {
            gvSoTietKiem.DataSource = ServiceConnector.GetDataFromServiceByGet<SoTietKiem>("api/stk/all", isJavaService: false);
            gvSoTietKiem.DataBind();
        }

        protected void gvSoTietKiem_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                SoTietKiem row = (SoTietKiem)e.Row.DataItem;

                e.Row.Cells[7].Text = string.Format("<a onclick='huySo({0})'>{1}</a>", row.MaSoTietKiem, "Hủy Sổ");
            }
        }

        protected void btnHuySo_Click(object sender, EventArgs e)
        {
            ServiceConnector.GetDataFromServiceByPost<SoTietKiem>("api/stk/remove/" + hddMaSTKHuy.Value, null, false);
            BindGridData();
        }
    }

    public class SoTietKiem
    {
        public int MaSoTietKiem { get; set; }
        public Nullable<decimal> SoTienGui { get; set; }
        public Nullable<System.DateTime> NgayGui { get; set; }
        public Nullable<System.DateTime> NgayDaoHan { get; set; }
        public Nullable<int> KyHan { get; set; }
        public Nullable<double> LaiSuat { get; set; }
        public string HoTen { get; set; }
    }
}