using System;
using System.Collections.Generic;
using System.Text;

namespace BusPass.Shared.Entities
{
    public class BusPassPayment
    {
        public int BusPassPaymentId { get; set; }
        public DateTime DateOfPayment { get; set; }
        
        public int BusPassportId { get; set; }
        public BusPassport BusPass { get; set; }

        public int MonthId { get; set; }
        public Month Month { get; set; }


    }
}
