namespace OrleansTestHost
{
    #region

    using System;

    using Orleans;

    using OrleansInterfaces;

    #endregion

    /// <summary>
    ///     Orleans test silo host
    /// </summary>
    public class Program
    {
        #region Static Fields

        private static OrleansHostWrapper hostWrapper;

        #endregion

        #region Methods

        private static void InitSilo(string[] args)
        {
            hostWrapper = new OrleansHostWrapper(args);

            if (!hostWrapper.Run())
            {
                Console.Error.WriteLine("Failed to initialize Orleans silo");
            }
        }

        private static void Main(string[] args)
        {
            // The Orleans silo environment is initialized in its own app domain in order to more
            // closely emulate the distributed situation, when the client and the server cannot
            // pass data via shared memory.
            var hostDomain = AppDomain.CreateDomain(
                "OrleansHost",
                null,
                new AppDomainSetup { AppDomainInitializer = InitSilo, AppDomainInitializerArguments = args });

            GrainClient.Initialize("DevTestClientConfiguration.xml");

            // TODO: once the previous call returns, the silo is up and running.
            //       This is the place your custom logic, for example calling client logic
            //       or initializing an HTTP front end for accepting incoming requests.

            Console.WriteLine("Orleans Silo is running.\nPress Enter to terminate...");

            //// Test Code Starts
            var decodeGrain = GrainClient.GrainFactory.GetGrain<IDecodeGrain>("10.0.0.0");
            decodeGrain.DecodeDeviceMessage("10.0.0.0,VIOLET").Wait();

            var aggregatorGrain = GrainClient.GrainFactory.GetGrain<IAggregatorGrain>("aggregator");
            for (var i = 0; i < 5; i++)
            {
                Console.Write("Queue Item {0}: ", i);
                var data = aggregatorGrain.GetGrainInformation(i).Result;
                Console.WriteLine("Device: {0} Value: {1} Time: {2}", data.DeviceId, data.Value, data.Time);
            }

            decodeGrain = GrainClient.GrainFactory.GetGrain<IDecodeGrain>("10.0.0.1");
            decodeGrain.DecodeDeviceMessage("10.0.0.1,RED").Wait();

            decodeGrain = GrainClient.GrainFactory.GetGrain<IDecodeGrain>("10.0.0.2");
            decodeGrain.DecodeDeviceMessage("10.0.0.2,YELLOW").Wait();

            aggregatorGrain = GrainClient.GrainFactory.GetGrain<IAggregatorGrain>("aggregator");
            for (var i = 0; i < 5; i++)
            {
                Console.Write("Queue Item {0}: ", i);
                var data = aggregatorGrain.GetGrainInformation(i).Result;
                Console.WriteLine("Device: {0} Value: {1} Time: {2}", data.DeviceId, data.Value, data.Time);
            }

            Console.ReadKey();
            //// Test Code Ends

            hostDomain.DoCallBack(ShutdownSilo);
        }

        private static void ShutdownSilo()
        {
            if (hostWrapper != null)
            {
                hostWrapper.Dispose();
                GC.SuppressFinalize(hostWrapper);
            }
        }

        #endregion
    }
}