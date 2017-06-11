using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BankManagement.UI.Common
{
    public class SessionManager
    {
        public static UserLogin CurrentUser
        {
            get
            {
                if (HttpContext.Current.Session["CurrentUser"] == null)
                {
                    HttpContext.Current.Session["CurrentUser"] = new UserLogin();
                }
                return (UserLogin)HttpContext.Current.Session["CurrentUser"];
            }
            set
            {
                HttpContext.Current.Session["CurrentUser"] = value;
            }
        }
    }

    public class UserLogin
    {
        public int MaNV { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string HoTen { get; set; }
        public int LoaiNV { get; set; }
    }
}
