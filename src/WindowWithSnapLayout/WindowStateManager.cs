using static System.Windows.WindowState;
using static System.Windows.Visibility;

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

    private bool IsMaximized => _window.WindowState == Maximized;

    public void Close() => _window.Close();

    public void Minimize() => _window.WindowState = Minimized;

    public void MaximizeRestore() => _window.WindowState = IsMaximized ? Normal : Maximized;
    
    private void RefreshMaximizeRestoreButton()
    {
        _window.MaximizeButton.Visibility = IsMaximized ? Collapsed : Visible;
        _window.RestoreButton.Visibility = IsMaximized ? Visible : Collapsed;
    }
}