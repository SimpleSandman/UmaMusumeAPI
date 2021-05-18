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
    public class SingleModeOutingController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeOutingController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeOuting
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeOuting>>> GetSingleModeOutings()
        {
            return await _context.SingleModeOutings.ToListAsync();
        }

        // GET: api/SingleModeOuting/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeOuting>> GetSingleModeOuting(int id)
        {
            var singleModeOuting = await _context.SingleModeOutings.FindAsync(id);

            if (singleModeOuting == null)
            {
                return NotFound();
            }

            return singleModeOuting;
        }

        // PUT: api/SingleModeOuting/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeOuting(int id, SingleModeOuting singleModeOuting)
        {
            if (id != singleModeOuting.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeOuting).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeOutingExists(id))
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

        // POST: api/SingleModeOuting
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeOuting>> PostSingleModeOuting(SingleModeOuting singleModeOuting)
        {
            _context.SingleModeOutings.Add(singleModeOuting);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeOutingExists(singleModeOuting.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeOuting", new { id = singleModeOuting.Id }, singleModeOuting);
        }

        // DELETE: api/SingleModeOuting/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeOuting(int id)
        {
            var singleModeOuting = await _context.SingleModeOutings.FindAsync(id);
            if (singleModeOuting == null)
            {
                return NotFound();
            }

            _context.SingleModeOutings.Remove(singleModeOuting);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeOutingExists(int id)
        {
            return _context.SingleModeOutings.Any(e => e.Id == id);
        }
    }
}
