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
            get => new DelegateCommand(async () =>
            {
                await Task.Run(async () =>
                     {
                         PriorityMode newMode = new();

                         if (AutoMode)
                         {
                             newMode = PriorityMode.Auto;
                             AutoMode = true;
                         }
                         else if (HandMode)
                         {
                             newMode = PriorityMode.Hand;
                             HandMode = true;
                         }
                         else if (TehnologiesMode)
                         {
                             newMode = PriorityMode.Tehnologies;
                             TehnologiesMode = true;
                         }
                         else if (MaxMode)
                         {
                             newMode = PriorityMode.Max;
                             MaxMode = true;
                         }
                         ModeChanged?.Invoke(this, newMode);
                     });
            });
        }
    }
}
