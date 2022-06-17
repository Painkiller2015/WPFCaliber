using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DevExpress.Mvvm;

namespace Caliber.ViewModels
{
    public class ResoursesLimitViewModel : BindableBase, ISingleton
    {
        public string ResoursesLimit { get; set; }
        public ICommand ChangeModeCommand
        {
            get => new DelegateCommand<string>((string newMode) =>
            {
                MainViewModel? mainView = VMLoader.Resolve<MainViewModel>();
            }); 
        }
    }
}
