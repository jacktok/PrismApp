using System.Windows;
using LoginModule.Views;
using Prism.Modularity;
using Prism.Unity;
using PrismApp.Core;
using PrismApp.Core.Models;
using PrismApp.Views;
using Unity;

namespace PrismApp
{
    public class Bootstrapper : UnityBootstrapper
    {
        #region Overrides of Bootstrapper


        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            ModuleCatalog.AddModule<ModuleTradeBmp.ModuleTradeBmpModule>();
            ModuleCatalog.AddModule<ModuleTradeNgu.ModuleTradeNguModule>();
            ModuleCatalog.AddModule<ModuleTradeCds.ModuleTradeCdsModule>();
        }


        protected override IUnityContainer CreateContainer()
        {
            var container = base.CreateContainer();

            container.RegisterSingleton<IService, Service>();
            return container;
        }

        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            Window login = Container.Resolve<Login>();
            login.Closed += (sender, args) =>
            {
                // do something
               if (login.DialogResult ?? false) Application.Current.MainWindow.Show();
               else
               {
                   Application.Current.MainWindow.Close();
               }
            };
            login.ShowDialog();
        }

        #endregion
    }
}