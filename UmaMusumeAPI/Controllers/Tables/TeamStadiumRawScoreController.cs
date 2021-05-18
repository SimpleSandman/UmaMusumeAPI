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
    public class TeamStadiumRawScoreController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TeamStadiumRawScoreController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TeamStadiumRawScore
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamStadiumRawScore>>> GetTeamStadiumRawScores()
        {
            return await _context.TeamStadiumRawScores.ToListAsync();
        }

        // GET: api/TeamStadiumRawScore/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamStadiumRawScore>> GetTeamStadiumRawScore(int id)
        {
            var teamStadiumRawScore = await _context.TeamStadiumRawScores.FindAsync(id);

            if (teamStadiumRawScore == null)
            {
                return NotFound();
            }

            return teamStadiumRawScore;
        }

        // PUT: api/TeamStadiumRawScore/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeamStadiumRawScore(int id, TeamStadiumRawScore teamStadiumRawScore)
        {
            if (id != teamStadiumRawScore.Id)
            {
                return BadRequest();
            }

            _context.Entry(teamStadiumRawScore).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamStadiumRawScoreExists(id))
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

        // POST: api/TeamStadiumRawScore
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TeamStadiumRawScore>> PostTeamStadiumRawScore(TeamStadiumRawScore teamStadiumRawScore)
        {
            _context.TeamStadiumRawScores.Add(teamStadiumRawScore);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TeamStadiumRawScoreExists(teamStadiumRawScore.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTeamStadiumRawScore", new { id = teamStadiumRawScore.Id }, teamStadiumRawScore);
        }

        // DELETE: api/TeamStadiumRawScore/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeamStadiumRawScore(int id)
        {
            var teamStadiumRawScore = await _context.TeamStadiumRawScores.FindAsync(id);
            if (teamStadiumRawScore == null)
            {
                return NotFound();
            }

            _context.TeamStadiumRawScores.Remove(teamStadiumRawScore);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TeamStadiumRawScoreExists(int id)
        {
            return _context.TeamStadiumRawScores.Any(e => e.Id == id);
        }
    }
}
