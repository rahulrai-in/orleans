using System.Threading.Tasks;
using Orleans;

namespace OrleansInterfaces
{
    public interface IDecodeGrain : IGrainWithIntegerKey
    {
        Task DecodeDeviceMessage(string ipAndColorMessage);
    }
}
