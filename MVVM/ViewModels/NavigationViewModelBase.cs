using DependencyInjectionNavigationService.Core;
using DependencyInjectionNavigationService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionNavigationService.MVVM.ViewModels
{
    public class NavigationViewModelBase : ViewModelBase
    {
        protected readonly INavigationService _navigationService;
        public NavigationViewModelBase(INavigationService navigationService) { _navigationService = navigationService; }
    }
}
