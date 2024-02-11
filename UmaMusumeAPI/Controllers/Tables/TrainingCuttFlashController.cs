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
    public class TrainingCuttFlashController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TrainingCuttFlashController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TrainingCuttFlash
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingCuttFlash>>> GetTrainingCuttFlash()
        {
            return await _context.TrainingCuttFlashes.ToListAsync();
        }

        // GET: api/TrainingCuttFlash/5
        [HttpGet("{commandId}")]
        public async Task<ActionResult<TrainingCuttFlash>> GetTrainingCuttFlash(int commandId)
        {
            var trainingCuttFlash = await _context.TrainingCuttFlashes.FindAsync(commandId);

            if (trainingCuttFlash == null)
            {
                return NotFound();
            }

            return trainingCuttFlash;
        }
    }
}
