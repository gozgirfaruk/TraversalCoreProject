using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Guides")]
    public class GuidesController : Controller
    {
        private readonly IGuideService _guideService;

        public GuidesController(IGuideService guideService)
        {
            _guideService = guideService;
        }
        [Route("GuideList")]
        public IActionResult GuideList()
        {
            var values = _guideService.GetAll();
            return View(values);
        }
        [Route("DeleteGuide")]
        public IActionResult DeleteGuide(int id)
        {
            var values = _guideService.GetbyId(id);
            _guideService.TDelete(values);
            return RedirectToAction("GuideList");
        }
        [Route("UpdateGuide/{id}")]
        [HttpGet]
        public IActionResult UpdateGuide(int id)
        {
            var values = _guideService.GetbyId(id);
            return View(values);
        }
        [Route("UpdateGuide")]
        [HttpPost]
        public IActionResult UpdateGuide(Guide guide)
        {
            _guideService.TUpdate(guide);
            return RedirectToAction("GuideList");
        }

    

    }
}
