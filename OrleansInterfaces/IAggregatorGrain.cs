namespace OrleansInterfaces
{
    #region

    using System.Threading.Tasks;

    using Orleans;

    #endregion

    public interface IAggregatorGrain : IGrainWithStringKey
    {
        #region Public Methods and Operators

        Task<GrainInformation> GetGrainInformation(int position);

        Task SetColor(GrainInformation grainInformation);

        #endregion
    }
}