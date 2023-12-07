﻿using Domain.Entities;
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

        public void BookDates(BookedDate bookedDate, int id)
        {
            var result = properties?.Where(p => p.Id == id).First();
            if(result is not null)
            {
                result.BookedDates.Add(bookedDate);
            }
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
            },
        };


    }
}