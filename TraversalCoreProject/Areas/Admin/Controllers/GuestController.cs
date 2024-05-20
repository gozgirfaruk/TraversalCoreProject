using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuestController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IAppUserService _appuserService;

        public GuestController(UserManager<AppUser> userManager, IAppUserService appuserService)
        {
            _userManager = userManager;
            _appuserService = appuserService;
        }

        public IActionResult Index()
        {
            var values = _appuserService.GetAll();
            return View(values);
        }
    }
}
