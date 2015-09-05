using System.Threading.Tasks;
using Orleans;

namespace OrleansClasses
{
    using OrleansInterfaces;

    public class DecodeGrain : Grain, IDecodeGrain
    {
        public Task DecodeDeviceMessage(string ipAndColorMessage)
        {
            throw new System.NotImplementedException();
        }
    }
}
