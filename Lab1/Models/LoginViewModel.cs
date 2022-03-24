using System.ComponentModel.DataAnnotations;

namespace Lab1.Models
{
    public class LoginViewModel
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use latin letters only please")]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
