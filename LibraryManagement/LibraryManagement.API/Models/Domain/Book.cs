using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.API.Models.Domain
{
    public class Book
    {
        [Key]
        public Guid BookId { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public int PublishedYear { get; set; }
        public Guid AuthorId { get; set; } // FK to Author
        public bool IsAvailable { get; set; } // To track availability
        public Author Author { get; set; } // Navigation Property
    }
}
