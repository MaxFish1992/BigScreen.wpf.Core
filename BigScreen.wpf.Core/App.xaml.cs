using BigScreen.wpf.ModuleLeft;
using BigScreen.wpf.ModuleMiddle;
using BigScreen.wpf.ModuleRight;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using System.Windows;

namespace BigScreen.wpf.Core
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            var moduleLeftType = typeof(ModuleLeftMng);
            var moduleMiddleType = typeof(ModuleMiddleMng);
            var moduleRightType = typeof(ModuleRightMng);
            //moduleCatalog.AddModule(
            //    new ModuleInfo()
            //    {
            //        ModuleName = moduleLeftType.Name,
            //        ModuleType = moduleLeftType.AssemblyQualifiedName,
            //        InitializationMode = InitializationMode.OnDemand
            //    }
            //    );
            moduleCatalog.AddGroup(InitializationMode.OnDemand, "", new ModuleInfo[]
            {
                new ModuleInfo(){
                    ModuleName = moduleLeftType.Name,
                    ModuleType = moduleLeftType.AssemblyQualifiedName,
                    InitializationMode = InitializationMode.OnDemand
                },
                new ModuleInfo(){
                    ModuleName = moduleMiddleType.Name,
                    ModuleType = moduleMiddleType.AssemblyQualifiedName,
                    InitializationMode = InitializationMode.OnDemand
                },
                new ModuleInfo(){
                    ModuleName = moduleRightType.Name,
                    ModuleType = moduleRightType.AssemblyQualifiedName,
                    InitializationMode = InitializationMode.OnDemand
                }
            });
        }
    }
}
