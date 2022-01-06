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
    public class TrainingCuttDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TrainingCuttDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TrainingCuttData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingCuttData>>> GetTrainingCuttData()
        {
            return await _context.TrainingCuttData.ToListAsync();
        }

        // GET: api/TrainingCuttData/5
        [HttpGet("{commandId}")]
        public async Task<ActionResult<IEnumerable<TrainingCuttData>>> GetTrainingCuttData(long commandId)
        {
            var trainingCuttData = await _context.TrainingCuttData
                .Where(c => c.CommandId == commandId)
                .ToListAsync();

            if (trainingCuttData == null)
            {
                return NotFound();
            }

            return trainingCuttData;
        }
    }
}
