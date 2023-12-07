using Domain.Data;
using Domain.Entities;
using Domain.Exceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Property = Domain.Entities.Property;

namespace Domain.Repositories
{
    public class EfBookingRepository : IBookingRepository
    {
        ApplicationDbContext dbContext;
        public EfBookingRepository(ApplicationDbContext DbContext)
        {
            dbContext = DbContext;
        }

        public Booking MakeBooking(Booking booking, int propertyId)
        {
            var property = dbContext.Properties
                .Where(p => p.Id == propertyId)
                .Include(p => p.Booking)
                .First();
            if(IsDateRangeAvailable(booking.Start, booking.End, property))
            {
                booking.Property = property;
                dbContext.Booking.Add(booking);
                dbContext.SaveChanges();
                return booking;
            }

            throw new BookingExceptions();
        }

        private bool IsDateRangeAvailable(DateTime inputStart, DateTime inputEnd, Property property)
        {
            // Check if the new date range intersects with any existing bookings
            bool isAvailable = !property.Booking.Any(b =>
                (inputStart >= b.Start && inputStart < b.End) ||
                (inputEnd >= b.Start && inputEnd <= b.End) ||
                (inputStart <= b.Start && inputEnd >= b.End)
            );

            return isAvailable;
        }
    }
}
