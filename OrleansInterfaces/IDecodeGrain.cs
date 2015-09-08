namespace OrleansInterfaces
{
    #region

    using System.Threading.Tasks;

    using Orleans;

    #endregion

    public interface IDecodeGrain : IGrainWithStringKey
    {
        #region Public Methods and Operators

        Task DecodeDeviceMessage(string ipAndColorMessage);

        #endregion
    }
}