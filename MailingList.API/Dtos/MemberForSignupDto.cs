using System.ComponentModel.DataAnnotations;

namespace MailingList.API.Dtos
{
    public class MemberForSignupDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        // [StringLength(50, MinimumLength = 4, ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }
    }
}