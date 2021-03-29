using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using UIReplication.ViewModels;
using UIReplication.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UIReplication
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer = null) : base(platformInitializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync($"{NavigationConstants.NavigationPage}/{NavigationConstants.HomePage}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>(NavigationConstants.NavigationPage);
            containerRegistry.RegisterForNavigation<HomePage,HomeViewModel>(NavigationConstants.HomePage);
            containerRegistry.RegisterForNavigation<DetailPage, DetailViewModel>(NavigationConstants.DetailPage);
        }
    }
}
