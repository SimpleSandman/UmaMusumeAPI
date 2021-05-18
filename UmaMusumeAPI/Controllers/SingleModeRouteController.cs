using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Tables;

namespace UmaMusumeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingleModeRouteController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeRouteController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeRoute
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeRoute>>> GetSingleModeRoutes()
        {
            return await _context.SingleModeRoutes.ToListAsync();
        }

        // GET: api/SingleModeRoute/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeRoute>> GetSingleModeRoute(int id)
        {
            var singleModeRoute = await _context.SingleModeRoutes.FindAsync(id);

            if (singleModeRoute == null)
            {
                return NotFound();
            }

            return singleModeRoute;
        }

        // PUT: api/SingleModeRoute/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeRoute(int id, SingleModeRoute singleModeRoute)
        {
            if (id != singleModeRoute.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeRoute).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeRouteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/SingleModeRoute
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeRoute>> PostSingleModeRoute(SingleModeRoute singleModeRoute)
        {
            _context.SingleModeRoutes.Add(singleModeRoute);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeRouteExists(singleModeRoute.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeRoute", new { id = singleModeRoute.Id }, singleModeRoute);
        }

        // DELETE: api/SingleModeRoute/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeRoute(int id)
        {
            var singleModeRoute = await _context.SingleModeRoutes.FindAsync(id);
            if (singleModeRoute == null)
            {
                return NotFound();
            }

            _context.SingleModeRoutes.Remove(singleModeRoute);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeRouteExists(int id)
        {
            return _context.SingleModeRoutes.Any(e => e.Id == id);
        }
    }
}
