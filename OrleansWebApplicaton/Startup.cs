#region

using Microsoft.Owin;

using OrleansWebApplicaton;

#endregion

[assembly: OwinStartup(typeof(Startup))]

namespace OrleansWebApplicaton
{
    #region

    using Owin;

    #endregion

    public class Startup
    {
        #region Public Methods and Operators

        public void Configuration(IAppBuilder app)
        {
        }

        #endregion
    }
}