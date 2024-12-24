using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.API.Models
{
    public class Book
    {
        [Key]
        public Guid BookId { get; set; }
        [Required(ErrorMessage = "Title is required.")]
        [MaxLength(100, ErrorMessage = "Title must not exceed 100 characters.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "ISBN is required.")]
        [RegularExpression(@"^[0-9X\-]+$", ErrorMessage = "ISBN must only contain digits, hyphens, or 'X'.")]
        [MaxLength(20, ErrorMessage = "ISBN must be a maximum of 20 characters.")]
        public string ISBN { get; set; }
        [Required(ErrorMessage = "Published year is required.")]
        [Range(1500, 2100, ErrorMessage = "Published year must be between 1500 and 2100.")]
        public int PublishedYear { get; set; }
        public Guid AuthorId { get; set; }

        // Navigation property for author
        public Author? Author { get; set; }
    }
}
