using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using mySeviceAplication.Areas.HelpPage.Models;

namespace mySeviceAplication.Areas.HelpPage.Controllers
{
    public class CourcesController : ApiController
    {
        private AptechContext db = new AptechContext();

        // GET: api/Cources
        public IQueryable<Cource> GetCources()
        {
            return db.Cources;
        }

        // GET: api/Cources/5
        [ResponseType(typeof(Cource))]
        public async Task<IHttpActionResult> GetCource(int id)
        {
            Cource cource = await db.Cources.FindAsync(id);
            if (cource == null)
            {
                return NotFound();
            }

            return Ok(cource);
        }

        // PUT: api/Cources/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCource(int id, Cource cource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cource.CourceID)
            {
                return BadRequest();
            }

            db.Entry(cource).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Cources
        [ResponseType(typeof(Cource))]
        public async Task<IHttpActionResult> PostCource(Cource cource)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Cources.Add(cource);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = cource.CourceID }, cource);
        }

        // DELETE: api/Cources/5
        [ResponseType(typeof(Cource))]
        public async Task<IHttpActionResult> DeleteCource(int id)
        {
            Cource cource = await db.Cources.FindAsync(id);
            if (cource == null)
            {
                return NotFound();
            }

            db.Cources.Remove(cource);
            await db.SaveChangesAsync();

            return Ok(cource);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CourceExists(int id)
        {
            return db.Cources.Count(e => e.CourceID == id) > 0;
        }
    }
}