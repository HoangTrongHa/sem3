using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyAspDotNetMVC.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Display(Name = "Hoang Trong Ha")]
        public String Name { get; set; }
        public int Age { get; set; }
    }
}