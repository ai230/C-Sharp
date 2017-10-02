using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ConformationBox
{
    public partial class Tabbed : TabbedPage
    {
        public Tabbed()
        {
            InitializeComponent();
            var page1 = new NavigationPage(new ConformationBoxPage());
            page1.Title = "Alert";
            this.Children.Add(page1);

            var page2 = new NavigationPage(new EntryDemo());
			page2.Title = "Entry";
			this.Children.Add(page2);

            var page3 = new NavigationPage(new PickerDemo());
			page3.Title = "Picker";
			this.Children.Add(page3);

            var page4 = new NavigationPage(new SliderDemo());
			page4.Title = "Slider";
            this.Children.Add(page4);

            var page5 = new NavigationPage(new SwitchDemo());
			page5.Title = "Switch";
			this.Children.Add(page5);
            //this.Children.Add(new NavigationPage = new ConformationBox());
        }
    }
}
