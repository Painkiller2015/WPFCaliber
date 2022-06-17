using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DevExpress.Mvvm;

namespace Caliber.ViewModels
{
    internal class TakenResoursesViewModel : BindableBase, ISingleton
    {
        public string[] TakenResourses { get; set; } 
        public ICommand ChangeModeCommand
        {
            get => new DelegateCommand<string>((string newMode) =>
            {
                MainViewModel? mainView = VMLoader.Resolve<MainViewModel>();
            });
        }
        public TakenResoursesViewModel()
        {
            TakenResoursesModel.TakenResoursesChanged += TakenResoursesModel_TakenResoursesChanged;
        }
        private void TakenResoursesModel_TakenResoursesChanged(object? sender, string[] e)
        {
            TakenResourses = e;
        }
    }
}
