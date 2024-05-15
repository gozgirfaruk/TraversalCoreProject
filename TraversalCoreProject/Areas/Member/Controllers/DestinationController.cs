using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationMenager destMenager = new DestinationMenager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = destMenager.GetAll();
            return View(values);
        }
    }
}
