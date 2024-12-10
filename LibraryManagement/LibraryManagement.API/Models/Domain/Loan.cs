using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.API.Models.Domain
{
    public class Loan
    {
        [Key]
        public Guid LoanId { get; set; }
        public Guid BookId { get; set; } // FK to Book
        public Guid MemberId { get; set; } // FK to Member
        public DateTime BorrowedDate { get; set; }
        public DateTime? ReturnedDate { get; set; } // Nullable for active loans
        public Book Book { get; set; } // Navigation Property
        public Member Member { get; set; } // Navigation Property
    }
}
