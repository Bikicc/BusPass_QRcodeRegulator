using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using BusPass.Shared.HelperEntities;
namespace BusPass.Shared.Entities {
    public class User {
        public int UserId { get; set; }

        [Required (ErrorMessage = "This field is required")]
        public string Name { get; set; }

        [Required (ErrorMessage = "This field is required")]
        public string Surname { get; set; }

        [Required (ErrorMessage = "This field is required")]
        [StringLength (maximumLength: 11, MinimumLength = 11, ErrorMessage = "OIB length must be 11 characters")]
        [RegularExpression (@"^[0-9]*$")]
        public string OIB { get; set; }
        public string Role { get; set; }

        [Required]
        [RegularExpression (@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$")]
        public string Email { get; set; }

        [JsonIgnore]
        public string Password { get; set; }

        [Required (ErrorMessage = "This field is required")]
        [StringLength (15, ErrorMessage = "Password must be between {2} and {1}", MinimumLength = 4)]
        [NotMapped]
        public string PasswordPlain { get; set; }
        public BusPassport BusPassports { get; set; }
        public Account Account { get; set; }

        public User(PassportToAdd pass) {
            Name = pass.Name;
            Surname = pass.Surname;
            OIB = pass.OIB;
            Email = pass.Email;
            PasswordPlain = pass.PasswordPlain;
            Role = "User";
        }

        public User() {}

    }
}