using System.ComponentModel.DataAnnotations;

namespace client.Models
{
    public class Speaker
    {
        public string SpeakerId { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z -]*$", ErrorMessage="First name must be alphabetical")]
        public string FirstName { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z -]*$", ErrorMessage="Last Name must be alphabetical")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public string MobileNumber { get; set; }
        [Required]
        public string Specialization { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z -]*$", ErrorMessage="City must be alphabetical")]
        public string City { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z -]*$", ErrorMessage="Province must be alphabetical")]
        public string Province { get; set; }
        [Required]
        public string Employer { get; set; }

    }
}