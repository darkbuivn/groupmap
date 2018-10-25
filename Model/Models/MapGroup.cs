using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMap.Models
{
    public class MapGroup: GroupMapBaseModel
    {
        public string Name { get; set; }
        public virtual ICollection<UserProfile> Members { get; set; }
        [Required]
        public Guid RegisteredBy { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
