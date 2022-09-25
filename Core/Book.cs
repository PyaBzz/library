using System.ComponentModel.DataAnnotations;

namespace Core
{
    public class Book
    {
        public int? Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
        [DateRange]
        public DateTime PublishedOn { get; set; }

        public Book() { }

        public Book(string title, string author, DateTime publishedOn, int? id = null)
        {
            Title = title;
            Author = author;
            PublishedOn = publishedOn;
            Id = id;
        }
    }
}
