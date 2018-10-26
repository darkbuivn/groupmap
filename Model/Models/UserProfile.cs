using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupMap.Models
{
    public class UserProfile: GroupMapBaseModel
    {
        public string FullName { get; set; }

        public string Email { get; set; }

        public string PhoneNum { get; set; }

        public double RegisterDate { get; set; }

        public virtual ICollection<MapGroup> ParticipatedGroup { get; set; }

        [ForeignKey("UserProfileId")]
        public virtual ICollection<GpsCoordinate> Coordinates { get; set; }

        public string AspNetUserId { get; set; }
    }
}
