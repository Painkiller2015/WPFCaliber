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
    public class ModeViewModel : BindableBase, ISingleton
    {
        public static event EventHandler<PriorityMode> ModeChanged;

        #region Properties

        public bool AutoMode { get; set; }
        public bool HandMode { get; set; }
        public bool TehnologiesMode { get; set; }
        public bool MaxMode { get; set; }

        #endregion

        public ICommand ChangeModeCommand
        {
            get => new DelegateCommand(() =>
            {
                PriorityMode newMode = new();

                if (AutoMode)
                     newMode = PriorityMode.Auto;
                else if (HandMode)
                    newMode = PriorityMode.Hand;
                else if (TehnologiesMode)
                    newMode = PriorityMode.Tehnologies;
                else if (MaxMode)
                    newMode = PriorityMode.Max;

                ModeChanged?.Invoke(this, newMode);
            });
        }
    }
}
