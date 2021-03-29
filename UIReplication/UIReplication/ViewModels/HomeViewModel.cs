using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using UIReplication.Models;
using Xamarin.Forms;

namespace UIReplication.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public ObservableCollection<NewMusicItem> NewMusicItems { get; } = new ObservableCollection<NewMusicItem>();
        public string BreatheLabel { get; } = "Breathe";
        public string BreatheImage { get; } = "breathe.png";

        public string SleepLabel { get; } = "Sleep";
        public string SleepImage { get; } = "sleep.png";

        public string AnxietyLabel { get; } = "Anxiety";
        public string AnxietyImage { get; } = "anxiety.png";

        public string StressLabel { get; } = "Stress";
        public string StressImage { get; } = "strees.png";

        public string DailyMeditationsLabel { get; } = "Daily meditations";


        public string RelaxImage { get; } = "relax.jpg";
        public string RelaxTitle { get; } = "Rest & Relax";
        public string ClockImage { get; } = "clock.png";
        public string RelaxMins { get; } = "30 mins";

        public string NewMusicLabel { get; } = "New Music";
        public string ViewAllLabel { get; } = "View all";

        public string TodayTitle { get; } = "Today";
        public string TodayImage { get; } = "today.png";

        public string YogaTitle { get; } = "Yoga";
        public string YogaImage { get; } = "yoga.png";

        public string MeditationTitle { get; } = "Meditation";
        public string MeditationImage { get; } = "meditation.png";

        public string MealTitle { get; } = "Meal";
        public string MealImage { get; } = "meal.png";

        public string ProfileTitle { get; } = "Profile";
        public string ProfileImage { get; } = "profile.png";

        public ICommand SelectedMusicItemCommand { get; } 
        public HomeViewModel(INavigationService navigationService) : base(navigationService)
        {
            SelectedMusicItemCommand = new Command<NewMusicItem>(OnSelectedMusicItem);

            NewMusicItems = new ObservableCollection<NewMusicItem> {
                new NewMusicItem("Raining Sidewalk", "5 mins",
                "Lorem ipsum dolor sit amet consectetur adipiscing, elit aptent habitant nam accumsan at vitae, nostra dictumst venenatis facilisi porttitor.\n\n" +
                "Eget mattis vestibulum nibh bibendum dictum rhoncus sagittis tristique phasellus ad aptent penatibus, dis porta urna a interdum in et quisque libero nunc integer.\n\n" +
                "Sem nunc faucibus erat praesent iaculis varius primis class, pharetra cursus dictum nisi sollicitudin nam habitasse cras, platea pulvinar ligula conubia natoque cum arcu.","cactus.jpg"),
                
                new NewMusicItem("Spring Morning","7 mins"," Tellus nunc ad eleifend vulputate vivamus auctor nisl cursus torquent aliquam fusce condimentum, aptent lobortis montes penatibus ligula tempus lacinia ridiculus natoque arcu.\n\n " +
                "Himenaeos laoreet pretium congue hac lacinia odio faucibus pharetra pulvinar conubia curabitur, potenti orci dapibus vulputate lectus sapien cum ut ante aliquam.\n\n " +
                "Quam justo massa fermentum volutpat faucibus morbi suscipit, vitae penatibus vivamus molestie taciti tempor tellus, erat aliquam etiam himenaeos imperdiet libero.","spring.jpg"),
                
                new NewMusicItem("First Season","30 mins","Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis\n\n" +
                "dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem.Nulla consequat massa quis enim. Donec pede justo, fringilla vel, aliquet \n\n" +
                "nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus.\n\n " +
                "Vivamus elementum semper nisi. Aenean vulputate eleifend tellus. Aenean leo ligula, porttitor eu, consequat vitae, eleifend ac, enim. Aliquam lorem ante, dapibus in, viverra quis, feugiat a,","flowers.jpg")
            };
        }

        private async void OnSelectedMusicItem(NewMusicItem newMusicItem)
        {
            var parameters = new NavigationParameters();
            parameters.Add("musicItem", newMusicItem);

            await NavigationService.NavigateAsync($"{NavigationConstants.DetailPage}",parameters);
        }
    }
}
