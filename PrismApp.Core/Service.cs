using System;
using System.ComponentModel;
using Prism.Events;
using PrismApp.Core.ServiceCollection;
using PrismAppResearch.Core.Enums;

namespace PrismApp.Core
{
    public interface  IService
    {
        ServiceStatusEnum GetServiceStatus();

        string Login(string user, string password);

        void Logout();

        TradeBmpService TradeBmpService { get; }

    }


    public class Service: IService
    {
        #region Implementation of IService

        public Service()
        {
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

        public TradeBmpService TradeBmpService { get; private set; }

        #endregion

        private ServiceStatusEnum _serviceStatus = ServiceStatusEnum.Disconnect;
    }

}
