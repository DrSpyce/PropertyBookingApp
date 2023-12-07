using AutoMapper;
using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using WebUserInterface.Models;

namespace WebUserInterface.Controllers
{
    public class PropertyManagementController : Controller
    {
        private readonly IPropertyRepository propertyRepository;
        private readonly IMapper mapper;

        public PropertyManagementController(IPropertyRepository PropertyRepository, IMapper Mapper)
        {
            propertyRepository = PropertyRepository;
            mapper = Mapper;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(PropertyModel pdModel)
        {
            return View();
        }
    }
}
