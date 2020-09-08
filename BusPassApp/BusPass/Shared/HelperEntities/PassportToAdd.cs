using System.ComponentModel.DataAnnotations;

namespace BusPass.Shared.HelperEntities {
    public class PassportToAdd {
        [Required (ErrorMessage = "This field is required")]
        public string Name { get; set; }

        [Required (ErrorMessage = "This field is required")]
        public string Surname { get; set; }
        // public DateTime DOB { get; set; }

        [Required (ErrorMessage = "This field is required")]
        [StringLength (maximumLength: 11, MinimumLength = 11, ErrorMessage = "OIB length must be 11 characters")]
        [RegularExpression (@"^[0-9]*$", ErrorMessage = "OIB contains only numbers")]
        public string OIB { get; set; }

        [Required]
        [RegularExpression (@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage = "Invalid Email!")]
        public string Email { get; set; }

        [Required (ErrorMessage = "This field is required")]
        [StringLength (15, ErrorMessage = "Password must be between {2} and {1}", MinimumLength = 4)]
        public string PasswordPlain { get; set; }

        [Required (ErrorMessage = "This field is required")]
        [StringLength (maximumLength: 21, MinimumLength = 21, ErrorMessage = "IBAN length must be 21 characters")]
        public string IBAN { get; set; }

        [Required (ErrorMessage = "This field is required")]
        public double  Balance { get; set; }

        [Required (ErrorMessage = "This field is required")]
        public int UserId { get; set; }

        [Required (ErrorMessage = "This field is required")]
        public int PassTypeId { get; set; }

    }
}