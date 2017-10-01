using System;
using System.Collections.Generic;
namespace ListViewEx2
{
    public class ContactGroup : List<ContactData>
    {
        public string Title { get; set; }
        public string ShortTitle { get; set; }
        public ContactGroup(string title, string shorttitle)
        {
            this.Title = title;
            this.ShortTitle = shorttitle;

        }
    }
}
