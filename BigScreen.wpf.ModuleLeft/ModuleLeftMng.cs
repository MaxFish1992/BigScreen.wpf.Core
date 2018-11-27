using BigScreen.wpf.ModuleLeft.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;

namespace BigScreen.wpf.ModuleLeft
{
    public class ModuleLeftMng : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentLeftRegion", typeof(ViewLeft));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}
