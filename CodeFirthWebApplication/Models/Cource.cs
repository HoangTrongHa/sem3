using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirthWebApplication.Models
{
    public class Cource
    {
        public int CourceID { get; set; }
        public string Title { get; set; }
        public int Creadits { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }

    }
}