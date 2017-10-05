using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationExercise
{
    public partial class Tabbed : TabbedPage
    {
        public Tabbed()
        {
            InitializeComponent();
            var Page1 = new NavigationPage(new InstagramList());
            Page1.Title = "Activities";

			var Page2 = new NavigationPage(new InstagramList());
			Page2.Title = "Profile";

            this.Children.Add(Page1);
            this.Children.Add(Page1);
        }
    }
}
