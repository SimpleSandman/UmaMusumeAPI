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
    public class SingleModeCharaProgramController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeCharaProgramController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeCharaProgram
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeCharaProgram>>> GetSingleModeCharaPrograms()
        {
            return await _context.SingleModeCharaPrograms.ToListAsync();
        }

        // GET: api/SingleModeCharaProgram/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeCharaProgram>> GetSingleModeCharaProgram(int id)
        {
            var singleModeCharaProgram = await _context.SingleModeCharaPrograms.FindAsync(id);

            if (singleModeCharaProgram == null)
            {
                return NotFound();
            }

            return singleModeCharaProgram;
        }

        // PUT: api/SingleModeCharaProgram/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeCharaProgram(int id, SingleModeCharaProgram singleModeCharaProgram)
        {
            if (id != singleModeCharaProgram.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeCharaProgram).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeCharaProgramExists(id))
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

        // POST: api/SingleModeCharaProgram
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeCharaProgram>> PostSingleModeCharaProgram(SingleModeCharaProgram singleModeCharaProgram)
        {
            _context.SingleModeCharaPrograms.Add(singleModeCharaProgram);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeCharaProgramExists(singleModeCharaProgram.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeCharaProgram", new { id = singleModeCharaProgram.Id }, singleModeCharaProgram);
        }

        // DELETE: api/SingleModeCharaProgram/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeCharaProgram(int id)
        {
            var singleModeCharaProgram = await _context.SingleModeCharaPrograms.FindAsync(id);
            if (singleModeCharaProgram == null)
            {
                return NotFound();
            }

            _context.SingleModeCharaPrograms.Remove(singleModeCharaProgram);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeCharaProgramExists(int id)
        {
            return _context.SingleModeCharaPrograms.Any(e => e.Id == id);
        }
    }
}
