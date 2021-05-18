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
    public class ChampionsEvaluationRateController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsEvaluationRateController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsEvaluationRate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsEvaluationRate>>> GetChampionsEvaluationRates()
        {
            return await _context.ChampionsEvaluationRates.ToListAsync();
        }

        // GET: api/ChampionsEvaluationRate/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsEvaluationRate>> GetChampionsEvaluationRate(int id)
        {
            var championsEvaluationRate = await _context.ChampionsEvaluationRates.FindAsync(id);

            if (championsEvaluationRate == null)
            {
                return NotFound();
            }

            return championsEvaluationRate;
        }

        // PUT: api/ChampionsEvaluationRate/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChampionsEvaluationRate(int id, ChampionsEvaluationRate championsEvaluationRate)
        {
            if (id != championsEvaluationRate.Id)
            {
                return BadRequest();
            }

            _context.Entry(championsEvaluationRate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChampionsEvaluationRateExists(id))
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

        // POST: api/ChampionsEvaluationRate
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChampionsEvaluationRate>> PostChampionsEvaluationRate(ChampionsEvaluationRate championsEvaluationRate)
        {
            _context.ChampionsEvaluationRates.Add(championsEvaluationRate);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChampionsEvaluationRateExists(championsEvaluationRate.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetChampionsEvaluationRate", new { id = championsEvaluationRate.Id }, championsEvaluationRate);
        }

        // DELETE: api/ChampionsEvaluationRate/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChampionsEvaluationRate(int id)
        {
            var championsEvaluationRate = await _context.ChampionsEvaluationRates.FindAsync(id);
            if (championsEvaluationRate == null)
            {
                return NotFound();
            }

            _context.ChampionsEvaluationRates.Remove(championsEvaluationRate);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChampionsEvaluationRateExists(int id)
        {
            return _context.ChampionsEvaluationRates.Any(e => e.Id == id);
        }
    }
}
