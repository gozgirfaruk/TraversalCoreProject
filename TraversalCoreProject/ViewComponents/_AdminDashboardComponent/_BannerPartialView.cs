using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents._AdminDashboardComponent
{
    public class _BannerPartialView : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _BannerPartialView(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Name = values.FirstName + " " + values.LastName;
            return View();
        }
    }
}
