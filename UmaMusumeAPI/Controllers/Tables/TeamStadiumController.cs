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
    public class TeamStadiumController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TeamStadiumController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TeamStadium
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamStadium>>> GetTeamStadia()
        {
            return await _context.TeamStadia.ToListAsync();
        }

        // GET: api/TeamStadium/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamStadium>> GetTeamStadium(int id)
        {
            var teamStadium = await _context.TeamStadia.FindAsync(id);

            if (teamStadium == null)
            {
                return NotFound();
            }

            return teamStadium;
        }

        // PUT: api/TeamStadium/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeamStadium(int id, TeamStadium teamStadium)
        {
            if (id != teamStadium.Id)
            {
                return BadRequest();
            }

            _context.Entry(teamStadium).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamStadiumExists(id))
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

        // POST: api/TeamStadium
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TeamStadium>> PostTeamStadium(TeamStadium teamStadium)
        {
            _context.TeamStadia.Add(teamStadium);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TeamStadiumExists(teamStadium.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTeamStadium", new { id = teamStadium.Id }, teamStadium);
        }

        // DELETE: api/TeamStadium/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeamStadium(int id)
        {
            var teamStadium = await _context.TeamStadia.FindAsync(id);
            if (teamStadium == null)
            {
                return NotFound();
            }

            _context.TeamStadia.Remove(teamStadium);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TeamStadiumExists(int id)
        {
            return _context.TeamStadia.Any(e => e.Id == id);
        }
    }
}
