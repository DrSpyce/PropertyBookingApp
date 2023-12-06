using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Property
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Blurb { get; set; }
        public string? Location { get; set; }
        public int NumberOfBedrooms { get; set; }
        public decimal CostPerNight { get; set; }
        public string? Decription { get; set; }
        public List<Amenity>? Amenities { get; set; }
        public List<BookedDate>? BookedDates { get; set; }
    }
}
