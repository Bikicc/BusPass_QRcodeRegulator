using System.ComponentModel.DataAnnotations;

namespace BusPass.Shared.HelperEntities {
    public class LoginUser {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
        public string OIB { get; set; }
        // public string DOBstring { get; set; }

        [Required]
        [RegularExpression (@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage = "Invalid Email!")]
        public string Email { get; set; }

        public string Password { get; set; }

        [Required (ErrorMessage = "This field is required")]
        [StringLength (15, ErrorMessage = "Password must be between {2} and {1}", MinimumLength = 4)]
        public string PasswordPlain { get; set; }
    }
}