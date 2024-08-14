using Avalonia;
using Avalonia.Controls;

namespace CTFLord;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
    {
        if (DataContext is MainWindowViewModel dataContext)
        {
            if (change.Property == WindowStateProperty)
            {
                dataContext.Maximized = change.NewValue as WindowState? == WindowState.Maximized;
            }
        }

        base.OnPropertyChanged(change);
    }
}