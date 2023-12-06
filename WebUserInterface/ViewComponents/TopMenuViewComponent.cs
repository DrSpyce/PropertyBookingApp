using Microsoft.AspNetCore.Mvc;

namespace WebUserInterface.ViewComponents
{
    public class TopMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
