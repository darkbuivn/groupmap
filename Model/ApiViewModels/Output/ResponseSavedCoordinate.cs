using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMap.Models.ApiViewModels.Output
{
    public class ResponseSavedCoordinate 
    {
        public string UserName { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }
    }
}
