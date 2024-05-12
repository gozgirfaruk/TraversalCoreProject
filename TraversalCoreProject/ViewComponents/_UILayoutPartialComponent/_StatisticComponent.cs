using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents._UILayoutPartialComponent
{
    public class _StatisticComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var context = new TreversalContext();
            ViewBag.a = context.Destinations.Count();
            ViewBag.b =context.Guides.Count();
            ViewBag.c = "150";
            return View();
        }
    }
}
