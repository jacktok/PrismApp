using System.Collections.ObjectModel;
using System.ComponentModel;
using Prism.Commands;
using Prism.Mvvm;
using PrismApp.Core;
using PrismApp.Core.Models;

namespace LoginModule.ViewModels
{
    public class LoginViewModel : BindableBase
    {
        public LoginViewModel(IService server)
        {
            TradeList = new ObservableCollection<TradeBmp>(server.TradeBmpService.GetTrade());
            LoginCommand = new DelegateCommand(LoginExec);
        }

        private void LoginExec()
        {
            DialogResult = true;
        }

        private bool? _dialogResult;

        public bool? DialogResult
        {
            get => _dialogResult;
            set => SetProperty(ref _dialogResult, value);
        }

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private string _userId;
        private string _title;
        private ObservableCollection<TradeBmp> _tradeList;

        public string UserId
        {
            get => _userId;
            set => SetProperty(ref _userId,value);
        }

        public ObservableCollection<TradeBmp> TradeList
        {
            get => _tradeList;
            set => SetProperty(ref _tradeList, value);
        }


        public DelegateCommand LoginCommand { get;}

    }
}