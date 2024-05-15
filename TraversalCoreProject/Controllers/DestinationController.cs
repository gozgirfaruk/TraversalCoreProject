using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationMenager _destMenager = new DestinationMenager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = _destMenager.GetAll();
            return View(values);
        }

        public IActionResult Details(int id)
        {
            var values = _destMenager.GetbyId(id);
            //ViewBag.c = values.CoverImage1.ToString();
            ViewBag.ID = id;
            return View(values);

        }
    }
}
