using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using WPFCaliber.Value;

namespace Caliber
{
    public class PriceQuartesTehologies
    {
        public List<ResourseValue>? Physical { get; }
        public List<ResourseValue>? Protective { get; }
        public List<ResourseValue>? Ammunition { get; }
        public List<ResourseValue>? Tactical { get; }
    }
}
