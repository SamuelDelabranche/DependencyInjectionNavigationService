using DependencyInjectionNavigationService.Core;
using DependencyInjectionNavigationService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionNavigationService.MVVM.ViewModels
{
    public class HomeViewModel : NavigationViewModelBase
    {
        public RelayCommand NavigateToOther { get; }
        public HomeViewModel(INavigationService navigationService) : base(navigationService)
        {
            NavigateToOther = new RelayCommand(execute => navigationService.NavigateTo<OtherViewModel>(), canExecute => true);
        }
    }
}
