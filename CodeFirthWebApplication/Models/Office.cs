using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirthWebApplication.Models
{
    public class Office
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}