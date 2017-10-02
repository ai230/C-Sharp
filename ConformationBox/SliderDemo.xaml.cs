using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConformationBox
{
    public partial class SliderDemo : ContentPage
    {
        public SliderDemo()
        {
            InitializeComponent();
        }

        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            var textValue = e.NewValue.ToString();
            myLabel.Text = textValue;
        }
    }
}
