using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusPass.Shared.Entities {
    public class PassType {
        public int PassTypeId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }
        public ICollection<BusPassport> BusPassports { get; set; }

        public object Shallowcopy () {
            return this.MemberwiseClone ();
        }

    }
}