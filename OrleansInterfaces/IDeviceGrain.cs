namespace OrleansInterfaces
{
    #region

    using System.Threading.Tasks;

    using Orleans;

    #endregion

    public interface IDeviceGrain : IGrainWithStringKey
    {
        #region Public Methods and Operators

        Task<string> GetColor();

        Task SetColor(string colorName);

        #endregion
    }
}