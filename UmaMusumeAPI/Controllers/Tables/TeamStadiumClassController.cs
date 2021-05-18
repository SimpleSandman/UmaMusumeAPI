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
    public class TeamStadiumClassController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TeamStadiumClassController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TeamStadiumClass
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamStadiumClass>>> GetTeamStadiumClasses()
        {
            return await _context.TeamStadiumClasses.ToListAsync();
        }

        // GET: api/TeamStadiumClass/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamStadiumClass>> GetTeamStadiumClass(int id)
        {
            var teamStadiumClass = await _context.TeamStadiumClasses.FindAsync(id);

            if (teamStadiumClass == null)
            {
                return NotFound();
            }

            return teamStadiumClass;
        }

        // PUT: api/TeamStadiumClass/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeamStadiumClass(int id, TeamStadiumClass teamStadiumClass)
        {
            if (id != teamStadiumClass.Id)
            {
                return BadRequest();
            }

            _context.Entry(teamStadiumClass).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamStadiumClassExists(id))
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

        // POST: api/TeamStadiumClass
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TeamStadiumClass>> PostTeamStadiumClass(TeamStadiumClass teamStadiumClass)
        {
            _context.TeamStadiumClasses.Add(teamStadiumClass);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TeamStadiumClassExists(teamStadiumClass.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTeamStadiumClass", new { id = teamStadiumClass.Id }, teamStadiumClass);
        }

        // DELETE: api/TeamStadiumClass/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeamStadiumClass(int id)
        {
            var teamStadiumClass = await _context.TeamStadiumClasses.FindAsync(id);
            if (teamStadiumClass == null)
            {
                return NotFound();
            }

            _context.TeamStadiumClasses.Remove(teamStadiumClass);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TeamStadiumClassExists(int id)
        {
            return _context.TeamStadiumClasses.Any(e => e.Id == id);
        }
    }
}
