using Microsoft.AspNetCore.Mvc;
using WebUserInterface.Models;

namespace WebUserInterface.Controllers
{
    public class PropertyListingController : Controller
    {
        public IActionResult ListAll()
        {
            return View("ListProperties", properties);
        }

        public IActionResult ListAvailable(DateTime start, DateTime end)
        {
            return View("ListProperties", properties);
        }

        [HttpGet]
        public IActionResult ViewPropertyDetails(int id) 
        {
            var model = properties.Where(p => p.Id == id).First();
            return View("PropertyDetails", model);
        }

        private static List<PropertyDetailsModel> properties = new()
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
                Amenities = new List<string>{"WiFi", "Bath", "Good view"},
                BookedDates = null,
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
                Amenities = new List<string>{ "Bath", "Good view"},
                BookedDates = new List<DateTime>{DateTime.Now, new DateTime(2023, 12, 31)},
            },
        };
    }
}
