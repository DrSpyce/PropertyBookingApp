using Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Data
{
    public class Seeder
    {
        public static void SeedData(ApplicationDbContext context)
        {
            context.Amenities.AddRange(amenities);
            properties[0].Amenities.Add(amenities[0]);
            properties[0].Amenities.Add(amenities[1]);
            properties[1].Amenities.Add(amenities[1]);
            properties[1].Amenities.Add(amenities[2]);
            properties[0].BookedDates.Add(bookedDates[0]);
            context.Properties.AddRange(properties);
            context.SaveChanges();
        }

        private static List<Amenity> amenities = new()
        {
            new(){ Name = "WiFi" },
            new(){ Name = "Comfortable bed" },
            new(){ Name = "Good view" },
        };

        private static List<Property> properties = new()
        {
            new ()
            {
                Name = "Rose Cottage",
                Blurb = "Beautiful cottage on the Cornwall coast",
                Location = "Cornwall",
                NumberOfBedrooms = 3,
                CostPerNight = 350,
                Decription = "Ultra-comfortable apartment",
            },
            new ()
            {
                Name = "Safron House",
                Blurb = "Stately home on the Devon moores",
                Location = "Devon",
                NumberOfBedrooms = 7,
                CostPerNight = 730,
                Decription = "Ultra-comfortable apartment",
            },
        };

        private static List<BookedDate> bookedDates = new List<BookedDate>()
        {
            new BookedDate() { Start = new DateTime(2024, 1, 1), End = new DateTime(2024, 1, 20) },
            new BookedDate() { Start = DateTime.Now, End = new DateTime(2023, 12, 25) }
        };


    }
}
