using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        DestinationMenager _destination = new DestinationMenager(new EfDestinationDal());
        ReservationMenager _reservation = new ReservationMenager(new EfReservationDal());



        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in _destination.GetAll()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.DestinationID.ToString()
                                           }).ToList();

            ViewBag.v = values;

            return View();
        }
        [HttpPost]
        public IActionResult NewReservation(Reservation reservation)
        {
            reservation.AppUserID = 3;
            reservation.Status = "Onaylanmadı";
            _reservation.TInsert(reservation);
            return RedirectToAction("Index","Profile"); 
        }
    }
}
