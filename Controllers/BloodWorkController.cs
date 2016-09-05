using MedChartApp.Models;
using MedChartApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
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

        public ActionResult New()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Save(BloodWork bloodWork)
        {

            if (bloodWork.Id == 0)
            {
                bloodWork.DateCreated = DateTime.UtcNow;
                _context.BloodWork.Add(bloodWork);
            }
            else
            {
                var bloodWorkInDb = _context.BloodWork.Single(b => b.Id == bloodWork.Id);

                //Update each field
                bloodWorkInDb.ExamDate = bloodWork.ExamDate;
                bloodWorkInDb.ResultDate = bloodWork.ResultDate;
                bloodWorkInDb.Description = bloodWork.Description;
                bloodWorkInDb.Hematocrit = bloodWork.Hematocrit;
                bloodWorkInDb.Hemoglobin = bloodWork.Hemoglobin;
                bloodWorkInDb.MCV = bloodWork.MCV;
                bloodWorkInDb.MCHC = bloodWork.MCHC;
                bloodWorkInDb.RDW = bloodWork.RDW;
                bloodWorkInDb.WhiteBloodCellCount = bloodWork.WhiteBloodCellCount;
                bloodWorkInDb.RedBloodCellCount = bloodWork.RedBloodCellCount;
                bloodWorkInDb.PlateletCount = bloodWork.PlateletCount;

            }

           
                _context.SaveChanges();

            return RedirectToAction("Index", "BloodWork");
        }

        //GET : /Cursos/Delete/
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BloodWork result = _context.BloodWork.Find(id);
            if (result == null)
            {
                return HttpNotFound();
            }

            return View("ConfirmDelete");
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult ConfirmDelete(int id, BloodWork result)
        {
            result = _context.BloodWork.Find(id);

            if (result == null) return HttpNotFound();

            _context.BloodWork.Remove(result);
            _context.SaveChanges();

            return RedirectToAction("Index", "BloodWork");
        }

        public ActionResult Edit(int id)
        {
            var result = _context.BloodWork.SingleOrDefault(c => c.Id == id);

            if (result == null) return HttpNotFound();

            return View("New",  result);
        }

    }
}