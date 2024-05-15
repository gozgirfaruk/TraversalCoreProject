using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        DestinationMenager _destination = new DestinationMenager(new EfDestinationDal());
        ReservationMenager _reservation = new ReservationMenager(new EfReservationDal());
        private readonly UserManager<AppUser> _userMenager;

        public ReservationController(UserManager<AppUser> userMenager)
        {
            _userMenager = userMenager;
        }

        public IActionResult MyReservation()
        {
            return View();
        }

        public IActionResult OldestReservation()
        {
            return View();
        }

        public async Task<IActionResult> MyApprovalReservation()
        {
            var values = await _userMenager.FindByNameAsync(User.Identity.Name);
            var valueList= _reservation.GetbyListAppUser(values.Id);
            return View(valueList);
        }



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
            reservation.Status = "Onay Bekliyor";
            _reservation.TInsert(reservation);
            return RedirectToAction("Index", "Profile");
        }
    }
}
