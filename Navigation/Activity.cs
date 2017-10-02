using System;
namespace NavigationExercise
{
    public class Activity
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        private string path = "http://lorempixel.com/100/100/people/";

        public Activity(int userId, string userName, string description)
        {
            this.UserId = userId;
            this.UserName = userName;
			this.Description = description;
            this.ImageUrl = String.Concat(path,this.UserId);
        }
    }
}
