using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirthWebApplication.Models
{
    public enum Grade
    {
        A,B,C,D
    }
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public Grade? getGrade { get; set; } 
        public int StudentId { get; set; }
        public int CourceId { get; set; }
        public virtual Student GetStudent { get; set; }
        public virtual Cource GetCource { get; set; }
    }
}