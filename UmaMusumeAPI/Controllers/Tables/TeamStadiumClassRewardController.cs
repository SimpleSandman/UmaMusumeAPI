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
    public class TeamStadiumClassRewardController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TeamStadiumClassRewardController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TeamStadiumClassReward
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamStadiumClassReward>>> GetTeamStadiumClassRewards()
        {
            return await _context.TeamStadiumClassRewards.ToListAsync();
        }

        // GET: api/TeamStadiumClassReward/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamStadiumClassReward>> GetTeamStadiumClassReward(int id)
        {
            var teamStadiumClassReward = await _context.TeamStadiumClassRewards.FindAsync(id);

            if (teamStadiumClassReward == null)
            {
                return NotFound();
            }

            return teamStadiumClassReward;
        }

        // PUT: api/TeamStadiumClassReward/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeamStadiumClassReward(int id, TeamStadiumClassReward teamStadiumClassReward)
        {
            if (id != teamStadiumClassReward.Id)
            {
                return BadRequest();
            }

            _context.Entry(teamStadiumClassReward).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamStadiumClassRewardExists(id))
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

        // POST: api/TeamStadiumClassReward
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TeamStadiumClassReward>> PostTeamStadiumClassReward(TeamStadiumClassReward teamStadiumClassReward)
        {
            _context.TeamStadiumClassRewards.Add(teamStadiumClassReward);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TeamStadiumClassRewardExists(teamStadiumClassReward.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTeamStadiumClassReward", new { id = teamStadiumClassReward.Id }, teamStadiumClassReward);
        }

        // DELETE: api/TeamStadiumClassReward/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeamStadiumClassReward(int id)
        {
            var teamStadiumClassReward = await _context.TeamStadiumClassRewards.FindAsync(id);
            if (teamStadiumClassReward == null)
            {
                return NotFound();
            }

            _context.TeamStadiumClassRewards.Remove(teamStadiumClassReward);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TeamStadiumClassRewardExists(int id)
        {
            return _context.TeamStadiumClassRewards.Any(e => e.Id == id);
        }
    }
}
