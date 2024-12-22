using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LibraryManagement.API.Models
{
    public class Author
    {
        [Key]
        public Guid AuthorId { get; set; }
        [Required]
        public string Name { get; set; }

        // Optional: You can still include books for viewing purposes
        public ICollection<Book>? Books { get; set; }
    }
}
