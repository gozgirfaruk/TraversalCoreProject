using BusinessLayer.Abstract;
using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Reservation")]
    public class ReservationController : Controller
    {
        private readonly IReservationService _reservationService;
        TreversalContext _context = new TreversalContext();

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }
        [Route("Index")]
        public IActionResult Index()
        {
            var values = _reservationService.TListAllAproval();

            return View(values);
        }
    }
}
