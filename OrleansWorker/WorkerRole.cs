namespace OrleansWorker
{
    #region

    using System.Diagnostics;
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;

    using Microsoft.WindowsAzure.ServiceRuntime;

    using Orleans.Runtime.Host;

    #endregion

    public class WorkerRole : RoleEntryPoint
    {
        #region Fields

        private readonly CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        private readonly ManualResetEvent runCompleteEvent = new ManualResetEvent(false);

        private AzureSilo cloudSilo;

        #endregion

        #region Public Methods and Operators

        public override bool OnStart()
        {
            // Set the maximum number of concurrent connections
            ServicePointManager.DefaultConnectionLimit = 12;

            this.cloudSilo = new AzureSilo();
            var success = this.cloudSilo.Start();

            return success;
        }

        public override void OnStop()
        {
            Trace.TraceInformation("OrleansWorker is stopping");

            this.cancellationTokenSource.Cancel();
            this.runCompleteEvent.WaitOne();

            base.OnStop();

            Trace.TraceInformation("OrleansWorker has stopped");
        }

        public override void Run()
        {
            this.cloudSilo.Run();
        }

        #endregion

        #region Methods

        private async Task RunAsync(CancellationToken cancellationToken)
        {
            // TODO: Replace the following with your own logic.
            while (!cancellationToken.IsCancellationRequested)
            {
                Trace.TraceInformation("Working");
                await Task.Delay(1000);
            }
        }

        #endregion
    }
}