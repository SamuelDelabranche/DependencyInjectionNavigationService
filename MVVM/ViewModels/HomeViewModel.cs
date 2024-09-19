using DependencyInjectionNavigationService.Core;
using DependencyInjectionNavigationService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionNavigationService.MVVM.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public static int constructeurNumber { get; set; } = 0;
        
        private readonly INavigationService _navigationService;

        public RelayCommand NavigateToOther { get; }
        public HomeViewModel(INavigationService navigationService)
        {
            constructeurNumber++;
            _navigationService = navigationService;
            NavigateToOther = new RelayCommand(execute => navigationService.NavigateTo<OtherViewModel>(), canExecute => true);
        }
    }
}
