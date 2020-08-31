using System;
using System.ComponentModel.DataAnnotations;

namespace BusPass.Shared.Entities {
    public class BusPassPayment {
        public int BusPassPaymentId { get; set; }

        [Required]
        public DateTime DateOfPayment { get; set; }

        [Required]
        public int BusPassportId { get; set; }
        public BusPassport BusPass { get; set; }

        [Required]
        public int MonthId { get; set; }
        public Month Month { get; set; }

        [Required]
        public double price { get; set; }

    }
}