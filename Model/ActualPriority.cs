using Caliber;
using Caliber.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WPFCaliber.Value;

namespace WPFCaliber.Model
{
    public class ActualPriority : Priority
    {
        public static void SetPriority(PriorityMode mode)
        {
            switch (mode)
            {
                case PriorityMode.Hand: HandPriority.SetPriority(); break;
                case PriorityMode.Max: MaxPriority.SetPriority(); break;
                case PriorityMode.Auto: AutoPriority.SetPriority(); break;
                case PriorityMode.Tehnologies: TehnologiesPriority.SetPriority(); break;
            }
            UpdateData();
        }
    }
}
