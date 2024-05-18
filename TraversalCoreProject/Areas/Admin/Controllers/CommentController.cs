using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class CommentController : Controller
    {
        private readonly IReCommentService _reCommentService;

        public CommentController(IReCommentService reCommentService)
        {
            _reCommentService = reCommentService;
        }

        public IActionResult CommentList()
        {
            var values = _reCommentService.GetListWithCity();
            return View(values);
        }

        public IActionResult Delete(int id)
        {
            var values = _reCommentService.GetbyId(id); 
            _reCommentService.TDelete(values);
            return RedirectToAction("CommentList","Comment");
        }
    }
}
