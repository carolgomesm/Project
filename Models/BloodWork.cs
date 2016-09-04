using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedChartApp.Models
{
    public class BloodWork
    {
        public int Id { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        [Required]
        public DateTime ExamDate { get; set; }

        [Required]
        public DateTime ResultDate { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Hemoglobin { get; set; }

        [Required]
        public double Hematocrit { get; set; }

        [Required]
        public double WhiteBloodCellCount { get; set; }

        [Required]
        public double RedBloodCellCount { get; set; }

        [Required]
        public double MCV { get; set; }

        [Required]
        public double MCHC { get; set; }

        [Required]
        public double RDW { get; set; }

        [Required]
        public double PlateletCount { get; set; }
    }

  
}