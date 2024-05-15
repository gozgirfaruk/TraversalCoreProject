using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Areas.Member.Models;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEdit = new UserEditViewModel()
            {
                FirstName = values.FirstName,
                LastName = values.LastName,
                Mail = values.Email

            };
            return View(userEdit);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userEdit)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if(userEdit != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(userEdit.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/userimage/" + imagename;
                var stream = new FileStream(savelocation,FileMode.Create);
                await userEdit.Image.CopyToAsync(stream);
                user.ImageUrl = imagename;
            }

            user.FirstName = userEdit.FirstName;
            user.LastName=userEdit.LastName;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEdit.Password);
            var result = await _userManager.UpdateAsync(user);
            if(result.Succeeded)
            {
                return RedirectToAction("Index","Login");
            }
            return View();
        }
    }
}
