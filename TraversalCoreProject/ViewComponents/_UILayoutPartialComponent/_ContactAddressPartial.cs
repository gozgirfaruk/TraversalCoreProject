using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents._UILayoutPartialComponent
{
    public class _ContactAddressPartial : ViewComponent
    {
        private readonly IAddressService _addressService;

        public _ContactAddressPartial(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _addressService.GetAll();
            return View(values);
        }
    }
}
