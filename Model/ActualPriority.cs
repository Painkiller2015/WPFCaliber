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
        public static async void SetPriority(PriorityMode mode)
        {
            switch (mode)
            {
                case PriorityMode.Hand: await HandPriority.SetPriority(); break;
                case PriorityMode.Max: await MaxPriority.SetPriority(); break;
                case PriorityMode.Auto: await AutoPriority.SetPriority(); break;
                case PriorityMode.Tehnologies: await TehnologiesPriority.SetPriority(); break;
            }
            UpdateData();

        }
    }
}
