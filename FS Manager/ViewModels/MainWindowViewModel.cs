using Catel.MVVM;
using System.Threading.Tasks;

namespace FS_Manager.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel(){}

    public override string Title
    {
        get { return "FS Manager"; }
    }

    protected override async Task InitializeAsync()
    {
        await base.InitializeAsync();
    }

    protected override async Task CloseAsync()
    {
        await base.CloseAsync();
    }
}