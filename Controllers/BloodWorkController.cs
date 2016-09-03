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
        // GET: BloodWork
        public ViewResult Index()
        {
            var result = GetBloodWork();

            return View(result);
        }

        public ActionResult Details(int id)
        {
            var result = GetBloodWork().SingleOrDefault(c => c.Id == id);

            if (result == null) return HttpNotFound();

            return View(result);
        }

        private IEnumerable<BloodWork> GetBloodWork()
        {
            return new List<BloodWork>
            {
                 new BloodWork {
                     Id = 1,
                    DateCreated = DateTime.UtcNow,
                    ExamDate = new DateTime(2016, 7, 20),
                    ResultDate = new DateTime(2016, 8, 10),
                    Description = "My First Blood Test",
                    Hematocrit = 3.0,
                    Hemoglobin = 30.9,
                    WhiteBloodCellCount = 3,
                    RedBloodCellCount = 10,
                    MCV = 3,
                    MCHC = 6,
                    RDW = 4,
                    PlateletCount = 10
                },

                 new BloodWork {
                     Id = 2,
                    DateCreated = DateTime.UtcNow,
                    ExamDate = new DateTime(2016, 7, 20),
                    ResultDate = new DateTime(2016, 8, 10),
                    Description = "My Second Blood Test",
                    Hematocrit = 3.0,
                    Hemoglobin = 30.9,
                    WhiteBloodCellCount = 3,
                    RedBloodCellCount = 10,
                    MCV = 3,
                    MCHC = 6,
                    RDW = 4,
                    PlateletCount = 10
                }

            };
        }
    }
}