using System.ComponentModel.DataAnnotations;

namespace Core
{
    public class Book
    {
        public int? Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishedOn { get; set; }

        public Book() { }

        public Book(int? id, string title, string author, DateTime publishedOn)
        {
            Id = id;
            Title = title;
            Author = author;
            PublishedOn = publishedOn;
        }
    }
}
