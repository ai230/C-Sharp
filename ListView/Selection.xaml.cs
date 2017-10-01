using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListViewEx2
{
    public partial class Selection : ContentPage
    {
        public Selection()
        {
            InitializeComponent();
            myListView.ItemsSource = new List<ContactGroup>
            {
				new ContactGroup("M1","M")
				{
					new ContactData{Name="Mitali", Status="Active"},
					new ContactData{Name="Mary", Status="Sleeping"},
					new ContactData{Name="Mosh", Status="Active"}
				},
				new ContactGroup("S1","S")
				{
					new ContactData{Name="Saeko", Status="Active"},
					new ContactData{Name="Shinji", Status="Sleeping"},
					new ContactData{Name="Sena", Status="Active"}
				},
				new ContactGroup("H1","H")
				{
					new ContactData{Name="Hanna", Status="Absent"}

				}

            };

        }

        void MyListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as ContactData;
            DisplayAlert("Tapped", contact.Name, "OK");
        }

		void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
            var contact = e.SelectedItem as ContactData;
            DisplayAlert("Selected", contact.Name, "OK");
            myListView.SelectedItem = null;
		}
    }
}
