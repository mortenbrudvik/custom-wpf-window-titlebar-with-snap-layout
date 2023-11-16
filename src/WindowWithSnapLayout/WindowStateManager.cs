using System.Windows;

namespace WindowWithSnapLayout;

public class WindowStateManager
{
    private readonly MainWindow _window;

    public WindowStateManager(MainWindow window)
    {
        _window = window;
        _window.StateChanged += (_, _) => RefreshMaximizeRestoreButton();
        
        RefreshMaximizeRestoreButton();
    }

    public void Close() => _window.Close();

    public void Minimize() => _window.WindowState = WindowState.Minimized;

    public void MaximizeRestore() => 
        _window.WindowState = _window.WindowState == WindowState.Maximized 
            ? WindowState.Normal 
            : WindowState.Maximized;

    private void RefreshMaximizeRestoreButton()
    {
        if (_window.WindowState == WindowState.Maximized)
        {
            _window.MaximizeButton.Visibility = Visibility.Collapsed;
            _window.RestoreButton.Visibility = Visibility.Visible;
        }
        else
        {
            _window.MaximizeButton.Visibility = Visibility.Visible;
            _window.RestoreButton.Visibility = Visibility.Collapsed;
        }
    }
}