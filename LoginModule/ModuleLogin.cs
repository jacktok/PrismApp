using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace LoginModule
{
    public class ModuleLogin: IModule
    {
        #region Implementation of IModule

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Login>();
        }


        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            var region = regionManager.Regions["Content"];
            region.Add(containerProvider.Resolve<Login>(), "log in");
        }

        #endregion
    }
}
