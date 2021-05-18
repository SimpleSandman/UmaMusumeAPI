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
    public class SingleModeEventProductionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeEventProductionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeEventProduction
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeEventProduction>>> GetSingleModeEventProductions()
        {
            return await _context.SingleModeEventProductions.ToListAsync();
        }

        // GET: api/SingleModeEventProduction/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeEventProduction>> GetSingleModeEventProduction(int id)
        {
            var singleModeEventProduction = await _context.SingleModeEventProductions.FindAsync(id);

            if (singleModeEventProduction == null)
            {
                return NotFound();
            }

            return singleModeEventProduction;
        }

        // PUT: api/SingleModeEventProduction/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeEventProduction(int id, SingleModeEventProduction singleModeEventProduction)
        {
            if (id != singleModeEventProduction.StoryId)
            {
                return BadRequest();
            }

            _context.Entry(singleModeEventProduction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeEventProductionExists(id))
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

        // POST: api/SingleModeEventProduction
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeEventProduction>> PostSingleModeEventProduction(SingleModeEventProduction singleModeEventProduction)
        {
            _context.SingleModeEventProductions.Add(singleModeEventProduction);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeEventProductionExists(singleModeEventProduction.StoryId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeEventProduction", new { id = singleModeEventProduction.StoryId }, singleModeEventProduction);
        }

        // DELETE: api/SingleModeEventProduction/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeEventProduction(int id)
        {
            var singleModeEventProduction = await _context.SingleModeEventProductions.FindAsync(id);
            if (singleModeEventProduction == null)
            {
                return NotFound();
            }

            _context.SingleModeEventProductions.Remove(singleModeEventProduction);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeEventProductionExists(int id)
        {
            return _context.SingleModeEventProductions.Any(e => e.StoryId == id);
        }
    }
}
