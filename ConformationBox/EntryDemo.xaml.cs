using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConformationBox
{
    public partial class EntryDemo : ContentPage
    {
        public EntryDemo()
        {
            InitializeComponent();

        }

        void Handle_Completed(object sender, System.EventArgs e)
        {
            myLabel.Text = "Completed";
        }

        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            myLabel.Text = e.NewTextValue;
        }
    }
}
