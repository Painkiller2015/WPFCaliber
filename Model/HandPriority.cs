using Caliber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliber.ViewModels;
using WPFCaliber.Value;

namespace WPFCaliber.Model
{
    public class HandPriority : Priority
    {
        public static async Task SetPriority()
        {
            SetDesiredNumber();
            OrderPriority();
            UpdateData();
        }
    }
}
