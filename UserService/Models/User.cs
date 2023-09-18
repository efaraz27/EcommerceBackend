using System.ComponentModel.DataAnnotations;

namespace UserService.Models
{
    public class User
    {
        public required string Id { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Not a valid email address")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Invalid characters")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "First name should be between 3 and 50 characters long")]
        public required string FirstName { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Invalid characters")]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "Last name should be between 3 and 50 characters long")]
        public required string LastName { get; set; }

        public string? Phone { get; set; }

        public string? Address { get; set; }

        public string? City { get; set; }

        public string? Region { get; set; }

        public string? PostalCode { get; set; }

        public string? Country { get; set; }

    }

}
