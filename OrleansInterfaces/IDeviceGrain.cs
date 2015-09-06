namespace OrleansInterfaces
{
    using System.Threading.Tasks;

    using Orleans;

    public interface IDeviceGrain : IGrainWithStringKey
    {
        Task SetColor(string colorName);

        Task<string> GetColor();
    }
}