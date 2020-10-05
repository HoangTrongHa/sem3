using CodeFirthWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirthWebApplication.DAL
{
    public class FptAptechContex : DbContext
    {
        public FptAptechContex() : base("FptContext")
        {
          
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Cource> Cources { get; set; }
    }
}