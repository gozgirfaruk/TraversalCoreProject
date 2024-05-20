using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents._AdminDashboardComponent
{
    public class _BannerStatisticPartial : ViewComponent
    {
        private readonly IDestinationService _destinationService;
        private readonly IGuideService _guideService;

        public _BannerStatisticPartial(IDestinationService destinationService, IGuideService guideService)
        {
            _destinationService = destinationService;
            _guideService = guideService;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.one = _destinationService.GetAll().Count();
            ViewBag.two = _guideService.GetAll().Count();   
            return View();
        }
    }
}
