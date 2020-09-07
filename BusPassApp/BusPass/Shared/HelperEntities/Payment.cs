using BusPass.Shared.Entities;

namespace BusPass.Shared.HelperEntities {
    public class Payment {
        public int paymentId { get; set; }
        public int bussPassId { get; set; }
        public string holder { get; set; }
        public double price { get; set; }
        public string busPassType { get; set; }
        public string month { get; set; }
        public string dateOfPayment { get; set; }
        public Payment (BusPassPayment bpp, BusPassport bp, User u, string monthName, string busPassTypeName) {
            paymentId = bpp.BusPassPaymentId;
            bussPassId = bp.BusPassportId;
            holder = u.Name + " " + u.Surname;
            price = bpp.Price;
            busPassType = busPassTypeName;
            month = monthName;
            dateOfPayment = bpp.DateOfPayment.Date.ToShortDateString();
        }

        public Payment () {}
    }

}