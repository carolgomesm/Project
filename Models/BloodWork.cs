using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("Exam Date")]
        public DateTime ExamDate { get; set; }

        [Required]
       [ DisplayName("Result Date")]
        public DateTime ResultDate { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Hemoglobin { get; set; }

        [Required]
        public double Hematocrit { get; set; }

        [Required]
        [DisplayName("White Blood Cell ")]
        public double WhiteBloodCellCount { get; set; }

        [Required]
        [DisplayName("Red Blood Cell ")]
        public double RedBloodCellCount { get; set; }

        [Required]
        public double MCV { get; set; }

        [Required]
        public double MCHC { get; set; }

        [Required]
        public double RDW { get; set; }

        [Required]
        [DisplayName("Patelet ")]
        public double PlateletCount { get; set; }
    }

  
}