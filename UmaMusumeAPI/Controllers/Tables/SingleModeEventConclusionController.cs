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
    public class SingleModeEventConclusionController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeEventConclusionController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeEventConclusion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeEventConclusion>>> GetSingleModeEventConclusion()
        {
            return await _context.SingleModeEventConclusions.ToListAsync();
        }

        // GET: api/SingleModeEventConclusion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<SingleModeEventConclusion>>> GetSingleModeEventConclusion(int id)
        {
            var singleModeEventConclusion = await _context.SingleModeEventConclusions
                .Where(c => c.Id == id)
                .ToListAsync();

            if (singleModeEventConclusion == null)
            {
                return NotFound();
            }

            return singleModeEventConclusion;
        }
    }
}
