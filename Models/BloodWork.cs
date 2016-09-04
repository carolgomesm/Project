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
        [DisplayName("Result Date")]
        public DateTime ResultDate { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Range(120, 180)]
        public double Hemoglobin { get; set; }

        [Required]
        [Range(0.370, 0.500)]
        public double Hematocrit { get; set; }

        [Required]
        [Range(4, 10)]
        [DisplayName("White Blood Cell ")]
        public double WhiteBloodCellCount { get; set; }

        [Required]
        [DisplayName("Red Blood Cell ")]
        [Range(4, 10)]
        public double RedBloodCellCount { get; set; }

        [Required]
        [Range(80, 95)]
        public double MCV { get; set; }

        [Required]
        [Range(80, 95)]
        public double MCHC { get; set; }

        [Required]
        public double RDW { get; set; }

        [Required]
        [DisplayName("Patelet ")]
        [Range(150,400)]
        public double PlateletCount { get; set; }
    }

  
}