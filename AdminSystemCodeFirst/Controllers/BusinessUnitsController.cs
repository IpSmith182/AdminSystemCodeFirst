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
using AdminSystemCodeFirst.Models;

namespace AdminSystemCodeFirst.Controllers
{
    public class BusinessUnitsController : ApiController
    {
        private AdminSystemCodeFirstContext db = new AdminSystemCodeFirstContext();

        // GET: api/BusinessUnits
        public IQueryable<BusinessUnit> GetBusinessUnits()
        {
            return db.BusinessUnits;
        }

        // GET: api/BusinessUnits/5
        [ResponseType(typeof(BusinessUnit))]
        public async Task<IHttpActionResult> GetBusinessUnit(int id)
        {
            BusinessUnit businessUnit = await db.BusinessUnits.FindAsync(id);
            if (businessUnit == null)
            {
                return NotFound();
            }

            return Ok(businessUnit);
        }

        // PUT: api/BusinessUnits/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutBusinessUnit(int id, BusinessUnit businessUnit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != businessUnit.businessUnitId)
            {
                return BadRequest();
            }

            db.Entry(businessUnit).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BusinessUnitExists(id))
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

        // POST: api/BusinessUnits
        [ResponseType(typeof(BusinessUnit))]
        public async Task<IHttpActionResult> PostBusinessUnit(BusinessUnit businessUnit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.BusinessUnits.Add(businessUnit);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = businessUnit.businessUnitId }, businessUnit);
        }

        // DELETE: api/BusinessUnits/5
        [ResponseType(typeof(BusinessUnit))]
        public async Task<IHttpActionResult> DeleteBusinessUnit(int id)
        {
            BusinessUnit businessUnit = await db.BusinessUnits.FindAsync(id);
            if (businessUnit == null)
            {
                return NotFound();
            }

            db.BusinessUnits.Remove(businessUnit);
            await db.SaveChangesAsync();

            return Ok(businessUnit);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BusinessUnitExists(int id)
        {
            return db.BusinessUnits.Count(e => e.businessUnitId == id) > 0;
        }
    }
}