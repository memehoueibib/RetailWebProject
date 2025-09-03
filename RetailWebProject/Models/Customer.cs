using System.ComponentModel.DataAnnotations;

namespace RetailWebProject.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Full name is required")]
        [StringLength(50, ErrorMessage = "Full name cannot exceed 50 characters")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [Display(Name = "Email Address")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Date of birth is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Age")]
        public int Age => DateTime.Now.Year - DateOfBirth.Year - 
            (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear ? 1 : 0);
    }
}