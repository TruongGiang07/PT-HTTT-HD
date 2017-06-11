using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BankManagement.UI.Common;

namespace BankManagement.UI
{
    public partial class DangNhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var post = new
            {
                tenDN = txtUserName.Text.Trim(),
                matKhau = txtPassword.Text.Trim()
            };
            List<UserLogin> user = ServiceConnector.GetDataFromServiceByPost<UserLogin>("api/nv/dangnhap", post, true);

            if (user != null && user.Count > 0)
            {
                SessionManager.CurrentUser = user[0];
                if (user[0].LoaiNV == 1)
                {
                    Response.Redirect("BaoCaoTKGiaoDich.aspx");
                }
                else
                {
                    Response.Redirect("KhachHang.aspx");
                }
            }
            else
            {
                lblError.Visible = true;
            }
        }
    }
}