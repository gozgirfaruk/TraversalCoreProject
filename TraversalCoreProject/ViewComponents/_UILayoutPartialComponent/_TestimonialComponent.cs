using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents._UILayoutPartialComponent
{
    public class _TestimonialComponent : ViewComponent
    {
        TestimonialMenager testimonialMenager = new TestimonialMenager(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = testimonialMenager.GetAll();
            return View(values);
        }
    }
}
