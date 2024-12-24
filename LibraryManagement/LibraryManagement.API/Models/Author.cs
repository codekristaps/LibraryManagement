using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LibraryManagement.API.Models
{
    public class Author
    {
        [Key]
        public Guid AuthorId { get; set; }
        [Required(ErrorMessage = "Author name is required.")]
        [MaxLength(100, ErrorMessage = "Author name must not exceed 100 characters.")]
        [MinLength(2, ErrorMessage = "Author name must be at least 2 characters long.")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Author name can only contain letters and spaces.")]
        public string Name { get; set; }

        // Optional: You can still include books for viewing purposes
        public ICollection<Book>? Books { get; set; }
    }
}
