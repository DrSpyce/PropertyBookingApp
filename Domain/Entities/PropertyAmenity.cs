using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PropertyAmenity
    {
        public int PropertyId { get; set; }
        public Property? Country { get; set; }

        public int AmenityId { get; set; }
        public Amenity? Business { get; set; }
    }
}
