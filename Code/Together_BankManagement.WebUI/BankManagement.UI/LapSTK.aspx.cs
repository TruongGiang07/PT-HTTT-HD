using BankManagement.UI.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankManagement.UI
{
    public partial class LapSTK : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTaoSTK_Click(object sender, EventArgs e)
        {
            SoTietKiemInput stk = new SoTietKiemInput();
            int kyHan = int.Parse(txtKyHan.Text.Trim()); 
            stk.SoTienGui = decimal.Parse(txtSoTienGui.Text.Trim());
            stk.NgayGui = DateTime.Now;
            stk.NgayDaoHan = DateTime.Now.AddMonths(kyHan);
            stk.KyHan = kyHan;            
            stk.LaiSuat = double.Parse(txtLaiSuat.Text.Trim());
            stk.MaKHGui = int.Parse(txtMaKHGui.Text.Trim());
            stk.TinhTrang = 1;

            ServiceConnector.InsertOrUpdate<SoTietKiemInput>("api/stk/add", stk, false);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "reload", "parent.closePopupModal(); parent.reloadPage();", true);
        }
    }

    public class SoTietKiemInput
    {
        public int MaSoTietKiem { get; set; }
        public Nullable<decimal> SoTienGui { get; set; }
        public Nullable<System.DateTime> NgayGui { get; set; }
        public Nullable<System.DateTime> NgayDaoHan { get; set; }
        public Nullable<int> KyHan { get; set; }
        public Nullable<double> LaiSuat { get; set; }
        public Nullable<int> MaKHGui { get; set; }
        public Nullable<byte> TinhTrang { get; set; }
    }
}