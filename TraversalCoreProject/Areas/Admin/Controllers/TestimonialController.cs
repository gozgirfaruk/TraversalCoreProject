using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Testimonial/")]
    public class TestimonialController : Controller
    {
        private readonly ITestimonialService _testimonialService;
        

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [Route("TestList")]
        public IActionResult TestList()
        {
            var values = _testimonialService.GetAll();
            return View(values);
        }

        [Route("StatusChanegerToFalse/{id}")]
        public IActionResult StatusChanegerToFalse(int id)
        {
            _testimonialService.TStatusChangeFalse(id);
            return RedirectToAction("TestList", "Testimonial");
        }

        [Route("StatusChangerToTrue/{id}")]
        public IActionResult StatusChangerToTrue(int id)
        {
            _testimonialService.TStatusChangeTrue(id);
            return RedirectToAction("TestList", "Testimonial");
        }

        [HttpGet]
        [Route("UpdateTest/{id}")]
        public IActionResult UpdateTest(int id)
        {
            var values = _testimonialService.GetbyId(id);
            return View(values);
        }

        [HttpPost]
        [Route("UpdateTest/{testimonial}")]
        public IActionResult UpdateTest(Testimonial testimonial)
        {
            testimonial.Status = true;
            testimonial.Comment = "a";
            _testimonialService.TUpdate(testimonial);
            return RedirectToAction("TestList", "Testimonial");
        }
    }
}
