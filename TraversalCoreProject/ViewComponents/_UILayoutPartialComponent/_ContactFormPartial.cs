using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents._UILayoutPartialComponent
{
    public class _ContactFormPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
