using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListViewEx2
{
    public partial class ContactAction : ContentPage
    {
        private List<ContactData> myContacts;
        List<ContactData> getContact(string searchText = null)
        {
            myContacts = new List<ContactData>
            {
				new ContactData {Name="Mitali",Status="Active",ImageUrl="http://lorempixel.com/100/100/people/1"},
				new ContactData {Name="Ai",Status="Absent",ImageUrl="http://lorempixel.com/100/100/people/2"},
				new ContactData {Name="Saeko",Status="Active",ImageUrl="http://lorempixel.com/100/100/people/3"},
				new ContactData {Name="Sena",Status="Present",ImageUrl="http://lorempixel.com/100/100/people/1"}
            };
            if (String.IsNullOrWhiteSpace(searchText))
                return myContacts;
            //return myContacts.Where(c => c.Name.StartsWith(searchText)).ToList();
            return myContacts;

        }

        public ContactAction()
        {
            InitializeComponent();

            myListView.ItemsSource = getContact();
            myListView.EndRefresh();
            myListView.IsRefreshing = false;
        }

        void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            myListView.ItemsSource = getContact(e.NewTextValue);
        }

        void MyListView_Refreshing(object sender, EventArgs e)
        {
			myListView.ItemsSource = getContact();
        }

        void Cell_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as ContactData;
            DisplayAlert("call", contact.Name, "OK");
        }
		void Delete_Clicked(object sender, EventArgs e)
		{
			var menuItem = sender as MenuItem;
			var contact = menuItem.CommandParameter as ContactData;
			myContacts.Remove(contact);
		}
		
    }
}
