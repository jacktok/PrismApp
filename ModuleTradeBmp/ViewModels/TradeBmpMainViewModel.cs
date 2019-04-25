using System.Collections.ObjectModel;
using Prism.Events;
using Prism.Mvvm;
using PrismApp.Core;
using PrismApp.Core.MessageEvent;

namespace ModuleTradeBmp.ViewModels
{
    public class TradeBmpMainViewModel: BindableBase
    {
        private IService _service;
        private IEventAggregator _eventAggregator;
        public TradeBmpMainViewModel(IEventAggregator eventAggregator, IService service)
        {
            this._eventAggregator = eventAggregator;
            this._service = service;
            this._service.Xaq += _service_Xaq;
            ItemsCollection = new ObservableCollection<string>();
            eventAggregator.GetEvent<ServiceMessage>().Subscribe(ReceiveServiceMessageExec);
        }

        private void _service_Xaq(string obj)
        {
            ItemsCollection.Add(obj);
        }

        private ObservableCollection<string> _itemsCollection;

        public ObservableCollection<string> ItemsCollection
        {
            get => _itemsCollection;
            set => SetProperty(ref _itemsCollection, value);
        }

        private void ReceiveServiceMessageExec(string obj)
        {
            ItemsCollection.Add(obj);
        }
    }
}