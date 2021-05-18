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
    public class TeamStadiumEvaluationRateController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TeamStadiumEvaluationRateController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TeamStadiumEvaluationRate
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamStadiumEvaluationRate>>> GetTeamStadiumEvaluationRates()
        {
            return await _context.TeamStadiumEvaluationRates.ToListAsync();
        }

        // GET: api/TeamStadiumEvaluationRate/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeamStadiumEvaluationRate>> GetTeamStadiumEvaluationRate(int id)
        {
            var teamStadiumEvaluationRate = await _context.TeamStadiumEvaluationRates.FindAsync(id);

            if (teamStadiumEvaluationRate == null)
            {
                return NotFound();
            }

            return teamStadiumEvaluationRate;
        }

        // PUT: api/TeamStadiumEvaluationRate/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeamStadiumEvaluationRate(int id, TeamStadiumEvaluationRate teamStadiumEvaluationRate)
        {
            if (id != teamStadiumEvaluationRate.ProperType)
            {
                return BadRequest();
            }

            _context.Entry(teamStadiumEvaluationRate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamStadiumEvaluationRateExists(id))
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

        // POST: api/TeamStadiumEvaluationRate
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TeamStadiumEvaluationRate>> PostTeamStadiumEvaluationRate(TeamStadiumEvaluationRate teamStadiumEvaluationRate)
        {
            _context.TeamStadiumEvaluationRates.Add(teamStadiumEvaluationRate);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TeamStadiumEvaluationRateExists(teamStadiumEvaluationRate.ProperType))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTeamStadiumEvaluationRate", new { id = teamStadiumEvaluationRate.ProperType }, teamStadiumEvaluationRate);
        }

        // DELETE: api/TeamStadiumEvaluationRate/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeamStadiumEvaluationRate(int id)
        {
            var teamStadiumEvaluationRate = await _context.TeamStadiumEvaluationRates.FindAsync(id);
            if (teamStadiumEvaluationRate == null)
            {
                return NotFound();
            }

            _context.TeamStadiumEvaluationRates.Remove(teamStadiumEvaluationRate);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TeamStadiumEvaluationRateExists(int id)
        {
            return _context.TeamStadiumEvaluationRates.Any(e => e.ProperType == id);
        }
    }
}
