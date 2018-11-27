using BigScreen.wpf.ModuleRight.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;

namespace BigScreen.wpf.ModuleRight
{
    public class ModuleRightMng : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentRightRegion", typeof(ViewRight));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
