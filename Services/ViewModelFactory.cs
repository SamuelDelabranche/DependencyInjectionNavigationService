using DependencyInjectionNavigationService.Core;
using DependencyInjectionNavigationService.MVVM.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionNavigationService.Services
{
    public interface IViewModelFactory
    {
        ViewModelBase CreateViewModel(Type viewModelType);
    }

    public class ViewModelFactory : IViewModelFactory
    {
        private readonly IServiceProvider _serviceProvider;
        public ViewModelFactory(IServiceProvider serviceProvider) => _serviceProvider = serviceProvider;
        public ViewModelBase CreateViewModel(Type viewModelType) => (ViewModelBase)_serviceProvider.GetRequiredService(viewModelType);
    }
}
