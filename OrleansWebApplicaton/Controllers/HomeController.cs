namespace OrleansWebApplicaton.Controllers
{
    #region

    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    using Orleans;

    using OrleansInterfaces;

    using OrleansWebApplicaton.Helper;

    #endregion

    public class HomeController : Controller
    {
        #region Public Methods and Operators

        [HttpGet]
        public Task ActivateDeviceGrain(string color)
        {
            var ipAddress = Routines.GetIPAddress();
            var decodeGrain = GrainClient.GrainFactory.GetGrain<IDecodeGrain>(ipAddress);
            return decodeGrain.DecodeDeviceMessage(string.Format("{0},{1}", ipAddress, color));
        }

        [HttpGet]
        public Task<GrainInformation> GetAggregatorGrainResult(int id)
        {
            var aggregatorGrain = GrainClient.GrainFactory.GetGrain<IAggregatorGrain>("aggregator");
            return aggregatorGrain.GetGrainInformation(id);
        }

        public ActionResult Index()
        {
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