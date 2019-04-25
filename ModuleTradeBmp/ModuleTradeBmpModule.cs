using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuleTradeBmp.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace ModuleTradeBmp
{
    public class ModuleTradeBmpModule : IModule
    {
        #region Implementation of IModule

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<TradeBmpMain>();
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        #endregion
    }
}