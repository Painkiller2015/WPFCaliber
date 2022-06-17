using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Caliber;
using DevExpress.Mvvm;

namespace Caliber.ViewModels
{
    public class StartResoursesViewModel : BindableBase, ISingleton
    {
        public List<Resourse> Resourses { get; set; } = Resourse.DictNumResources.Values.ToList();
        public ICommand ChangeModeCommand
        {
            get => new DelegateCommand<string>((string newMode) =>
            {
                MainViewModel? mainView = VMLoader.Resolve<MainViewModel>();
            });
        }
    }
}
