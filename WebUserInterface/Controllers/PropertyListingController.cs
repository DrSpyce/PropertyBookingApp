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
            var model = mapper.Map<IEnumerable<PropertyDetailsModel>>(propertyRepository.GetProperties);
            return View("ListProperties", model);
        }

        public IActionResult ListAvailable(DateTime start, DateTime end)
        {
            var result = propertyRepository.GetAvailableProperties(start, end);
            IEnumerable<PropertyDetailsModel>? model = null;
            if(result is not null)
            {
                model = mapper.Map<IEnumerable<PropertyDetailsModel>>(result);
            }
            ViewData["title"] = "List Available";
            return View("ListProperties", model);
        }

        [HttpGet]
        public IActionResult ViewPropertyDetails(int id) 
        {
            var result = propertyRepository.GetProperty(id);
            PropertyDetailsModel? model = null;
            if (result is not null)
            {
                model = mapper.Map<PropertyDetailsModel>(result);
            }
            return View("PropertyDetails", model);
        }
    }
}
