using DevExpress.Mvvm;

namespace Caliber.ViewModels
{
    internal class MainViewModel : BindableBase, ISingleton
    {
        public string? SelectedItemMyListView { get; set; }
        public bool Started { get; set; } = true;
        public bool NotStarted { get; set; } = false;
    }
}
