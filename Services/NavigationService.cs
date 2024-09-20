using DependencyInjectionNavigationService.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionNavigationService.Services
{

    public interface INavigationService
    {
        public ViewModelBase CurrentView { get; }
        void NavigateTo<TViewModel>() where TViewModel : ViewModelBase;
    }

    public class NavigationService : ObservableItem, INavigationService
    {
        private ViewModelBase _currentView;
        private readonly IViewModelFactory _viewModelFactory;

        public ViewModelBase CurrentView
        {
            get
            {
                return _currentView;
            }
            set
            {
                _currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }

        public NavigationService(IViewModelFactory viewModelFactory)
        {
            _viewModelFactory = viewModelFactory;
        }

        public void NavigateTo<TViewModel>() where TViewModel : ViewModelBase
        {
            CurrentView = _viewModelFactory.CreateViewModel(typeof(TViewModel));
        }
    }

}