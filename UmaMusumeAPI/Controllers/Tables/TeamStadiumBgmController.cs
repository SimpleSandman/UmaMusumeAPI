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
    public class TeamStadiumBgmController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TeamStadiumBgmController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TeamStadiumBgm
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamStadiumBgm>>> GetTeamStadiumBgms()
        {
            return await _context.TeamStadiumBgms.ToListAsync();
        }

        // GET: api/TeamStadiumBgm/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamStadiumBgm>> GetTeamStadiumBgm(int id)
        {
            var teamStadiumBgm = await _context.TeamStadiumBgms.FindAsync(id);

            if (teamStadiumBgm == null)
            {
                return NotFound();
            }

            return teamStadiumBgm;
        }

        // PUT: api/TeamStadiumBgm/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeamStadiumBgm(int id, TeamStadiumBgm teamStadiumBgm)
        {
            if (id != teamStadiumBgm.Id)
            {
                return BadRequest();
            }

            _context.Entry(teamStadiumBgm).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamStadiumBgmExists(id))
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

        // POST: api/TeamStadiumBgm
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TeamStadiumBgm>> PostTeamStadiumBgm(TeamStadiumBgm teamStadiumBgm)
        {
            _context.TeamStadiumBgms.Add(teamStadiumBgm);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TeamStadiumBgmExists(teamStadiumBgm.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTeamStadiumBgm", new { id = teamStadiumBgm.Id }, teamStadiumBgm);
        }

        // DELETE: api/TeamStadiumBgm/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeamStadiumBgm(int id)
        {
            var teamStadiumBgm = await _context.TeamStadiumBgms.FindAsync(id);
            if (teamStadiumBgm == null)
            {
                return NotFound();
            }

            _context.TeamStadiumBgms.Remove(teamStadiumBgm);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TeamStadiumBgmExists(int id)
        {
            return _context.TeamStadiumBgms.Any(e => e.Id == id);
        }
    }
}
