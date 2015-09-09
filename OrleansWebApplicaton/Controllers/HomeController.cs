namespace OrleansWebApplicaton.Controllers
{
    #region

    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    using Orleans;
    using Orleans.Runtime.Host;

    using OrleansInterfaces;

    using OrleansWebApplicaton.Helper;

    #endregion

    public class HomeController : Controller
    {
        #region Public Methods and Operators

        [HttpGet]
        public void ActivateDeviceGrain(string color)
        {
            if (!AzureClient.IsInitialized)
            {
                AzureClient.Initialize(this.Server.MapPath("AzureClientConfiguration.xml"));
            }

            var ipAddress = Routines.GetIPAddress();
            var decodeGrain = GrainClient.GrainFactory.GetGrain<IDecodeGrain>(ipAddress);
            decodeGrain.DecodeDeviceMessage(string.Format("{0},{1}", ipAddress, color)).Wait();
        }

        [HttpGet]
        public GrainInformation GetAggregatorGrainResult(int id)
        {
            if (!AzureClient.IsInitialized)
            {
                AzureClient.Initialize(this.Server.MapPath("AzureClientConfiguration.xml"));
            }

            var aggregatorGrain = GrainClient.GrainFactory.GetGrain<IAggregatorGrain>("aggregator");
            return aggregatorGrain.GetGrainInformation(id).Result;
        }

        public ActionResult Index()
        {
            if (!AzureClient.IsInitialized)
            {
                AzureClient.Initialize(this.Server.MapPath("AzureClientConfiguration.xml"));
            }

            //// This code does not work.
            var decodeGrain = GrainClient.GrainFactory.GetGrain<IDecodeGrain>("10.0.0.0");
            decodeGrain.DecodeDeviceMessage("10.0.0.0,VIOLET").Wait();
            var aggregatorGrain = GrainClient.GrainFactory.GetGrain<IAggregatorGrain>("aggregator");
            var data = aggregatorGrain.GetGrainInformation(0).Result;
            return this.Content(string.Format("Device: {0} Value: {1} Time: {2}", data.DeviceId, data.Value, data.Time));
            return this.View();
        }

        #endregion
    }
}