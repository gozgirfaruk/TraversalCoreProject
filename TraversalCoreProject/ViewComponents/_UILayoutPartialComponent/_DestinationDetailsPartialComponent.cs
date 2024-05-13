using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents._UILayoutPartialComponent
{
    public class _DestinationDetailsPartialComponent : ViewComponent
    {
        DestinationMenager _destMenager=new DestinationMenager(new EfDestinationDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = _destMenager.GetbyId(id);
            return View(values);
        }
    }
}
