using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace MedChartApp.Models
{
    public class DatesResultAndExam : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
           
                var date = (BloodWork) context.ObjectInstance;

            if (date.ExamDate > date.ResultDate)
            {
                return new ValidationResult("The exam date should be less than the result date");
         
            }
            else
            {
                return ValidationResult.Success;
            }

        }

    }
}