using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class DummyPropertyRepository : IPropertyRepository
    {
        public IEnumerable<Property> Properties => properties;

        private static List<Property> properties = new()
        {
            new ()
            {
                Id = 1,
                Name = "Rose Cottage",
                Blurb = "Beautiful cottage on the Cornwall coast",
                Location = "Cornwall",
                NumberOfBedrooms = 3,
                CostPerNight = 350,
                Decription = "Ultra-comfortable apartment",
                Amenities = new List<string>{"WiFi", "Bath", "Good view"},
                BookedDates = null,
            },
            new ()
            {
                Id = 2,
                Name = "Safron House",
                Blurb = "Stately home on the Devon moores",
                Location = "Devon",
                NumberOfBedrooms = 7,
                CostPerNight = 730,
                Decription = "Ultra-comfortable apartment",
                Amenities = new List<string>{ "Bath", "Good view"},
                BookedDates = new List<DateTime>{DateTime.Now, new DateTime(2023, 12, 31)},
            },
        };
    }
}
