using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListViewEx2
{
    public partial class SearchAction : ContentPage
    {
		//pull-to-refresh dose not stop loading
		//remove dose not work
        List<SearchGroup> List_Base = new List<SearchGroup>();
		List<SearchGroup> List_Search = new List<SearchGroup>();
		List<SearchGroup> List_Temp;

        public SearchAction()
        {
			InitializeComponent();
			List_Base.Add(new SearchGroup("R", "Recent Searches")
				{
					new Search { Id = 1, Location = "West Hollywood, CA, United States", DateTime = "Sep 1, 2016 - Nov 1, 2016" },
					new Search { Id = 2, Location = "Santa Monica, CA, United States", DateTime = "Sep 2, 2016 - Nov 1, 2016" },
				    new Search { Id = 1, Location = "West Hollywood, CA, United States", DateTime = "Sep 3, 2016 - Nov 1, 2016" },
					new Search { Id = 2, Location = "Santa Monica, CA, United States", DateTime = "Sep 4, 2016 - Nov 1, 2016" }
				});
			
			foreach (var item in List_Base)
			{
				List_Search.Add(item);
			}
			myListView.ItemsSource = List_Search;

        }
		void SearhBar_TextChanged(object sender, TextChangedEventArgs e)
		{
            List_Temp = new List<SearchGroup>();
			string str = e.NewTextValue.ToLower();
			foreach (var item in List_Search)
			{
                
			//	if (item.Location.ToLower().Contains(str))
			//		List_Temp.Add(item);
			}
			//myListView.ItemsSource = List_Temp;

		}

		void ListView_Refreshing(object sender, System.EventArgs e)
		{
			myListView.ItemsSource = List_Search;
			myListView.EndRefresh();
		}

		void Delete_Clicked(object sender, System.EventArgs e)
		{
			var menuItem = sender as MenuItem;
			var deleteItem = menuItem.CommandParameter as Search;
			//List_Search.Remove(deleteItem);
			//myListView.ItemsSource = GetListData();
		}
		void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
		{

		}

		void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{

		}
    }
}
