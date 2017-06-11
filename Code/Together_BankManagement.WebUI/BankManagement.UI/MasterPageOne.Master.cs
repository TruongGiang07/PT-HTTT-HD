using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BankManagement.UI.Common;

namespace BankManagement.UI
{
    public partial class MasterPageOne : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (SessionManager.CurrentUser != null && SessionManager.CurrentUser.MaNV > 0)
            {
                phdQuanLy.Visible = SessionManager.CurrentUser.LoaiNV == 1;
                phdNhanVien.Visible = SessionManager.CurrentUser.LoaiNV == 2;
                lblHoTen.Text = SessionManager.CurrentUser.HoTen;
            }
            else
            {
                Response.Redirect("DangNhap.aspx");
            }
        }

        protected void lbtnLogOff_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("DangNhap.aspx");
        }
    }
}