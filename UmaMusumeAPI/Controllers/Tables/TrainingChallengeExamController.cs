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
    public class TrainingChallengeExamController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TrainingChallengeExamController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TrainingChallengeExam
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingChallengeExam>>> GetTrainingChallengeExam()
        {
            return await _context.TrainingChallengeExams.ToListAsync();
        }

        // GET: api/TrainingChallengeExam/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrainingChallengeExam>> GetTrainingChallengeExam(int id)
        {
            var trainingChallengeExam = await _context.TrainingChallengeExams.FindAsync(id);

            if (trainingChallengeExam == null)
            {
                return NotFound();
            }

            return trainingChallengeExam;
        }
    }
}
