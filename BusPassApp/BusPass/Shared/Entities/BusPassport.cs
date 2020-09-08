using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace BusPass.Shared.Entities {
    public class BusPassport {
        public int BusPassportId { get; set; }
        public bool Valid { get; set; }
        public DateTime DateOfIssue { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int PassTypeId { get; set; }
        [NotMapped]
        public string typeName { get; set; }
        // public PassType PassType { get; set; }
        public ICollection<BusPassPayment> BusPassPayments { get; set; }

        public BusPassport(int userId, int typeId) {
            UserId = userId;
            PassTypeId = typeId;

        }

        public BusPassport() {}

    }
}