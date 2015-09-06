using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrleansInterfaces
{
    using Orleans.Concurrency;

    /// <summary>
    /// Grain information. Since we won't modify it, we are making it immutable.
    /// </summary>
    [Immutable]
    public class GrainInformation
    {
        public string DeviceId { get; set; }

        public DateTime Time { get; set; }

        public string Value { get; set; }
    }
}
