using Domain.Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class EfPropertyRepository : IPropertyRepository
    {
        ApplicationDbContext dbContext;
        public EfPropertyRepository(ApplicationDbContext DbContext)
        {
            dbContext = DbContext;
        }

        public IEnumerable<Property> GetProperties => dbContext.Properties;

        public IEnumerable<Property> GetAvailableProperties(DateTime start, DateTime end)
        {
            return dbContext.Properties
                .Include(p => p.Booking)
                .Where(p => !p.Booking!.Any(d => d.Start < end && d.End > start));
        }

        public Property GetProperty(int id)
        {
            return dbContext.Properties
                .Where(p => p.Id == id)
                .Include(p => p.Amenities)
                .Include(p => p.Booking)
                .First();
        }
    }
}
