using System;
using System.Collections.Generic;
using System.Text;

namespace BusPass.Shared.Entities
{
    public class Month
    {
        public int MonthId { get; set; }
        public string Name { get; set; }

        public ICollection<BusPassPayment> BusPassPayments { get; set; }

    }
}
