using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrleansWebApplicaton.Helper
{
    using System.IO;
    using System.Web;

    public static class Routines
    {
        public static string GetIPAddress()
        {
            HttpContext context = System.Web.HttpContext.Current;
            string ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (!string.IsNullOrEmpty(ipAddress))
            {
                string[] addresses = ipAddress.Split(',');
                if (addresses.Length != 0)
                {
                    return addresses[0];
                }
            }

            return context.Request.ServerVariables["REMOTE_ADDR"];
        }

        public static List<string> ColorCollection()
        {
            var colorFileText = File.ReadAllText(HttpContext.Current.Server.MapPath(@"~\Helper\Colors.csv"));
            return colorFileText.Split(',').ToList();
        }
    }
}
