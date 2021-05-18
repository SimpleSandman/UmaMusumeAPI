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
    public class SupportCardTeamScoreBonuController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SupportCardTeamScoreBonuController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SupportCardTeamScoreBonu
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SupportCardTeamScoreBonu>>> GetSupportCardTeamScoreBonus()
        {
            return await _context.SupportCardTeamScoreBonus.ToListAsync();
        }

        // GET: api/SupportCardTeamScoreBonu/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SupportCardTeamScoreBonu>> GetSupportCardTeamScoreBonu(int id)
        {
            var supportCardTeamScoreBonu = await _context.SupportCardTeamScoreBonus.FindAsync(id);

            if (supportCardTeamScoreBonu == null)
            {
                return NotFound();
            }

            return supportCardTeamScoreBonu;
        }

        // PUT: api/SupportCardTeamScoreBonu/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupportCardTeamScoreBonu(int id, SupportCardTeamScoreBonu supportCardTeamScoreBonu)
        {
            if (id != supportCardTeamScoreBonu.Id)
            {
                return BadRequest();
            }

            _context.Entry(supportCardTeamScoreBonu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupportCardTeamScoreBonuExists(id))
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

        // POST: api/SupportCardTeamScoreBonu
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SupportCardTeamScoreBonu>> PostSupportCardTeamScoreBonu(SupportCardTeamScoreBonu supportCardTeamScoreBonu)
        {
            _context.SupportCardTeamScoreBonus.Add(supportCardTeamScoreBonu);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (SupportCardTeamScoreBonuExists(supportCardTeamScoreBonu.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetSupportCardTeamScoreBonu", new { id = supportCardTeamScoreBonu.Id }, supportCardTeamScoreBonu);
        }

        // DELETE: api/SupportCardTeamScoreBonu/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupportCardTeamScoreBonu(int id)
        {
            var supportCardTeamScoreBonu = await _context.SupportCardTeamScoreBonus.FindAsync(id);
            if (supportCardTeamScoreBonu == null)
            {
                return NotFound();
            }

            _context.SupportCardTeamScoreBonus.Remove(supportCardTeamScoreBonu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SupportCardTeamScoreBonuExists(int id)
        {
            return _context.SupportCardTeamScoreBonus.Any(e => e.Id == id);
        }
    }
}
