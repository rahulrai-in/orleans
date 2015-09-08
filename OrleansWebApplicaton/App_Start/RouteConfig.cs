namespace OrleansWebApplicaton
{
    #region

    using System.Web.Mvc;
    using System.Web.Routing;

    #endregion

    public class RouteConfig
    {
        #region Public Methods and Operators

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional });
        }

        #endregion
    }
}