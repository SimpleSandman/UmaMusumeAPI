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
    public class TeamStadiumRankController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TeamStadiumRankController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TeamStadiumRank
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamStadiumRank>>> GetTeamStadiumRanks()
        {
            return await _context.TeamStadiumRanks.ToListAsync();
        }

        // GET: api/TeamStadiumRank/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamStadiumRank>> GetTeamStadiumRank(int id)
        {
            var teamStadiumRank = await _context.TeamStadiumRanks.FindAsync(id);

            if (teamStadiumRank == null)
            {
                return NotFound();
            }

            return teamStadiumRank;
        }

        // PUT: api/TeamStadiumRank/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeamStadiumRank(int id, TeamStadiumRank teamStadiumRank)
        {
            if (id != teamStadiumRank.Id)
            {
                return BadRequest();
            }

            _context.Entry(teamStadiumRank).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamStadiumRankExists(id))
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

        // POST: api/TeamStadiumRank
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TeamStadiumRank>> PostTeamStadiumRank(TeamStadiumRank teamStadiumRank)
        {
            _context.TeamStadiumRanks.Add(teamStadiumRank);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TeamStadiumRankExists(teamStadiumRank.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTeamStadiumRank", new { id = teamStadiumRank.Id }, teamStadiumRank);
        }

        // DELETE: api/TeamStadiumRank/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeamStadiumRank(int id)
        {
            var teamStadiumRank = await _context.TeamStadiumRanks.FindAsync(id);
            if (teamStadiumRank == null)
            {
                return NotFound();
            }

            _context.TeamStadiumRanks.Remove(teamStadiumRank);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TeamStadiumRankExists(int id)
        {
            return _context.TeamStadiumRanks.Any(e => e.Id == id);
        }
    }
}
