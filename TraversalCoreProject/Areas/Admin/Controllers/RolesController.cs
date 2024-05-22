using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Areas.Admin.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class RolesController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RolesController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleModelView model)
        {
            AppRole role = new AppRole()
            {
                Name = model.RoleName
            };
            var result = await _roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Roles");
            }
            return View();
        }

        [Route("{id}")]
        public async Task<IActionResult> DeleteRole(int id)
        {
            var value = _roleManager.Roles.FirstOrDefault(x=>x.Id == id);
            await _roleManager.DeleteAsync(value);
            return RedirectToAction("Index", "Roles");
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult UpdateRole(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x=>x.Id==id);
            UpdateRoleViewModel model = new UpdateRoleViewModel
            {
                RoleID = values.Id,
                RoleName = values.Name
            };
            return View(model);

        }
        [HttpPost]
        [Route("UpdateRole")]
        public async Task<IActionResult> UpdateRole(UpdateRoleViewModel model)
        {
            var values = _roleManager.Roles.FirstOrDefault(x=>x.Id==model.RoleID);
            await _roleManager.UpdateAsync(values);
            return RedirectToAction("Index","Roles");
        }
    }
}
