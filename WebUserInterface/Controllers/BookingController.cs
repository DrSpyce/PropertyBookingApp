using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using WebUserInterface.Models;

namespace WebUserInterface.Controllers
{
    public class BookingController : Controller
    {
        private readonly IBookingRepository bookingRepository;
        private readonly IMapper mapper;

        public BookingController
            (IBookingRepository BookingRepository, IMapper Mapper)
        {
            bookingRepository = BookingRepository;
            mapper = Mapper;
        }

        [HttpPost]
        public IActionResult Book(BookingModel date)
        {
            var result = bookingRepository.MakeBooking(mapper.Map<Booking>(date), date.PropertyId);
            var bookingModel = mapper.Map<BookingModel>(result);
            bookingModel.PropertyModel = mapper.Map<PropertyModel>(result.Property);
            return View(bookingModel);
        }
    }
}
