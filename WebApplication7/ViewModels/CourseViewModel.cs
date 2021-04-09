using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public string Place { set; get; }
        [Required]
        [FutureDate]
        public string Date { set; get; }
        [Required]
        [ValidTime]
        public string Time { set; get; }
        [Required]
        public byte Category { set; get; }
        public IEnumerable<Category> Categories { set; get; }
        public DateTime GetDateTime()
        {
            string D = Date;
            string S = Time;
            return DateTime.ParseExact(D, "dd/M/yyyy",
                CultureInfo.InvariantCulture);
        }
    }
}