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
    public class SingleModeEventConclusionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeEventConclusionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeEventConclusion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeEventConclusion>>> GetSingleModeEventConclusions()
        {
            return await _context.SingleModeEventConclusions.ToListAsync();
        }

        // GET: api/SingleModeEventConclusion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeEventConclusion>> GetSingleModeEventConclusion(int id)
        {
            var singleModeEventConclusion = await _context.SingleModeEventConclusions.FindAsync(id);

            if (singleModeEventConclusion == null)
            {
                return NotFound();
            }

            return singleModeEventConclusion;
        }
    }
}
