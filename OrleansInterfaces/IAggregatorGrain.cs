namespace OrleansInterfaces
{
    using System.Threading.Tasks;

    using Orleans;

    public interface IAggregatorGrain : IGrainWithIntegerCompoundKey
    {
        Task<string> GetColor();
    }
}