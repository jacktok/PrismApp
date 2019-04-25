using ModuleTradeNgu.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace ModuleTradeNgu
{
    public class ModuleTradeNguModule: IModule
    {
        #region Implementation of IModule

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<TradeNguMain>();
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        #endregion
    }
}