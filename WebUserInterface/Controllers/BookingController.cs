using Microsoft.AspNetCore.Mvc;
using WebUserInterface.Models;

namespace WebUserInterface.Controllers
{
    public class BookingController : Controller
    {
        [HttpPost]
        public IActionResult Book(BookedDateModel date)
        {
            var res = date;
            return View();
        }
    }
}
