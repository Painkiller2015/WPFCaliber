using DevExpress.Mvvm;

namespace Caliber.ViewModels
{
    public class MainViewModel : BindableBase, ISingleton
    {
        public string? SelectedItemMyListView { get; set; }
        public bool Started { get; set; } = true;
        public bool NotStarted { get; set; } = false;
    }
}
