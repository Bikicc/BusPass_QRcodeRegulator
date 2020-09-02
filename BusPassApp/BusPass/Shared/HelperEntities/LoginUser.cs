using System.ComponentModel.DataAnnotations;

namespace BusPass.Shared.HelperEntities {
    public class LoginUser {
        [Required]
        [RegularExpression (@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$")]
        public string Email { get; set; }

        public string Password { get; set; }

        public string PasswordPlain { get; set; }
    }
}