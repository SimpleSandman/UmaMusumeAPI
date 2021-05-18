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
    public class SingleModeProgramController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeProgramController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeProgram
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeProgram>>> GetSingleModePrograms()
        {
            return await _context.SingleModePrograms.ToListAsync();
        }

        // GET: api/SingleModeProgram/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeProgram>> GetSingleModeProgram(int id)
        {
            var singleModeProgram = await _context.SingleModePrograms.FindAsync(id);

            if (singleModeProgram == null)
            {
                return NotFound();
            }

            return singleModeProgram;
        }

        // PUT: api/SingleModeProgram/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeProgram(int id, SingleModeProgram singleModeProgram)
        {
            if (id != singleModeProgram.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeProgram).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeProgramExists(id))
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

        // POST: api/SingleModeProgram
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeProgram>> PostSingleModeProgram(SingleModeProgram singleModeProgram)
        {
            _context.SingleModePrograms.Add(singleModeProgram);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeProgramExists(singleModeProgram.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeProgram", new { id = singleModeProgram.Id }, singleModeProgram);
        }

        // DELETE: api/SingleModeProgram/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeProgram(int id)
        {
            var singleModeProgram = await _context.SingleModePrograms.FindAsync(id);
            if (singleModeProgram == null)
            {
                return NotFound();
            }

            _context.SingleModePrograms.Remove(singleModeProgram);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeProgramExists(int id)
        {
            return _context.SingleModePrograms.Any(e => e.Id == id);
        }
    }
}
