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
    public class SingleModeTrainingController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeTrainingController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeTraining
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeTraining>>> GetSingleModeTrainings()
        {
            return await _context.SingleModeTrainings.ToListAsync();
        }

        // GET: api/SingleModeTraining/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeTraining>> GetSingleModeTraining(int id)
        {
            var singleModeTraining = await _context.SingleModeTrainings.FindAsync(id);

            if (singleModeTraining == null)
            {
                return NotFound();
            }

            return singleModeTraining;
        }
    }
}
