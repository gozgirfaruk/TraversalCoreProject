﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents._UILayoutPartialComponent
{
    public class _DestinationCommentListPartial : ViewComponent
    {
        ReCommentMenager recommentMenager = new ReCommentMenager(new EfReCommentDal(new DataAccessLayer.Context.TreversalContext()));
        public IViewComponentResult Invoke(int id)
        {
            var values = recommentMenager.TGetListByFilter(id);
            ViewBag.a = values.Count();
            return View(values);
        }
    }
}
