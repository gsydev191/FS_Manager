using Catel.IoC;
using Catel.Logging;
using Catel.Reflection;
using Catel.Windows;
using System.Windows;

namespace FS_Manager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static readonly ILog Log = LogManager.GetCurrentClassLogger();

        protected override void OnStartup(StartupEventArgs e)
        {
#if DEBUG
            LogManager.AddDebugListener();
#endif
            Log.Info("Starting application");
            
#if PERF
            Log.Info("Improving performance");
            Catel.Windows.Controls.UserControl.DefaultCreateWarningAndErrorValidatorForViewModelValue = false;
            Catel.Windows.Controls.Usercontrol.DefaultSkipSearchingForInfoBarMessageControlValue = true;
            
            Log.Info("Registering custom types");
            var serviceLocator = ServiceLocator.Default;
            serviceLocator.RegisterType<IMyInterface, IMyClass>();
            
            StyleHelper.CreateStyleForwardersForDefaultStyles();
            
#endif
            
            
            Log.Info("Calling base.OnStartup");
            
            base.OnStartup(e);
            
            
            
        }


    }
}