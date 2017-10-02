using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConformationBox
{
    public partial class ActionSheet : ContentPage
    {
        public ActionSheet()
        {
            InitializeComponent();

        }

        private async void Handle_Clicked(object sender, System.EventArgs e)
        {
            //DisplayActionSheet("Title", "Cancel", "Delete", "Call", "Message", "Email", "Whatup");
            var responce = await DisplayActionSheet("Contact Method", "Cancel", "Delete", "Call", "Message", "Email", "Whatup");
            await DisplayAlert("Yor Contact method", responce, "OK");    
        }
    }
}
