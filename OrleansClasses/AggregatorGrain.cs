namespace OrleansClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Orleans;
    using Orleans.Concurrency;
    using Orleans.Providers;

    using OrleansInterfaces;

    [StorageProvider(ProviderName = "AzureStore")]
    [Reentrant]
    public class AggregatorGrain : Grain<AggregatorGrainState>, IAggregatorGrain
    {
        public Task<GrainInformation> GetGrainInformation(int position)
        {
            //// Filter out edge cases.
            if (this.State == null || this.State.GrainInformation.Count == 0 || position < 0 || position > 19)
            {
                return null;
            }

            //// If index is out of range.
            if (position > this.State.GrainInformation.Count - 1)
            {
                return Task.FromResult(this.State.GrainInformation.LastOrDefault());
            }

            return Task.FromResult(this.State.GrainInformation[position]);
        }

        public async Task SetColor(GrainInformation grainInformation)
        {
            //// Initialize state if no record is present.
            if (this.State.GrainInformation == null)
            {
                this.State.GrainInformation = new List<GrainInformation>();
            }

            //// Don't add more than 20 requests in queue. If grain request is already present, delete and add it.
            var existingGrain = this.State.GrainInformation.FirstOrDefault(element => element.DeviceId == grainInformation.DeviceId);
            if (null != existingGrain)
            {
                this.State.GrainInformation.Remove(existingGrain);
            }

            this.State.GrainInformation.Add(grainInformation);
            if (this.State.GrainInformation.Count > 20)
            {
                this.State.GrainInformation.RemoveRange(0, this.State.GrainInformation.Count - 20);
            }

            //// Persist state.
            await this.WriteStateAsync();
        }
    }
}