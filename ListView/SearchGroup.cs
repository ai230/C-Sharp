using System;
using System.Collections.Generic;

namespace ListViewEx2
{
    public class SearchGroup : List<Search>
    {
		private string Title { get; set; }
		private string ShortTitle { get; set; }
		public SearchGroup(string title, string shortTitle)
		{
			this.Title = title;
			this.ShortTitle = shortTitle;
		}
    }
}
