using System;
using BusPass.Shared.Entities;

namespace BusPass.Shared.HelperEntities
{
    public class UserBusPassport
    {
        public int passportId { get; set; }
        public int userId { get; set; }
        public string holder { get; set; }
        public string passType { get; set; }
        public string dateOfIssue { get; set; }
        public UserBusPassport(BusPassport passport, User user, string passTypeName) {
            passportId = passport.BusPassportId;
            userId = user.UserId;
            holder = user.Name + " " + user.Surname;
            dateOfIssue = passport.DateOfIssue.Date.ToShortDateString();
            passType = passTypeName;
        }

        public UserBusPassport(){}

    }
}