using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationExercise
{
    public partial class InstagramDetail : ContentPage
    {
        public InstagramDetail(Activity activity)
        {
            

            if (activity == null)
                throw new ArgumentException();
            
            BindingContext = activity;
            new User(activity.UserId, "Namename", activity.Description);
            InitializeComponent();
        }
    }
}
