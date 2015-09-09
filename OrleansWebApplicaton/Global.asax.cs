namespace OrleansWebApplicaton
{
    #region

    using System.Web;
    using System.Web.Mvc;
    using System.Web.Optimization;
    using System.Web.Routing;

    using Microsoft.WindowsAzure.ServiceRuntime;

    using Orleans;
    using Orleans.Runtime.Host;

    #endregion

    public class MvcApplication : HttpApplication
    {
        #region Methods

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //// AzureClient.Initialize(this.Server.MapPath("AzureClientConfiguration.xml"));
        }

        #endregion
    }
}