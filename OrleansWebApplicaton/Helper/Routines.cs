namespace OrleansWebApplicaton.Helper
{
    #region

    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Web;

    #endregion

    public static class Routines
    {
        #region Public Methods and Operators

        public static List<string> ColorCollection()
        {
            var colorFileText = File.ReadAllText(HttpContext.Current.Server.MapPath(@"~\Helper\Colors.csv"));
            return colorFileText.Split(',').ToList();
        }

        public static string GetIPAddress()
        {
            var context = HttpContext.Current;
            var ipAddress = context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (!string.IsNullOrEmpty(ipAddress))
            {
                var addresses = ipAddress.Split(',');
                if (addresses.Length != 0)
                {
                    return addresses[0];
                }
            }

            return context.Request.ServerVariables["REMOTE_ADDR"];
        }

        #endregion
    }
}