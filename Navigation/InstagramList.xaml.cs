using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationExercise
{
    public partial class InstagramList : ContentPage
    {
        public InstagramList()
        {
            InitializeComponent();
			listView.ItemsSource = new List<Activity>
			{
                new Activity(1,"Jenny Dalby","Your Facebook friend Jenny Dalby ia on Instagram"),
                new Activity(2,"Jonv","Jonv started following you"),
                new Activity(3,"RacheMartini","RacheMartini liked your photo"),
                new Activity(4,"Nivan Joy","Your Facebook friend Nivan Joy is on Instagram"),
			};
        }

        private async void Listview_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var Item = e.SelectedItem as Activity;
            await Navigation.PushAsync(new InstagramDetail(Item));   
        }
    }
}
