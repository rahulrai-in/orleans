namespace OrleansInterfaces
{
    using System.Threading.Tasks;

    using Orleans;

    public interface IAggregatorGrain : IGrainWithStringKey
    {
        Task<GrainInformation> GetGrainInformation(int position);

        Task SetColor(GrainInformation grainInformation);
    }
}