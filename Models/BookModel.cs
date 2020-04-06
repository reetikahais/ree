using System;

namespace firstapp.Models
{
    public class BookModel
    {
        public BookModel(int Id, string Title, string Author, string Image){
            this.Id = Id;
            this.Author = Author;
            this.Title = Title;
            this.Image = Image;
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public string Author { get; set; }
        public string Image { get; set; }

    }
}
