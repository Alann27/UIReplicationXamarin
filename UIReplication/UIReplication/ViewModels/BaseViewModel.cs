using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace UIReplication.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        protected BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public INavigationService NavigationService { get; }

    }
}
