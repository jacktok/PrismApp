using System;
using System.ComponentModel;
using Prism.Events;
using PrismApp.Core.MessageEvent;
using PrismApp.Core.ServiceCollection;
using PrismAppResearch.Core.Enums;

namespace PrismApp.Core
{
    public interface IService
    {
        ServiceStatusEnum GetServiceStatus();

        string Login(string user, string password);

        void Logout();

        void PubMessage(string msg);

        TradeBmpService TradeBmpService { get; }

        event Action<string> Xaq;
    }


    public class Service : IService
    {
        private readonly IEventAggregator _eventAggregator;

        #region Implementation of IService

        public Service(IEventAggregator eventAggregator)
        {
            this._eventAggregator = eventAggregator;
            TradeBmpService = new TradeBmpService();
        }

        public ServiceStatusEnum GetServiceStatus() => _serviceStatus;

        public string Login(string user, string password)
        {
            _serviceStatus = ServiceStatusEnum.Connected;

            if (user == "aaa")
            {
                return null;
            }

            _serviceStatus = ServiceStatusEnum.Disconnect;
            return "error message";
        }

        public void Logout()
        {
        }

        public void PubMessage(string msg)
        {
            _eventAggregator.GetEvent<ServiceMessage>().Publish(msg);
        }

        public TradeBmpService TradeBmpService { get; private set; }
        public event Action<string> Xaq;


        public event EventHandler<string> MessageChange;

        #endregion

        private ServiceStatusEnum _serviceStatus = ServiceStatusEnum.Disconnect;

        protected virtual void OnMessageChange(string e)
        {
            Xaq?.Invoke(e);
        }
    }
}