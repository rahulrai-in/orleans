namespace OrleansWebApplicaton
{
    #region

    using System.Web.Mvc;

    #endregion

    public class FilterConfig
    {
        #region Public Methods and Operators

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        #endregion
    }
}