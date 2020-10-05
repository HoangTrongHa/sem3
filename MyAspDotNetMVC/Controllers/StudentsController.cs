using MyAspDotNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyAspDotNetMVC.Controllers
{
    public class StudentsController : Controller
    {// step1
        // GET: Students
        static IList<Student> studentList = new List<Student>
        {
            new Student(){StudentId = 1,Name = "Hoang Van Tu",Age = 20},
            new Student(){StudentId = 2,Name = "Hoang Van Huy",Age = 19},
            new Student(){StudentId = 3,Name = "Hoang Van Ha",Age = 18},
            new Student(){StudentId = 4,Name = "Dau cat moi",Age = 17},
            new Student(){StudentId = 5,Name = "Hoang Trong Ha",Age = 16},
            new Student(){StudentId = 6,Name = "Nghiem Van Manh",Age = 15},
            new Student(){StudentId = 7,Name = "Pham Thi Thanh Loan",Age = 14}
        };
        public ActionResult Index()
        {
            //3 step
            //1 nhan request
            //2 call model
            //3 return view

            //3
            return View(studentList.OrderBy(s => s.StudentId).ToList());
        }
        public ActionResult Edit(int Id)
        {
            var std = studentList.Where(s => s.StudentId == Id).FirstOrDefault();
            return View(std);

        }
        [HttpPost]
        public ActionResult Edit(Student std)
        {
            var Student = studentList.Where(s => s.StudentId == std.StudentId).FirstOrDefault();
            studentList.Remove(Student);
            studentList.Add(std);
            return RedirectToAction("Index");
        }  
        [HttpDelete]
        public ActionResult Delete(int Id)
        {
            var Student = studentList.Where(s => s.StudentId == Id).FirstOrDefault();
            studentList.Remove(Student);
         
            return RedirectToAction("Index");
        }
    }
}