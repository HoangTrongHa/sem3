using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirthWebApplication.Models
{
    public class Deparment
    {
        public int Id { get; set; }
        [StringLength(50,MinimumLength =6)]
        public string Name { set; get; }

        public DateTime StartDate { get; set; }
        
        public virtual ICollection<Cource> Cources { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}