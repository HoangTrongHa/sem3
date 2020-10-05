using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirthWebApplication.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        [Required]
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="00:dd-MM-yyyy",ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
    }
}