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
    public class TeamStadiumScoreBonuController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TeamStadiumScoreBonuController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TeamStadiumScoreBonu
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamStadiumScoreBonu>>> GetTeamStadiumScoreBonus()
        {
            return await _context.TeamStadiumScoreBonus.ToListAsync();
        }

        // GET: api/TeamStadiumScoreBonu/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamStadiumScoreBonu>> GetTeamStadiumScoreBonu(int id)
        {
            var teamStadiumScoreBonu = await _context.TeamStadiumScoreBonus.FindAsync(id);

            if (teamStadiumScoreBonu == null)
            {
                return NotFound();
            }

            return teamStadiumScoreBonu;
        }

        // PUT: api/TeamStadiumScoreBonu/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeamStadiumScoreBonu(int id, TeamStadiumScoreBonu teamStadiumScoreBonu)
        {
            if (id != teamStadiumScoreBonu.Id)
            {
                return BadRequest();
            }

            _context.Entry(teamStadiumScoreBonu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamStadiumScoreBonuExists(id))
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

        // POST: api/TeamStadiumScoreBonu
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TeamStadiumScoreBonu>> PostTeamStadiumScoreBonu(TeamStadiumScoreBonu teamStadiumScoreBonu)
        {
            _context.TeamStadiumScoreBonus.Add(teamStadiumScoreBonu);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TeamStadiumScoreBonuExists(teamStadiumScoreBonu.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTeamStadiumScoreBonu", new { id = teamStadiumScoreBonu.Id }, teamStadiumScoreBonu);
        }

        // DELETE: api/TeamStadiumScoreBonu/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeamStadiumScoreBonu(int id)
        {
            var teamStadiumScoreBonu = await _context.TeamStadiumScoreBonus.FindAsync(id);
            if (teamStadiumScoreBonu == null)
            {
                return NotFound();
            }

            _context.TeamStadiumScoreBonus.Remove(teamStadiumScoreBonu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TeamStadiumScoreBonuExists(int id)
        {
            return _context.TeamStadiumScoreBonus.Any(e => e.Id == id);
        }
    }
}
