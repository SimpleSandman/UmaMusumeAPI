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
    public class SingleModeTrainingController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeTrainingController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeTraining
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeTraining>>> GetSingleModeTrainings()
        {
            return await _context.SingleModeTrainings.ToListAsync();
        }

        // GET: api/SingleModeTraining/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeTraining>> GetSingleModeTraining(int id)
        {
            var singleModeTraining = await _context.SingleModeTrainings.FindAsync(id);

            if (singleModeTraining == null)
            {
                return NotFound();
            }

            return singleModeTraining;
        }

        // PUT: api/SingleModeTraining/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeTraining(int id, SingleModeTraining singleModeTraining)
        {
            if (id != singleModeTraining.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeTraining).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeTrainingExists(id))
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

        // POST: api/SingleModeTraining
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeTraining>> PostSingleModeTraining(SingleModeTraining singleModeTraining)
        {
            _context.SingleModeTrainings.Add(singleModeTraining);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeTrainingExists(singleModeTraining.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeTraining", new { id = singleModeTraining.Id }, singleModeTraining);
        }

        // DELETE: api/SingleModeTraining/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeTraining(int id)
        {
            var singleModeTraining = await _context.SingleModeTrainings.FindAsync(id);
            if (singleModeTraining == null)
            {
                return NotFound();
            }

            _context.SingleModeTrainings.Remove(singleModeTraining);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeTrainingExists(int id)
        {
            return _context.SingleModeTrainings.Any(e => e.Id == id);
        }
    }
}
