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
    public class SingleModeTrainingSeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeTrainingSeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeTrainingSe
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeTrainingSe>>> GetSingleModeTrainingSes()
        {
            return await _context.SingleModeTrainingSes.ToListAsync();
        }

        // GET: api/SingleModeTrainingSe/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeTrainingSe>> GetSingleModeTrainingSe(int id)
        {
            var singleModeTrainingSe = await _context.SingleModeTrainingSes.FindAsync(id);

            if (singleModeTrainingSe == null)
            {
                return NotFound();
            }

            return singleModeTrainingSe;
        }

        // PUT: api/SingleModeTrainingSe/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSingleModeTrainingSe(int id, SingleModeTrainingSe singleModeTrainingSe)
        {
            if (id != singleModeTrainingSe.Id)
            {
                return BadRequest();
            }

            _context.Entry(singleModeTrainingSe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SingleModeTrainingSeExists(id))
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

        // POST: api/SingleModeTrainingSe
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SingleModeTrainingSe>> PostSingleModeTrainingSe(SingleModeTrainingSe singleModeTrainingSe)
        {
            _context.SingleModeTrainingSes.Add(singleModeTrainingSe);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SingleModeTrainingSeExists(singleModeTrainingSe.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSingleModeTrainingSe", new { id = singleModeTrainingSe.Id }, singleModeTrainingSe);
        }

        // DELETE: api/SingleModeTrainingSe/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSingleModeTrainingSe(int id)
        {
            var singleModeTrainingSe = await _context.SingleModeTrainingSes.FindAsync(id);
            if (singleModeTrainingSe == null)
            {
                return NotFound();
            }

            _context.SingleModeTrainingSes.Remove(singleModeTrainingSe);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SingleModeTrainingSeExists(int id)
        {
            return _context.SingleModeTrainingSes.Any(e => e.Id == id);
        }
    }
}
