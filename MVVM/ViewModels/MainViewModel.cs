using DependencyInjectionNavigationService.Core;
using DependencyInjectionNavigationService.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionNavigationService.MVVM.ViewModels
{
    public class MainViewModel : NavigationViewModelBase
    {
		public INavigationService Navigation { get => _navigationService; }
        
        public RelayCommand NavigationToOther { get; }
        public RelayCommand NavigationToHome { get; }

        public MainViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService.NavigateTo<DefaultViewModel>();
			NavigationToOther = new RelayCommand(canExecute => _navigationService.NavigateTo<OtherViewModel>());
            NavigationToHome = new RelayCommand(canExecute => _navigationService.NavigateTo<HomeViewModel>());

        }
    }
}
