using System.ComponentModel.DataAnnotations;

namespace BashCVPortfolio.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "Please enter your name.")]
        [StringLength(100)]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Please enter your email address.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Please enter a subject.")]
        [StringLength(150)]
        public string Subject { get; set; } = "";

        [Required(ErrorMessage = "Please enter your message.")]
        [StringLength(1000, MinimumLength = 10,
            ErrorMessage = "Your message must be between 10 and 1000 characters.")]
        public string Message { get; set; } = "";
    }
}