using Prism.Modularity;
using System.Windows;

namespace BigScreen.wpf.Core
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        IModuleManager _moduleManager;
        public MainWindow(IModuleManager moduleManager)
        {
            InitializeComponent();
            _moduleManager = moduleManager;
            if (_moduleManager != null)
            {
                _moduleManager.LoadModule("ModulesManagerEx");
            }
        }
    }
}
