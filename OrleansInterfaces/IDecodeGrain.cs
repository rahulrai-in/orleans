using System.Threading.Tasks;
using Orleans;

namespace OrleansInterfaces
{
    public interface IDecodeGrain : IGrainWithStringKey
    {
        Task DecodeDeviceMessage(string ipAndColorMessage);
    }
}
