using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConformationBox
{
    public partial class SwitchDemo : ContentPage
    {
        public SwitchDemo()
        {
            InitializeComponent();
        }

        void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            myLabel.IsVisible = e.Value;
        }
    } 
}
