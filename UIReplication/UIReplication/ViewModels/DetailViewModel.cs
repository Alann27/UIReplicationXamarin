using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using UIReplication.Models;
using Xamarin.Forms;

namespace UIReplication.ViewModels
{
    public class DetailViewModel : BaseViewModel, IInitialize
    {
        public string BackImage { get; } = "back.png";
        public string SendImage { get; } = "send.pnd";
        public string AddToCalendarImage { get; } = "addCalendar.png";
        public string HeartImage { get; } = "heart.png";
        public NewMusicItem MusicItem { get; set; }
        public ICommand BackCommand { get; set; }
        public DetailViewModel(INavigationService navigationService) : base(navigationService)
        {
            BackCommand = new Command(OnBack);
        }

        public async void OnBack()
        {
            await NavigationService.GoBackAsync(null);
        }

        public void Initialize(INavigationParameters parameters)
        {
            if (parameters.TryGetValue(ParametersConstants.MusicItem,out NewMusicItem musicItem))
            {
                MusicItem = musicItem;
            }
        }
    }
}
