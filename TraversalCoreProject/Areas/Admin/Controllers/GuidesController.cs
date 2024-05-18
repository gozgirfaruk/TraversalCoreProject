using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuidesController : Controller
    {
        private readonly IGuideService _guideService;

        public GuidesController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult GuideList()
        {
            var values = _guideService.GetAll();
            return View(values);
        }

        public IActionResult DeleteGuide(int id)
        {
            var values = _guideService.GetbyId(id);
            _guideService.TDelete(values);
            return RedirectToAction("GuideList","Guides");
        }

        [HttpGet]
        public IActionResult UpdateGuide(int id)
        {
            var values = _guideService.GetbyId(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateGuide(Guide guide)
        {
            _guideService.TUpdate(guide);
            return RedirectToAction("GuideList");
        }

    }
}
