using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusPass.Shared.Entities
{
    public class Month
    {
        public int MonthId { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<BusPassPayment> BusPassPayments { get; set; }

    }
}
