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

        public JsonResult GetCharWhiteBloodCell()
        {
            var chart = _context.BloodWork.Select(a => new { a.WhiteBloodCellCount, a.ResultDate }).ToList();

            return Json(chart, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCharRedBloodCell()
        {
            var chart = _context.BloodWork.Select(a => new { a.RedBloodCellCount, a.ResultDate }).ToList();

            return Json(chart, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCharMCV()
        {
            var chart = _context.BloodWork.Select(a => new { a.MCV, a.ResultDate }).ToList();

            return Json(chart, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCharMCHC()
        {
            var chart = _context.BloodWork.Select(a => new { a.MCHC, a.ResultDate }).ToList();

            return Json(chart, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCharRDW()
        {
            var chart = _context.BloodWork.Select(a => new { a.RDW, a.ResultDate }).ToList();

            return Json(chart, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCharPlateletCount()
        {
            var chart = _context.BloodWork.Select(a => new { a.PlateletCount, a.ResultDate }).ToList();

            return Json(chart, JsonRequestBehavior.AllowGet);
        }




    }
}