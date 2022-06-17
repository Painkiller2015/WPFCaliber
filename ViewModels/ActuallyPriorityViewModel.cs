using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DevExpress.Mvvm;
using WPFCaliber;

namespace Caliber.ViewModels
{
    public class ActuallyPriorityViewModel : BindableBase, ISingleton
    {
        public List<Resourse> ActuallyPriority { get; set; }
        public ActuallyPriorityViewModel()
        {
            ActuallyPriority = new List<Resourse>();

            ModeViewModels.ModeChanged += (object? _, PriorityMode s) =>
            {
                GetPriority(s);
            };

        }
        public List<Resourse> GetPriority(PriorityMode s)
        {
            ActualPriority actual = new(s);
            return ActuallyPriority = actual.Priority;
        }
    }
}
