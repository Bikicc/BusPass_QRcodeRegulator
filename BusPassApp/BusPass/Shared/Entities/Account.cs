using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusPass.Shared.Entities
{
    public class Account
    {
        public int AccountId { get; set; }
        
        [Required(ErrorMessage = "This field is required")]
        [StringLength(maximumLength: 21, MinimumLength = 21, ErrorMessage = "IBAN length must be 21 characters")]
        public string IBAN { get; set; }
        public double Balance { get; set; }
        
        [ForeignKey("User")]
        public int UserId { get; set; }

    }
}
