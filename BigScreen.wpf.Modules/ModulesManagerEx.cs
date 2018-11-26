using BigScreen.wpf.Modules.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigScreen.wpf.Modules
{
    public class ModulesManagerEx : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentLeftRegion", typeof(ViewLeft));
            regionManager.RegisterViewWithRegion("ContentMiddleRegion", typeof(ViewMiddle));
            regionManager.RegisterViewWithRegion("ContentRightRegion", typeof(ViewRight));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}
