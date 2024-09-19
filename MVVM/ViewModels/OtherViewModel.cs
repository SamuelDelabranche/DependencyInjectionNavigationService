using DependencyInjectionNavigationService.Core;
using DependencyInjectionNavigationService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionNavigationService.MVVM.ViewModels
{
    public class OtherViewModel : ViewModelBase
    {
        public static int constructeurNumber { get; set; } = 0; 

        private readonly INavigationService _navigationService;
        public RelayCommand NavigateToHome { get; }

        public OtherViewModel(INavigationService navigationService)
        {
            constructeurNumber++;
            _navigationService = navigationService;
            NavigateToHome = new RelayCommand(execute => _navigationService.NavigateTo<HomeViewModel>(), canExecute => true);
        }
    }
}
