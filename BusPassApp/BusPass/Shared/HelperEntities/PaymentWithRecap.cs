using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BusPass.Shared.HelperEntities {
    public class PaymentWithRecap {
        public ICollection<Payment> payments { get; set; }
        public double totalAmountPaid { get; set; }
        public int numberOfPayments { get; set; }

        public PaymentWithRecap (ICollection<Payment> payment, double total, int numberOfP) {
            payments = new Collection<Payment>();
            foreach (var pay in payment)
            {
                payments.Add(pay);
            }
            totalAmountPaid = total;
            numberOfPayments = numberOfP;
        }

        public PaymentWithRecap(){}
    }

}