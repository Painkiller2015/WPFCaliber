using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WPFCaliber.Value;

namespace Caliber
{
    public static class TechnologyLines
    {
        public static JsonLogObject.Technologyline[] TechLines { get; set; }
        static TechnologyLines()
        {
            TechLines = GetLogObject.GetTechLines();
        }
    }
}
