using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusPass.Shared.Entities
{
    public class BusPassport
    {
        public int BusPassportId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public bool Valid { get; set; }
        public DateTime DateOfIssue { get; set; }

        public virtual User User { get; set; }
        public int PassTypeId { get; set; }
        public PassType PassType { get; set; }

        public ICollection<BusPassPayment> BusPassPayments { get; set; }


    }
}
