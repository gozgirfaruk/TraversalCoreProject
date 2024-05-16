using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Member.ViewComponents
{
    public class _GuideListPartialComponent : ViewComponent
    {

        GuideMenager _guideMenager = new GuideMenager(new EfGuideDal());

        public IViewComponentResult Invoke()
        {
            var values = _guideMenager.GetAll();
            return View(values);
        }
    }
}
