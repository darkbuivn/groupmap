using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GroupMap.Models
{
    public class MapGroup: GroupMapBaseModel
    {
        public string Name { get; set; }
        public virtual ICollection<UserProfile> Members { get; set; }
        [Required]
        public Guid RegisteredBy { get; set; }
        public double RegisterDate { get; set; }
    }
}