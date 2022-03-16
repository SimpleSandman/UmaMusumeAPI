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
        public async Task<ActionResult<IEnumerable<SingleModeConclusionSet>>> GetSingleModeConclusionSet(int storyId)
        {
            var singleModeConclusionSet = await _context.SingleModeConclusionSets
                .Where(c => c.StoryId == storyId)
                .ToListAsync();

            if (singleModeConclusionSet == null)
            {
                return NotFound();
            }

            return singleModeConclusionSet;
        }
    }
}
