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
    public class TrainingChallengeMasterController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TrainingChallengeMasterController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TrainingChallengeMaster
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingChallengeMaster>>> GetTrainingChallengeMaster()
        {
            return await _context.TrainingChallengeMasters.ToListAsync();
        }

        // GET: api/TrainingChallengeMaster/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrainingChallengeMaster>> GetTrainingChallengeMaster(int id)
        {
            var trainingChallengeMaster = await _context.TrainingChallengeMasters.FindAsync(id);

            if (trainingChallengeMaster == null)
            {
                return NotFound();
            }

            return trainingChallengeMaster;
        }
    }
}
