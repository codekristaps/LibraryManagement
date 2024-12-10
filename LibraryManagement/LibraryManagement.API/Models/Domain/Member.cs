using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.API.Models.Domain
{
    public class Member
    {
        [Key]
        public Guid MemberId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime MembershipDate { get; set; }
    }
}
