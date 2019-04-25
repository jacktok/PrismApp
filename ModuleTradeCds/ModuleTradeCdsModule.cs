using ModuleTradeCds.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace ModuleTradeCds
{
    public class ModuleTradeCdsModule : IModule
    {
        #region Implementation of IModule

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<TradeCdsMain>();
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        #endregion
    }
}