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
        public IEnumerable<Property> GetProperties => properties;

        public IEnumerable<Property> GetAvailableProperties(DateTime start, DateTime end)
        {
            return properties.Where(p => 
                p.BookedDates is null ||
                !p.BookedDates!.Any(d => d.Start < end && d.End > start));
        }

        public Property GetProperty(int id)
        {
            return properties.Where(p => p.Id == id).First();
        }

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
                Amenities = new List<Amenity>
                {
                    new Amenity() {Id = 1, Name = "Wifi"},
                    new Amenity() {Id = 2, Name = "Comfortable bed"}
                },
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
                Amenities = new List<Amenity>
                {
                    new Amenity() {Id = 1, Name = "Wifi"},
                    new Amenity() {Id = 2, Name = "Comfortable bed"}
                },
                BookedDates = new List<BookedDate>
                {
                    new BookedDate() { Start = new DateTime(2024, 1, 1), End = new DateTime(2024, 1, 20) },

                    new BookedDate() { Start = DateTime.Now, End = new DateTime(2023, 12, 25) }
                },
            },
        };

        
    }
}