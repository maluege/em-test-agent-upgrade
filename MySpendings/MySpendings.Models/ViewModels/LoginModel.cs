using System.ComponentModel.DataAnnotations;

namespace MySpendings.Models.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Please provide Login")]
        public required string Login { get; set; }

        [Required(ErrorMessage = "Please provide Password")]
        [DataType(DataType.Password)]
        public required string Password { get; set; }
    }
}
