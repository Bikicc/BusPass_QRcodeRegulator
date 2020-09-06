using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BusPass.Shared.Entities {
    public class Year {
        public int YearId { get; set; }

        [Required]
        public string Name { get; set; }
        public ICollection<BusPassPayment> BusPassPayments { get; set; }
    }
}