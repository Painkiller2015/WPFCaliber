using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPFCaliber;

namespace Caliber.ViewModels
{
    public class ModeDescriptionViewModel : BindableBase, ISingleton
    {
        public ModeDescriptionViewModel()
        {
            ModeViewModel.ModeChanged += (object _, PriorityMode s) =>
            {
                UpdateDescription(s);
                RaisePropertyChanged(nameof(ModeDescription));
            };
        }
        public string ModeDescription { get; private set; }

        public ICommand ChangeModeCommand
        {
            get => new DelegateCommand<PriorityMode>((PriorityMode newMode) =>
            {
                UpdateDescription(newMode);
            });
        }
        private void UpdateDescription(PriorityMode newMode)
        {
            MainViewModel? mainView = VMLoader.Resolve<MainViewModel>();

            mainView.Started = true;
            mainView.NotStarted = false;

            switch (newMode)
            {
                case PriorityMode.Hand:
                    ModeDescription = "Cобирает ресурсы с заданным приоритетом";
                    break;
                case PriorityMode.Max:
                    ModeDescription = "Собирает ресурсы на прокачку ВСЕГО";
                    break;
                case PriorityMode.Median:
                    ModeDescription = "Cобирает ресурсы до одного уровня";
                    break;
                case PriorityMode.Tehnologies:
                    ModeDescription = "Собирает недостающие для навыков ресурсы ";
                    break;
            }
        }
    }
}
