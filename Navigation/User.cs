using System;
namespace NavigationExercise
{
    public class User
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string ImageUrl1 { get; set; }
        private string path = "http://lorempixel.com/200/200/people/";

        public User(int id, string name, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.ImageUrl1 = String.Concat(path, this.Id);
        }
    }
}
