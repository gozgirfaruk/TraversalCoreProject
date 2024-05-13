﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class DestinationController : Controller
    {
        DestinationMenager _destMenager = new DestinationMenager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = _destMenager.GetAll();
            return View(values);
        }

        public IActionResult Details(int id)
        {
            var values = _destMenager.GetbyId(id);  
            return View(values);

        }
    }
}
