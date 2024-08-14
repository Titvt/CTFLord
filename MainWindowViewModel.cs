using CommunityToolkit.Mvvm.ComponentModel;

namespace CTFLord;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty] private bool _maximized;
}