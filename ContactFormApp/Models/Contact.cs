using System.ComponentModel.DataAnnotations;

namespace ContactFormApp.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^07[789]\d{7}$", ErrorMessage = "Phone number must start with '077', '078', or '079' and be exactly 10 digits long.")]
        [StringLength(10, ErrorMessage = "Phone number can't exceed 10 digits.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Message is required.")]
        [StringLength(500, ErrorMessage = "Message can't exceed 500 characters.")]
        public string Message { get; set; }
    }
}
