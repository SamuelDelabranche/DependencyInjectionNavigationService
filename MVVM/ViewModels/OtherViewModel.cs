using DependencyInjectionNavigationService.Core;
using DependencyInjectionNavigationService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionNavigationService.MVVM.ViewModels
{
    public class OtherViewModel : NavigationViewModelBase
    {
        public RelayCommand NavigateToHome { get; }
        public OtherViewModel(INavigationService navigationService) : base(navigationService)
        {
            NavigateToHome = new RelayCommand(execute => _navigationService.NavigateTo<HomeViewModel>(), canExecute => true);
        }
    }
}
