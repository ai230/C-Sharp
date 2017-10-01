using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListViewEx2
{
    public partial class Tabbed : TabbedPage
    {
        public Tabbed()
        {
            InitializeComponent();
            var Page1 = new NavigationPage(new ListViewEx2Page());
            Page1.Title = "Page1";
			this.Children.Add(Page1);
            var Page2 = new NavigationPage(new CustamCellList());
            Page2.Title = "Page2";
            this.Children.Add(Page2);
            var Page3 = new NavigationPage(new Selection());
			Page3.Title = "Page3";
			this.Children.Add(Page3);
            var Page4 = new NavigationPage(new ContactAction());
			Page4.Title = "Page4";
			this.Children.Add(Page4);

        }
    }
}
