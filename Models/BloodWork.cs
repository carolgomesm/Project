using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MedChartApp.Models
{
    public class BloodWork
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime ExamDate { get; set; }
        public DateTime ResultDate { get; set; }
        public string Description { get; set; }
        public double Hemoglobin { get; set; }
        public double Hematocrit { get; set; }
        public double WhiteBloodCellCount { get; set; }
        public double RedBloodCellCount { get; set; }
        public double MCV { get; set; }
        public double MCHC { get; set; }
        public double RDW { get; set; }
        public double PlateletCount { get; set; }
    }

  
}