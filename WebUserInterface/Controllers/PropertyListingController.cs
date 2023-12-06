using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using WebUserInterface.Models;

namespace WebUserInterface.Controllers
{
    public class PropertyListingController : Controller
    {
        private readonly IPropertyRepository propertyRepository;
        private readonly IMapper mapper;

        public PropertyListingController(IPropertyRepository PropertyRepository, IMapper Mapper)
        {
            propertyRepository = PropertyRepository;
            mapper = Mapper;
        }

        public IActionResult ListAll()
        {
            var model = mapper.Map<IEnumerable<PropertyDetailsModel>>(propertyRepository.Properties);
            return View("ListProperties", model);
        }

        public IActionResult ListAvailable(DateTime start, DateTime end)
        {
            var result = propertyRepository.Properties.Where(p => p.BookedDates is null || !(p.BookedDates[0] < end && p.BookedDates[1] > start));
            var model = mapper.Map<IEnumerable<PropertyDetailsModel>>(result);
            ViewData["title"] = "List Available";
            return View("ListProperties", model);
        }

        [HttpGet]
        public IActionResult ViewPropertyDetails(int id) 
        {
            var result = propertyRepository.Properties.Where(p => p.Id == id).First();
            var model = mapper.Map<PropertyDetailsModel>(result);
            return View("PropertyDetails", model);
        }
    }
}
