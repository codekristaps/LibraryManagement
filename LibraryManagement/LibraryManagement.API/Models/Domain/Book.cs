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
        public Guid AuthorId { get; set; }

        // Navigation property for author
        public Author? Author { get; set; }
    }
}
