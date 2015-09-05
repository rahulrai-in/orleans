namespace OrleansInterfaces
{
    using System.Threading.Tasks;

    public interface IDeviceGrain
    {
        Task SetColor(string colorName);
    }
}