namespace OrleansWebApplicaton.Controllers
{
    #region

    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;
    using System.Web.Http.Results;
    using System.Web.Mvc;

    using Microsoft.WindowsAzure;
    using Microsoft.WindowsAzure.Storage;
    using Microsoft.WindowsAzure.Storage.Table;

    using Newtonsoft.Json;

    using OrleansWebApplicaton.Models;

    #endregion

    public class StatusController : Controller
    {
        #region Public Methods and Operators

        [System.Web.Http.HttpGet]
        public JsonResult GetActivationCount()
        {
            var storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("DataConnectionString"));
            var tableClient = storageAccount.CreateCloudTableClient();
            var table = tableClient.GetTableReference("OrleansSiloMetrics");
            var query = (from entity in table.CreateQuery<DynamicTableEntity>() select entity).ToList();
            var resultSet = from resultValue in query
                            group resultValue by resultValue.RowKey
                                into serverGroup
                                select
                                    new Result
                                        {
                                            ServerName = serverGroup.Key,
                                            Value =
                                                serverGroup.Sum(element => element.Properties["Activations"].Int32Value.Value)
                                        };
            return this.Json(resultSet, JsonRequestBehavior.AllowGet);
        }

        [System.Web.Http.HttpGet]
        public JsonResult GetRequestCount()
        {
            var storageAccount = CloudStorageAccount.Parse(CloudConfigurationManager.GetSetting("DataConnectionString"));
            var tableClient = storageAccount.CreateCloudTableClient();
            var table = tableClient.GetTableReference("OrleansSiloMetrics");
            var query = (from entity in table.CreateQuery<DynamicTableEntity>() select entity).ToList();
            var resultSet = from resultValue in query
                            group resultValue by resultValue.RowKey
                                into serverGroup
                                select
                                    new Result
                                    {
                                        ServerName = serverGroup.Key,
                                        Value =
                                            serverGroup.Sum(element => element.Properties["SentMessages"].Int64Value.Value)
                                    };
            return this.Json(resultSet, JsonRequestBehavior.AllowGet);
        }

        #endregion
    }
}