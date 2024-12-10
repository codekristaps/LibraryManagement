using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.API.Models.Domain
{
    public class Author
    {
        [Key]
        public Guid AuthorId { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; } // Navigation Property
    }
}
