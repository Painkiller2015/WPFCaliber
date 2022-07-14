using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DevExpress.Mvvm;
using WPFCaliber;
using WPFCaliber.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Caliber.ViewModels
{
    public class ActuallyPriorityViewModel : BindableBase, ISingleton
    {
        public ObservableCollection<ResoursesCollectionEng> ObsResourseCollection { get; private set; }
        public Dictionary<ResoursesCollectionEng, Resourse> ResourseCollection { get => Resourse.DictNumResources; }
        public static event EventHandler<ObservableCollection<ResoursesCollectionEng>> PriorityChanged;
        public ResoursesCollectionEng SelectedResourse { get; set; }
        private static readonly int _maxPriority = 0;
        private static readonly int _minPriority = 9;

        public ActuallyPriorityViewModel()
        {
            UpdateCollection(true);
        }
        public void UpdateCollection(bool init = false)
        {
            var orderedDictionary = Resourse.DictNumResources.OrderBy(el => el.Value.Priority).ToDictionary(el => el.Key);
            ObsResourseCollection = new(orderedDictionary.Keys.ToList());

            if (!init)
                PriorityChanged.Invoke(this, ObsResourseCollection);
        }
        public ICommand UpPriorityCommand
        {
            get => new DelegateCommand(() =>
            {
                SetUpPriority();
                UpdateCollection();
            });
        }
        public ICommand DownPriorityCommand
        {
            get => new DelegateCommand(() =>
            {
                SetDownPriority();
                UpdateCollection();
            });
        }
        private void SetUpPriority()
        {
            int newPriority = ResourseCollection[SelectedResourse].Priority - 1;

            if (newPriority < _maxPriority || newPriority > _minPriority)
                return;

            var a = ResourseCollection.FirstOrDefault(el => el.Value.Priority == newPriority);

            ResourseCollection[a.Key].Priority += 1;
            ResourseCollection[SelectedResourse].Priority -= 1;
        }
        private void SetDownPriority()
        {
            int newPriority = ResourseCollection[SelectedResourse].Priority + 1;

            if (newPriority < _maxPriority || newPriority > _minPriority)
                return;

            var a = ResourseCollection.FirstOrDefault(el => el.Value.Priority == newPriority);

            ResourseCollection[a.Key].Priority -= 1;
            ResourseCollection[SelectedResourse].Priority += 1;
        }
    }
}
