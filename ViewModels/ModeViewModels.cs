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
    internal class ModeViewModels : BindableBase, ISingleton
    {
        public static event EventHandler<PriorityMode> ModeChanged;

        #region Properties

        public bool MedianMode { get; set; }
        public bool HandMode { get; set; }
        public bool TehnologiesMode { get; set; }
        public bool MaxMode { get; set; }

        #endregion

        public ICommand ChangeModeCommand
        {
            get => new DelegateCommand<PriorityMode>((PriorityMode newMode) =>
            {
                MainViewModel? mainView = VMLoader.Resolve<MainViewModel>();
                mainView.Started = true;
                mainView.NotStarted = false;

                if (MedianMode)
                    newMode = PriorityMode.Hand;
                else if (HandMode)
                    newMode = PriorityMode.Max;
                else if (TehnologiesMode)
                    newMode = PriorityMode.Median;
                else if (MaxMode)
                    newMode = PriorityMode.Tehnologies;

                ModeChanged?.Invoke(this, newMode);
            });
        }
    }
}
