using BigSchool1.Models;
using BigShool1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigShool1.ViewModel
{
    public class CourseViewModel
    {
        [Require]
        public string Placce { get; set; }
        [Require]
        [futureDate]
        public string Date { get; set; }
        [Require]
        [ValidTime]
        public string Time { get; set; }
        [Require]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string Place { get; internal set; }

        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}