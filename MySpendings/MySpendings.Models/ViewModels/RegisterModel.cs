using System.ComponentModel.DataAnnotations;

namespace MySpendings.Models.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Please provide Name")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Please provide Email")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Please provide Login")]
        public required string Login { get; set; }

        [Required(ErrorMessage = "Please provide Income")]
        public int Income { get; set; }

        [Required(ErrorMessage = "Please provide Password")]
        [DataType(DataType.Password)]
        public required string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Incorrect password ")]
        [Display(Name = "Confirm Password")]
        public required string ConfirmPassword { get; set; }
    }
}
