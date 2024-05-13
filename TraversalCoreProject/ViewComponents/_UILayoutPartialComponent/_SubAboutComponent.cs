using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents._UILayoutPartialComponent
{
    public class _SubAboutComponent : ViewComponent
    {
        SubAboutMenager subMenager = new SubAboutMenager(new EfSubAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = subMenager.GetAll();
            return View(values);
        }
    }
}
