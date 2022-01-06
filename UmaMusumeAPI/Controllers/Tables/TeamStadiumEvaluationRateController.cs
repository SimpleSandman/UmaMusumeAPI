using System.Collections.Generic;
using System.Linq;
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
        [HttpGet("{properType}")]
        public async Task<ActionResult<IEnumerable<TeamStadiumEvaluationRate>>> GetTeamStadiumEvaluationRate(int properType)
        {
            var teamStadiumEvaluationRate = await _context.TeamStadiumEvaluationRates
                .Where(c => c.ProperType == properType)
                .ToListAsync();

            if (teamStadiumEvaluationRate == null)
            {
                return NotFound();
            }

            return teamStadiumEvaluationRate;
        }
    }
}
