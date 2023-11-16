using CommunityToolkit.Mvvm.Input;

namespace WindowWithSnapLayout;

public partial class MainWindow
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;
        var stateManager = new WindowStateManager(this);
        
        RefreshCommand = new RelayCommand(() => { });
        MinimizeCommand = new RelayCommand(() => stateManager.Minimize());
        MaximizeRestoreCommand = new RelayCommand(() => stateManager.MaximizeRestore());
        CloseCommand = new RelayCommand(() => stateManager.Close());
    }
    public RelayCommand RefreshCommand { get; set; }
    public RelayCommand MinimizeCommand { get; set; }
    public RelayCommand MaximizeRestoreCommand { get; set; }
    public RelayCommand CloseCommand { get; set; }
}