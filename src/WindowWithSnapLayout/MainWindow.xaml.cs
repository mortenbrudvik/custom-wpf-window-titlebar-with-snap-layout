using CommunityToolkit.Mvvm.Input;

namespace WindowWithSnapLayout;

public partial class MainWindow
{
    public MainWindow()
    {
        InitializeComponent();
        
        DataContext = this;
        
         var state = new WindowStateManager(this);
        
         RefreshCommand = new RelayCommand(() => { });
         MinimizeCommand = new RelayCommand(() => state.Minimize());
         MaximizeRestoreCommand = new RelayCommand(() => state.MaximizeRestore());
         CloseCommand = new RelayCommand(() => state.Close());
    }
    public RelayCommand RefreshCommand { get; set; }
    public RelayCommand MinimizeCommand { get; set; }
    public RelayCommand MaximizeRestoreCommand { get; set; }
    public RelayCommand CloseCommand { get; set; }
}