using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class NewsLetterSenderController : Controller
    {
        private readonly INewsLetterService _letterService;

        public NewsLetterSenderController(INewsLetterService letterService)
        {
            _letterService = letterService;
        }
        [HttpPost]
        public IActionResult Index(NewsLetter letter)
        {
            _letterService.TInsert(letter);
            return RedirectToAction("Index","Default");
        }
    }
}
