using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DevExpress.Mvvm;
using WPFCaliber;
using WPFCaliber.Model;

namespace Caliber.ViewModels
{
    public class ActuallyPriorityViewModel : BindableBase, ISingleton
    {
        public Dictionary<ResoursesCollectionEng, Resourse> ResourseCollection { get => Resourse.DictNumResources; } 
        public Resourse SelectedResourse { get; set; } 
        public ActuallyPriorityViewModel()
        {

            ModeViewModel.ModeChanged += (object? _, PriorityMode s) =>
            {
                // GetPriority(s);
            };

        }


        public ICommand UpPriority
        {
            get => new DelegateCommand(() =>
            {

            });
            
        }
        public ICommand DownPriority
        {
            get => new DelegateCommand(() =>
            {

            });
        }
    }
}
