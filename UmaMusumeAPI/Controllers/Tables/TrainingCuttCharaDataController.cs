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
    public class TrainingCuttCharaDataController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public TrainingCuttCharaDataController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/TrainingCuttCharaData
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingCuttCharaData>>> GetTrainingCuttCharaData()
        {
            return await _context.TrainingCuttCharaData.ToListAsync();
        }

        // GET: api/TrainingCuttCharaData/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrainingCuttCharaData>> GetTrainingCuttCharaData(int id)
        {
            var trainingCuttCharaData = await _context.TrainingCuttCharaData.FindAsync(id);

            if (trainingCuttCharaData == null)
            {
                return NotFound();
            }

            return trainingCuttCharaData;
        }
    }
}
