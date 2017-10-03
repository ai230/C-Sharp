using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LayoutExample
{
    public partial class Tabbed : TabbedPage
    {
        public Tabbed()
        {
            InitializeComponent();
            var page1 = new NavigationPage(new GridLayout1());
            page1.Title = "Grid1";
            this.Children.Add(page1);

			var page2 = new NavigationPage(new GridLayout2());
			page2.Title = "Grid1";
			this.Children.Add(page2);

            var page3 = new NavigationPage(new GridLayoutEx());
			page3.Title = "Grid3";
			this.Children.Add(page3);

            var page4 = new NavigationPage(new StackLayout());
			page4.Title = "StackLayout1";
			this.Children.Add(page4);

            var page5 = new NavigationPage(new StackLayout2());
			page5.Title = "StackLayout2";
			this.Children.Add(page5);

            var page6 = new NavigationPage(new RelativeLayoutEx());
			page6.Title = "RelativeLayout";
			this.Children.Add(page6);

            var page7 = new NavigationPage(new AbsoluteLayoutEx());
			page7.Title = "AbsoluteLayout";
			this.Children.Add(page7);
        }
    }
}
