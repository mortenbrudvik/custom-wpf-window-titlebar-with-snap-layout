using System.Windows;

namespace WindowWithSnapLayout;

public class WindowStateManager
{
    private readonly Window _window;

    public WindowStateManager(Window window) => _window = window;

    public void Close() => _window.Close();

    public void MaximizeRestore() => 
        _window.WindowState = _window.WindowState == WindowState.Maximized 
            ? WindowState.Normal 
            : WindowState.Maximized;

    public void Minimize() => _window.WindowState = WindowState.Minimized;
}