using System.ComponentModel.DataAnnotations;

namespace MVC_Application.Models
{
    public class UserRegistration
    {
        // First Name
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, MinimumLength = 2,
            ErrorMessage = "First Name must be between 2 and 50 characters")]
        [RegularExpression("^[a-zA-Z]+$",
            ErrorMessage = "First Name must contain only letters")]
        public string FirstName { get; set; }

        // Last Name
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50, MinimumLength = 2,
            ErrorMessage = "Last Name must be between 2 and 50 characters")]
        [RegularExpression("^[a-zA-Z]+$",
            ErrorMessage = "Last Name must contain only letters")]
        public string LastName { get; set; }

        // Address
        [Required(ErrorMessage = "Address is required")]
        [StringLength(200,
            ErrorMessage = "Address cannot exceed 200 characters")]
        public string Address { get; set; }

        // Email
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        public string Email { get; set; }

        // Password
        [Required(ErrorMessage = "Password is required")]
        [StringLength(15, MinimumLength = 6,
            ErrorMessage = "Password must be between 6 and 15 characters")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@#$%^&+=]).+$",
            ErrorMessage = "Password must contain uppercase, lowercase, number and special character")]
        public string Password { get; set; }

        // Confirm Password
        [Required(ErrorMessage = "Confirm Password is required")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

        // Gender
        [Required(ErrorMessage = "Please select gender")]
        public string Gender { get; set; }

        // City
        [Required(ErrorMessage = "Please select city")]
        public string City { get; set; }
    }
}