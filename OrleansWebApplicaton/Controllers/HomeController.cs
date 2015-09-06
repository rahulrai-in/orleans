using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrleansWebApplicaton.Controllers
{
    using System.Threading;

    using OrleansWebApplicaton.Models;

    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return this.View();
        }

        [HttpGet]
        public JsonResult GetAggregatorGrainResult(int id)
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            return this.Json(new AggragatorOutput() { Color = "Red", IPAddress = "10.0.0.1" }, JsonRequestBehavior.AllowGet);
        }
    }
}