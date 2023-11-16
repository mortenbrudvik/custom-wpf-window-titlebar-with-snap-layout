using System.Windows;

namespace WindowWithSnapLayout;

public class WindowState
{
    private readonly Window _window;

    public WindowState(Window window) => _window = window;

    public void Close() => _window.Close();

    public void MaximizeRestore() => 
        _window.WindowState = _window.WindowState == System.Windows.WindowState.Maximized 
            ? System.Windows.WindowState.Normal 
            : System.Windows.WindowState.Maximized;

    public void Minimize() => _window.WindowState = System.Windows.WindowState.Minimized;
}