/*
Project Orleans Cloud Service SDK ver. 1.0
 
Copyright (c) Microsoft Corporation
 
All rights reserved.
 
MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and 
associated documentation files (the ""Software""), to deal in the Software without restriction,
including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so,
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO
THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS
OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System;
using System.Threading.Tasks;

namespace OrleansTestHost
{
    using Orleans;

    using OrleansInterfaces;

    /// <summary>
    /// Orleans test silo host
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            // The Orleans silo environment is initialized in its own app domain in order to more
            // closely emulate the distributed situation, when the client and the server cannot
            // pass data via shared memory.
            AppDomain hostDomain = AppDomain.CreateDomain("OrleansHost", null, new AppDomainSetup
            {
                AppDomainInitializer = InitSilo,
                AppDomainInitializerArguments = args,
            });

            Orleans.GrainClient.Initialize("DevTestClientConfiguration.xml");

            // TODO: once the previous call returns, the silo is up and running.
            //       This is the place your custom logic, for example calling client logic
            //       or initializing an HTTP front end for accepting incoming requests.

            Console.WriteLine("Orleans Silo is running.\nPress Enter to terminate...");

            //// Test Code Starts
            var decodeGrain = GrainClient.GrainFactory.GetGrain<IDecodeGrain>("10.0.0.0");
            decodeGrain.DecodeDeviceMessage("10.0.0.0,VIOLET").Wait();

            var aggregatorGrain = GrainClient.GrainFactory.GetGrain<IAggregatorGrain>("aggregator");
            for (int i = 0; i < 5; i++)
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
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Queue Item {0}: ", i);
                var data = aggregatorGrain.GetGrainInformation(i).Result;
                Console.WriteLine("Device: {0} Value: {1} Time: {2}", data.DeviceId, data.Value, data.Time);
            }

            Console.ReadKey();
            //// Test Code Ends

            hostDomain.DoCallBack(ShutdownSilo);
        }

        static void InitSilo(string[] args)
        {
            hostWrapper = new OrleansHostWrapper(args);

            if (!hostWrapper.Run())
            {
                Console.Error.WriteLine("Failed to initialize Orleans silo");
            }
        }

        static void ShutdownSilo()
        {
            if (hostWrapper != null)
            {
                hostWrapper.Dispose();
                GC.SuppressFinalize(hostWrapper);
            }
        }

        private static OrleansHostWrapper hostWrapper;
    }
}
