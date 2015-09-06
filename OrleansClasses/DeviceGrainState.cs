using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrleansClasses
{
    using Orleans;

    public class DeviceGrainState : GrainState
    {
        public string Color { get; set; }
        public string Aggregator { get; set; }
    }
}
