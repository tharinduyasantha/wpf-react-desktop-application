namespace WPFCompact.ViewModels.Pages
{
    public partial class DashboardViewModel : ObservableObject
    {
        [ObservableProperty]
        private int _counter = 0;

        [ObservableProperty]
        private string _reactMessage = "Default WPF message";

        [RelayCommand]
        public void OnCounterIncrement()
        {
            Counter++;
        }
    }
}
