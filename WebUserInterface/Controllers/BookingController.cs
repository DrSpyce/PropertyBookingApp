using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using WebUserInterface.Models;

namespace WebUserInterface.Controllers
{
    public class BookingController : Controller
    {
        private readonly IPropertyRepository propertyRepository;
        private readonly IMapper mapper;

        public BookingController(IPropertyRepository PropertyRepository, IMapper Mapper)
        {
            propertyRepository = PropertyRepository;
            mapper = Mapper;
        }

        [HttpPost]
        public IActionResult Book(BookedDateModel date, int Id)
        {
            propertyRepository.BookDates(mapper.Map<BookedDate>(date), Id);
            return RedirectToAction("ListAll", controllerName: "PropertyListing");
        }
    }
}
