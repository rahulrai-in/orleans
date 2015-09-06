namespace OrleansClasses
{
    using System;
    using System.Threading.Tasks;

    using Orleans;
    using Orleans.Concurrency;
    using Orleans.Providers;

    using OrleansInterfaces;

    [StorageProvider(ProviderName = "AzureStore")]
    [Reentrant]
    public class DeviceGrain : Grain<DeviceGrainState>, IDeviceGrain
    {
        public async Task SetColor(string colorName)
        {
            //// This will save color to state and persist it to storage on executing WriteStateAsync.
            this.State.Color = colorName;
            await this.WriteStateAsync();

            //// We'll invoke Aggregator grain now so that we can collect all different grain requests.
            var aggregatorGrain = this.GrainFactory.GetGrain<IAggregatorGrain>("aggregator");

            //// Set information that aggregator grain would use.
            var grainInformation = new GrainInformation { DeviceId = this.GetPrimaryKeyString(), Time = DateTime.Now, Value = colorName };
            await aggregatorGrain.SetColor(grainInformation);
        }

        public Task<string> GetColor()
        {
            //// This will get last stored color.
            return Task.FromResult(this.State.Color);
        }
    }
}