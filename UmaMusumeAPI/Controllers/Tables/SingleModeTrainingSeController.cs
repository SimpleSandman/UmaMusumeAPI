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
    public class SingleModeTrainingSeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeTrainingSeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeTrainingSe
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeTrainingSe>>> GetSingleModeTrainingSes()
        {
            return await _context.SingleModeTrainingSes.ToListAsync();
        }

        // GET: api/SingleModeTrainingSe/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeTrainingSe>> GetSingleModeTrainingSe(int id)
        {
            var singleModeTrainingSe = await _context.SingleModeTrainingSes.FindAsync(id);

            if (singleModeTrainingSe == null)
            {
                return NotFound();
            }

            return singleModeTrainingSe;
        }
    }
}
