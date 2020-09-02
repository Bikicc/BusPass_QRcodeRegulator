using System;
using System.Collections.Generic;
using System.Text;

namespace BusPass.Shared.Entities
{
    public class PassType
    {
        public int PassTypeId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public ICollection<BusPassport> BusPassports { get; set; }

    }
}
