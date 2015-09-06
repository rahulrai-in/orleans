using System.Threading.Tasks;
using Orleans;

namespace OrleansClasses
{
    using Orleans.Concurrency;

    using OrleansInterfaces;

    [StatelessWorker]
    [Reentrant]
    public class DecodeGrain : Grain, IDecodeGrain
    {
        public Task DecodeDeviceMessage(string ipAndColorMessage)
        {
            var parts = ipAndColorMessage.Split(',');
            //// The following will create a new grain for device or invoke an existing grain for same device.
            var grain = this.GrainFactory.GetGrain<IDeviceGrain>(parts[0]);
            //// No we'll pass color to the grain.
            return grain.SetColor(parts[1]);
        }
    }
}
