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
    public class TrainingChallengeScoreController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TrainingChallengeScoreController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TrainingChallengeScore
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingChallengeScore>>> GetTrainingChallengeScore()
        {
            return await _context.TrainingChallengeScores.ToListAsync();
        }

        // GET: api/TrainingChallengeScore/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrainingChallengeScore>> GetTrainingChallengeScore(int id)
        {
            var trainingChallengeScore = await _context.TrainingChallengeScores.FindAsync(id);

            if (trainingChallengeScore == null)
            {
                return NotFound();
            }

            return trainingChallengeScore;
        }
    }
}
