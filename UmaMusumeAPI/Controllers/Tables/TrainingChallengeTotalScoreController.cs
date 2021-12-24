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
    public class TrainingChallengeTotalScoreController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TrainingChallengeTotalScoreController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TrainingChallengeTotalScore
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingChallengeTotalScore>>> GetTrainingChallengeTotalScore()
        {
            return await _context.TrainingChallengeTotalScores.ToListAsync();
        }

        // GET: api/TrainingChallengeTotalScore/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrainingChallengeTotalScore>> GetTrainingChallengeTotalScore(int id)
        {
            var trainingChallengeTotalScore = await _context.TrainingChallengeTotalScores.FindAsync(id);

            if (trainingChallengeTotalScore == null)
            {
                return NotFound();
            }

            return trainingChallengeTotalScore;
        }
    }
}
