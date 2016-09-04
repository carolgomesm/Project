using MedChartApp.Models;
using MedChartApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedChartApp.Controllers
{
    public class BloodWorkController : Controller
    {
        private ApplicationDbContext _context;

        public BloodWorkController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var result = _context.BloodWork;

            return View(result);
        }

        public ActionResult Details(int id)
        {
            var result = _context.BloodWork.SingleOrDefault(c => c.Id == id);

            if (result == null) return HttpNotFound();

            return View(result);
        }               
    }
}