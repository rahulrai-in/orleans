namespace OrleansClasses
{
    #region

    using System;
    using System.Collections.Generic;

    using Orleans;

    using OrleansInterfaces;

    #endregion

    public class AggregatorGrainState : GrainState
    {
        #region Public Properties

        public DateTime ExpiryTime { get; set; }

        public List<GrainInformation> GrainInformation { get; set; }

        #endregion
    }
}