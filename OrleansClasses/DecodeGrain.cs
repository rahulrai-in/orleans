namespace OrleansClasses
{
    #region

    using System.Threading.Tasks;

    using Orleans;
    using Orleans.Concurrency;

    using OrleansInterfaces;

    #endregion

    [StatelessWorker]
    [Reentrant]
    public class DecodeGrain : Grain, IDecodeGrain
    {
        #region Public Methods and Operators

        public Task DecodeDeviceMessage(string ipAndColorMessage)
        {
            var parts = ipAndColorMessage.Split(',');
            //// The following will create a new grain for device or invoke an existing grain for same device.
            var grain = this.GrainFactory.GetGrain<IDeviceGrain>(parts[0]);
            //// No we'll pass color to the grain.
            return grain.SetColor(parts[1]);
        }

        #endregion
    }
}