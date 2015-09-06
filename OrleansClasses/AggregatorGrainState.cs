using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrleansClasses
{
    using Orleans;

    using OrleansInterfaces;

    public class AggregatorGrainState : GrainState
    {
        public DateTime ExpiryTime { get; set; }
        public List<GrainInformation> GrainInformation { get; set; }
    }
}
