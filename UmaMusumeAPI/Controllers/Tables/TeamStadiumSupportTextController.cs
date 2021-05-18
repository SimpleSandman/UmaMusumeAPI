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
    public class TeamStadiumSupportTextController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TeamStadiumSupportTextController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TeamStadiumSupportText
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamStadiumSupportText>>> GetTeamStadiumSupportTexts()
        {
            return await _context.TeamStadiumSupportTexts.ToListAsync();
        }

        // GET: api/TeamStadiumSupportText/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamStadiumSupportText>> GetTeamStadiumSupportText(int id)
        {
            var teamStadiumSupportText = await _context.TeamStadiumSupportTexts.FindAsync(id);

            if (teamStadiumSupportText == null)
            {
                return NotFound();
            }

            return teamStadiumSupportText;
        }

        // PUT: api/TeamStadiumSupportText/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeamStadiumSupportText(int id, TeamStadiumSupportText teamStadiumSupportText)
        {
            if (id != teamStadiumSupportText.Id)
            {
                return BadRequest();
            }

            _context.Entry(teamStadiumSupportText).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamStadiumSupportTextExists(id))
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

        // POST: api/TeamStadiumSupportText
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TeamStadiumSupportText>> PostTeamStadiumSupportText(TeamStadiumSupportText teamStadiumSupportText)
        {
            _context.TeamStadiumSupportTexts.Add(teamStadiumSupportText);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TeamStadiumSupportTextExists(teamStadiumSupportText.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTeamStadiumSupportText", new { id = teamStadiumSupportText.Id }, teamStadiumSupportText);
        }

        // DELETE: api/TeamStadiumSupportText/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeamStadiumSupportText(int id)
        {
            var teamStadiumSupportText = await _context.TeamStadiumSupportTexts.FindAsync(id);
            if (teamStadiumSupportText == null)
            {
                return NotFound();
            }

            _context.TeamStadiumSupportTexts.Remove(teamStadiumSupportText);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TeamStadiumSupportTextExists(int id)
        {
            return _context.TeamStadiumSupportTexts.Any(e => e.Id == id);
        }
    }
}
