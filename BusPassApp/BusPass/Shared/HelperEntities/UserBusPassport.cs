using BusPass.Shared.Entities;

namespace BusPass.Shared.HelperEntities
{
    public class UserBusPassport
    {
        public int passSerialCode { get; set; }
        public string holder { get; set; }
        public UserBusPassport(BusPassport passport, User user) {
            passSerialCode = passport.BusPassportId;
            holder = user.Name + " " + user.Surname;
        }

    }
}