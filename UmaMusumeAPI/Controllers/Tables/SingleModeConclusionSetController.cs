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
    public class SingleModeConclusionSetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeConclusionSetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeConclusionSet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeConclusionSet>>> GetSingleModeConclusionSet()
        {
            return await _context.SingleModeConclusionSets.ToListAsync();
        }

        // GET: api/SingleModeConclusionSet/5
        [HttpGet("{storyId}")]
        public async Task<ActionResult<SingleModeConclusionSet>> GetSingleModeConclusionSet(int storyId)
        {
            var singleModeConclusionSet = await _context.SingleModeConclusionSets.SingleOrDefaultAsync(c => c.StoryId == storyId);

            if (singleModeConclusionSet == null)
            {
                return NotFound();
            }

            return singleModeConclusionSet;
        }
    }
}
