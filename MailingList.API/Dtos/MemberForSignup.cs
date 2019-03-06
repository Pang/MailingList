using System.ComponentModel.DataAnnotations;

namespace MailingList.API.Dtos
{
    public class MemberForSignup
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
    }
}