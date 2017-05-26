using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BankManagement.UI.Common
{
    public class AppConfigs
    {
        public static string JavaBaseServiceUri
        {
            get
            {
                return GetConfig("JavaBaseServiceUri");
            }
        }

        public static string NetBaseServiceUri
        {
            get
            {
                return GetConfig("NetBaseServiceUri");
            }
        }

        private static string GetConfig(string key)
        {
            return ConfigurationManager.AppSettings.AllKeys.Contains(key) ? ConfigurationManager.AppSettings[key] : string.Empty;
        }
    }
}
