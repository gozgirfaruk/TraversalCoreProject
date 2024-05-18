using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult DestinationList()
        {
            var values = _destinationService.GetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult NewDestination()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewDestination(Destination destination)
        {
            destination.Status = true;
            _destinationService.TInsert(destination);
            return RedirectToAction("DestinationList","Destination" , new {area ="Admin"});
        }

        public IActionResult DeleteDestination(int id)
        {
            var values = _destinationService.GetbyId(id);
            _destinationService.TDelete(values);
            return RedirectToAction("DestinationList");
        }
        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var values = _destinationService.GetbyId(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateDestination(Destination destination)
        {
            _destinationService.TUpdate(destination);
            return RedirectToAction("DestinationList", "Destination", new { area = "Admin" });
        }

    }
}
