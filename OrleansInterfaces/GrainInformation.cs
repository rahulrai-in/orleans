namespace OrleansInterfaces
{
    #region

    using System;

    using Orleans.Concurrency;

    #endregion

    /// <summary>
    ///     Grain information. Since we won't modify it, we are making it immutable.
    /// </summary>
    [Immutable]
    public class GrainInformation
    {
        #region Public Properties

        public string DeviceId { get; set; }

        public DateTime Time { get; set; }

        public string Value { get; set; }

        #endregion
    }
}