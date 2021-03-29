using System;
using System.Collections.Generic;
using System.Text;

namespace UIReplication.Models
{
    public class NewMusicItem
    {
        public NewMusicItem(string title, string mins, string description, string imageSource)
        {
            Title = title;
            Mins = mins;
            Description = description;
            ImageSource = imageSource;
        }

        public string Title { get; }
        public string Mins { get; }
        public string ClockImageSource { get; } = "clock.png";
        public string Description { get; }

        public string ImageSource { get; }
    }
}
