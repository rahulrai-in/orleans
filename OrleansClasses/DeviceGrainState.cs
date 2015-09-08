namespace OrleansClasses
{
    #region

    using Orleans;

    #endregion

    public class DeviceGrainState : GrainState
    {
        #region Public Properties

        public string Aggregator { get; set; }

        public string Color { get; set; }

        #endregion
    }
}