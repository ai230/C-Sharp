using System.Collections.Generic;
using Xamarin.Forms;

namespace ListViewEx2
{
    public partial class ListViewEx2Page : ContentPage
    {
        public ListViewEx2Page()
        {
            InitializeComponent();
            myListView.ItemsSource = new List<ContactData>
            {
                new ContactData{Name="Mitali", Status="Active", ImageUrl="http://lorempixel.com/100/100/people/1"},
                new ContactData{Name="Mitali", Status="Active", ImageUrl="http://lorempixel.com/100/100/people/2"},
                new ContactData{Name="Mitali", Status="Active", ImageUrl="http://lorempixel.com/100/100/people/3"}
            };
        }
    }
}
