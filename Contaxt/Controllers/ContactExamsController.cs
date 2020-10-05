using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Contaxt.Models;

namespace Contaxt.Controllers
{
    public class ContactExamsController : Controller
    {
        private practice3Entities db = new practice3Entities();

        // GET: ContactExams
        public async Task<ActionResult>  Index(string searchString)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                var name = from s in db.ContactExams select s;

                name = name.Where(s => s.name.Contains(searchString));
            }

            return View(db.ContactExams.ToList());
        }

        
         

        // GET: ContactExams/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactExam contactExam = db.ContactExams.Find(id);
            if (contactExam == null)
            {
                return HttpNotFound();
            }
            return View(contactExam);
        }

        // GET: ContactExams/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactExams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,phone,groupname,dateofhire,dateofbirth")] ContactExam contactExam)
        {
            if (ModelState.IsValid)
            {
                db.ContactExams.Add(contactExam);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contactExam);
        }

        // GET: ContactExams/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactExam contactExam = db.ContactExams.Find(id);
            if (contactExam == null)
            {
                return HttpNotFound();
            }
            return View(contactExam);
        }

        // POST: ContactExams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,phone,groupname,dateofhire,dateofbirth")] ContactExam contactExam)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contactExam).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contactExam);
        }

        // GET: ContactExams/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactExam contactExam = db.ContactExams.Find(id);
            if (contactExam == null)
            {
                return HttpNotFound();
            }
            return View(contactExam);
        }

        // POST: ContactExams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContactExam contactExam = db.ContactExams.Find(id);
            db.ContactExams.Remove(contactExam);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
