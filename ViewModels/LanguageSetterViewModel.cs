using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DevExpress.Mvvm;

namespace Caliber.ViewModels
{
    public class LanguageSetterViewModel : BindableBase, ISingleton
    {
        public string Language { get; set; }
        public string[] LanguageSetter { get; } = { "rus", "eng" };
    }
}
