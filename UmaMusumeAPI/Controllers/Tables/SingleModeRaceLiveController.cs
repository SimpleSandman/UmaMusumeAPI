using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Tables;

namespace UmaMusumeAPI.Controllers.Tables
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingleModeRaceLiveController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeRaceLiveController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeRaceLive
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeRaceLive>>> GetSingleModeRaceLives()
        {
            return await _context.SingleModeRaceLives.ToListAsync();
        }

        // GET: api/SingleModeRaceLive/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeRaceLive>> GetSingleModeRaceLive(int id)
        {
            var singleModeRaceLive = await _context.SingleModeRaceLives.FindAsync(id);

            if (singleModeRaceLive == null)
            {
                return NotFound();
            }

            return singleModeRaceLive;
        }

        // PUT: api/SingleModeRaceLive/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeRaceLive(int id, SingleModeRaceLive singleModeRaceLive)
        {
            if (id != singleModeRaceLive.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeRaceLive).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeRaceLiveExists(id))
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

        // POST: api/SingleModeRaceLive
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeRaceLive>> PostSingleModeRaceLive(SingleModeRaceLive singleModeRaceLive)
        {
            _context.SingleModeRaceLives.Add(singleModeRaceLive);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeRaceLiveExists(singleModeRaceLive.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeRaceLive", new { id = singleModeRaceLive.Id }, singleModeRaceLive);
        }

        // DELETE: api/SingleModeRaceLive/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeRaceLive(int id)
        {
            var singleModeRaceLive = await _context.SingleModeRaceLives.FindAsync(id);
            if (singleModeRaceLive == null)
            {
                return NotFound();
            }

            _context.SingleModeRaceLives.Remove(singleModeRaceLive);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeRaceLiveExists(int id)
        {
            return _context.SingleModeRaceLives.Any(e => e.Id == id);
        }
    }
}
