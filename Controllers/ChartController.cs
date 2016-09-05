using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MedChartApp.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace MedChartApp.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        private ApplicationDbContext _context;

        public ChartController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public JsonResult GetChart()
        {
            var chart = _context.BloodWork.Select(a => new {  a.Hemoglobin,  a.ResultDate }).ToList();
            
            return Json(chart, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCharHematocrit()
        {
            var chart = _context.BloodWork.Select(a => new { a.Hematocrit, a.ResultDate }).ToList();

            return Json(chart, JsonRequestBehavior.AllowGet);
        }




    }
}