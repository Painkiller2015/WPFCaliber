using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DevExpress.Mvvm;

namespace Caliber.ViewModels
{
    internal class LanguageSetterViewModel : BindableBase, ISingleton
    {
        public string Language { get; set; }
        public string[] LanguageSetter { get; } = { "rus", "eng" };
        public ICommand ChangeModeCommand
        {
            get => new DelegateCommand<string>((string newMode) =>
            {
                ViewModels.MainViewModel? mainView = VMLoader.Resolve<ViewModels.MainViewModel>();
                Language = newMode;
            });
        }
    }
}
