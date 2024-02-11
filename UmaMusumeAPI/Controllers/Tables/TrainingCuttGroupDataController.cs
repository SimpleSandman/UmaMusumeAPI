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
    public class TrainingCuttGroupDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TrainingCuttGroupDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TrainingCuttGroupData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingCuttGroupData>>> GetTrainingCuttGroupData()
        {
            return await _context.TrainingCuttGroupData.ToListAsync();
        }

        // GET: api/TrainingCuttGroupData/5
        [HttpGet("{groupId}")]
        public async Task<ActionResult<IEnumerable<TrainingCuttGroupData>>> GetTrainingCuttGroupData(int groupId)
        {
            var trainingCuttGroupData = await _context.TrainingCuttGroupData
                .Where(c => c.GroupId == groupId)
                .ToListAsync();

            if (trainingCuttGroupData == null)
            {
                return NotFound();
            }

            return trainingCuttGroupData;
        }
    }
}
