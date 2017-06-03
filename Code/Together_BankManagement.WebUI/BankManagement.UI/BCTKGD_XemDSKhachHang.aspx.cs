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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count > 0)
            {
                string ngayGD = Request.QueryString["ngayGD"];
                string tenTruSo = Request.QueryString["truSo"];
                string tenCN = Request.QueryString["chiNhanh"];
                txtTest.Text = string.Format("{0} - {1} - {2}", ngayGD, tenTruSo, tenCN);
            }
        }
    }
}