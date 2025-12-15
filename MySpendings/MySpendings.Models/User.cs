using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace MySpendings.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Login { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public string? ImageUrl { get; set; }
        public int Income { get; set; }
    }
}
