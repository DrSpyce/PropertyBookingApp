using Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using WebUserInterface.Models;

namespace WebUserInterface.Controllers
{
    public class PropertyManagementController : Controller
    {
        private readonly IPropertyRepository propertyRepository;

        public PropertyManagementController(IPropertyRepository PropertyRepository)
        {
            propertyRepository = PropertyRepository;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(PropertyDetailsModel pdModel)
        {
            return View();
        }
    }
}
