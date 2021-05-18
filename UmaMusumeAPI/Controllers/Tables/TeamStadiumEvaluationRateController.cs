using System.Collections.Generic;
using System.Threading.Tasks;

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
    }
}
