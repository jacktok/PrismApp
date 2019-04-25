using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Regions;
using PrismApp.Core;
using PrismApp.Core.MessageEvent;

namespace PrismApp.ViewModels
{
    public class MainWindowViewModel: BindableBase
    {
        private readonly IService _service;
        private IRegionManager _regionManager;
        private readonly IEventAggregator _eventAggregator;
        public MainWindowViewModel(IService service, IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            _service = service;
            this._regionManager = regionManager;
            _eventAggregator = eventAggregator;
            NavigateCommand = new DelegateCommand<string>(Navigate);

            AddItemCommand = new DelegateCommand(AddItemExec);
        }

        private void Navigate(string navigatePath)
        {
            if (navigatePath != null) _regionManager.RequestNavigate("Content", navigatePath);
        }

        #region parameter

        private string _itemText;

        public string ItemText
        {
            get => _itemText;
            set => SetProperty(ref _itemText, value);
        }


        #endregion
        private void AddItemExec()
        {
            //if (ItemText != null) _eventAggregator.GetEvent<ServiceMessage>().Publish(ItemText);
            if (ItemText != null) _service.PubMessage(ItemText);
            ItemText = null;
        }

        public DelegateCommand AddItemCommand { get; private set; }
        public DelegateCommand<string> NavigateCommand { get; private set; }
    }
}