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
    public class ChampionsRewardRateController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ChampionsRewardRateController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ChampionsRewardRate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChampionsRewardRate>>> GetChampionsRewardRates()
        {
            return await _context.ChampionsRewardRates.ToListAsync();
        }

        // GET: api/ChampionsRewardRate/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChampionsRewardRate>> GetChampionsRewardRate(int id)
        {
            var championsRewardRate = await _context.ChampionsRewardRates.FindAsync(id);

            if (championsRewardRate == null)
            {
                return NotFound();
            }

            return championsRewardRate;
        }

        // PUT: api/ChampionsRewardRate/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChampionsRewardRate(int id, ChampionsRewardRate championsRewardRate)
        {
            if (id != championsRewardRate.Id)
            {
                return BadRequest();
            }

            _context.Entry(championsRewardRate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChampionsRewardRateExists(id))
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

        // POST: api/ChampionsRewardRate
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChampionsRewardRate>> PostChampionsRewardRate(ChampionsRewardRate championsRewardRate)
        {
            _context.ChampionsRewardRates.Add(championsRewardRate);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChampionsRewardRateExists(championsRewardRate.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetChampionsRewardRate", new { id = championsRewardRate.Id }, championsRewardRate);
        }

        // DELETE: api/ChampionsRewardRate/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChampionsRewardRate(int id)
        {
            var championsRewardRate = await _context.ChampionsRewardRates.FindAsync(id);
            if (championsRewardRate == null)
            {
                return NotFound();
            }

            _context.ChampionsRewardRates.Remove(championsRewardRate);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChampionsRewardRateExists(int id)
        {
            return _context.ChampionsRewardRates.Any(e => e.Id == id);
        }
    }
}
