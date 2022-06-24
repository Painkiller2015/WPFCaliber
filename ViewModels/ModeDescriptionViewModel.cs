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
            ModeDescription = newMode switch
            {
                PriorityMode.Hand => ModeDescription = "Cобирает ресурсы с заданным приоритетом",
                PriorityMode.Max => ModeDescription = "Собирает ресурсы на прокачку ВСЕГО",
                PriorityMode.Auto => ModeDescription = "Cобирает ресурсы до одного уровня",
                PriorityMode.Tehnologies => ModeDescription = "Собирает недостающие для навыков ресурсы ",
            };
        }
    }
}
