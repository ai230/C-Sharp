using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationExercise
{
    public partial class Instagram : ContentPage
    {
        public ListView()
        {
            InitializeComponent();
            listView.ItemsSource = new List<Activity>
            {
                new Activity{UserId=1, Description="Your Facebook friend Jenny Dalby"},
                new Activity{UserId=2,Description="Your Facebook friend Jenny Dalby"},
                new Activity{UserId=2,Description="Your Facebook friend Jenny Dalby"}
            };
        }
    }
}
