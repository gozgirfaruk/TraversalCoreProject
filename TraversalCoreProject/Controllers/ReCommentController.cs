using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class ReCommentController : Controller
    {
        ReCommentMenager _commentMenager = new ReCommentMenager(new EfReCommentDal(new DataAccessLayer.Context.TreversalContext()));
        
        
        [HttpGet]
        public PartialViewResult AddComment(int id)
        {
             ViewBag.Id = id;   
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(ReComment comment)
        {
            comment.Date=Convert.ToDateTime(DateTime.Now.ToShortDateString());
            comment.Status = false;
            _commentMenager.TInsert(comment);
            return RedirectToAction("Index", "Destination");
        }
    }
}
