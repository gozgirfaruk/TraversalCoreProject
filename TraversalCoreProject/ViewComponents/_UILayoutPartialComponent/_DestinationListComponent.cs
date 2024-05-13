using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents._UILayoutPartialComponent
{
    public class _DestinationListComponent : ViewComponent
    {
        DestinationMenager destinationMenager = new DestinationMenager(new EfDestinationDal());

        public IViewComponentResult Invoke()
        {
            var values = destinationMenager.GetAll().Take(8).ToList();
            return View(values);
        }
    }
}
