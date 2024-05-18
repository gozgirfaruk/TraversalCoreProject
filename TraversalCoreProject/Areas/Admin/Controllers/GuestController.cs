using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
