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

            bookedDates[0].Property = properties[0];
            bookedDates[1].Property = properties[1];

            context.Booking.AddRange(bookedDates);

            properties?[0].Amenities?.Add(amenities[0]);
            properties?[0].Amenities?.Add(amenities[1]);
            properties?[1].Amenities?.Add(amenities[1]);
            properties?[1].Amenities?.Add(amenities[2]);
            if(properties is not null)
            {
                context.Properties.AddRange(properties);
            }
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
                Blurb = "Beautiful cottage on the Cornwall c//oast",
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

        private static List<Booking> bookedDates = new List<Booking>()
        {
            new Booking() 
            {
                BillingAddress = "Cornwall billing address",
                CostPerNight = 350,
                Start = new DateTime(2024, 1, 1), 
                End = new DateTime(2024, 1, 20) 
            },
            new Booking()
            {
                BillingAddress = "Safron billing address",
                CostPerNight = 730,
                Start = DateTime.Now,
                End = new DateTime(2023, 12, 25)
            },
        };
    }
}
