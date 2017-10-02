using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConformationBox
{
    public partial class PickerDemo : ContentPage
    {
        public PickerDemo()
        {
            InitializeComponent();
        }

        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selectdMethod = myPicker.Items[myPicker.SelectedIndex];
            DisplayAlert("Selection", selectdMethod,"OK");
        }
    }
}
