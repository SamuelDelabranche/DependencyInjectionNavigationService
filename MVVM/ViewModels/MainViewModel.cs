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
    public class MainViewModel : ViewModelBase
    {
		private INavigationService _navigation;
		public INavigationService Navigation
		{
			get => _navigation;
			set
			{
				_navigation = value;
				OnPropertyChanged();
			}
		}

        public RelayCommand NavigationToOther { get; }
        public RelayCommand NavigationToHome { get; }

        public MainViewModel(INavigationService navigationService)
        {
            _navigation = navigationService;

			_navigation.NavigateTo<DefaultViewModel>();
			NavigationToOther = new RelayCommand(canExecute => _navigation.NavigateTo<OtherViewModel>());
            NavigationToHome = new RelayCommand(canExecute => _navigation.NavigateTo<HomeViewModel>());

			Debug.WriteLine(_navigation != null ? "Initialized!" : "NULLLL");
        }
    }
}
