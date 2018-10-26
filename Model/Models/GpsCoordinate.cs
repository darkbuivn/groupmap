using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupMap.Models
{
    public class GpsCoordinate: GroupMapBaseModel
    {       
        public Guid UserProfileId { get; set; }

        public virtual UserProfile User { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public double ReceivedDate { get; set; }
    }
}
