namespace OrleansWebApplicaton.Controllers
{
    #region

    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    using Newtonsoft.Json;

    using Orleans;
    using Orleans.Runtime.Host;

    using OrleansInterfaces;

    using OrleansWebApplicaton.Helper;

    #endregion

    public class HomeController : Controller
    {
        #region Public Methods and Operators

        [HttpGet]
        public async Task ActivateDeviceGrain(string color)
        {
            if (!AzureClient.IsInitialized)
            {
                AzureClient.Initialize(this.Server.MapPath("~/AzureClientConfiguration.xml"));
            }

            var ipAddress = Routines.GetIPAddress();
            var decodeGrain = GrainClient.GrainFactory.GetGrain<IDecodeGrain>(ipAddress);
            await decodeGrain.DecodeDeviceMessage(string.Format("{0},{1}", ipAddress, color));
        }

        [HttpGet]
        public async Task<JsonResult> GetAggregatorGrainResult(int id)
        {
            if (!AzureClient.IsInitialized)
            {
                AzureClient.Initialize(this.Server.MapPath("~/AzureClientConfiguration.xml"));
            }

            var aggregatorGrain = GrainClient.GrainFactory.GetGrain<IAggregatorGrain>("aggregator");
            var state = await aggregatorGrain.GetGrainInformation(id);
            return this.Json(state, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            return this.View();
        }

        #endregion
    }
}