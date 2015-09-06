using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OrleansWebApplicaton.Startup))]
namespace OrleansWebApplicaton
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
