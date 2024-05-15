using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Controllers
{
    
    
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signinMenager;

        public LoginController(SignInManager<AppUser> signinMenager)
        {
            _signinMenager = signinMenager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel userLogin)
        {
            if(ModelState.IsValid)
            {
                var result = await _signinMenager.PasswordSignInAsync(userLogin.UserName, userLogin.Password,false,false);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Profile",new {area="Member"});   
                }
                else
                {
                    ModelState.AddModelError("", "Hatalı Kullanıcı Adı Veya Şifre");
                }
            }
            return View();  
        }
    }
}
