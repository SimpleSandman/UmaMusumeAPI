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
    public class SingleModeRewardSetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeRewardSetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeRewardSet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeRewardSet>>> GetSingleModeRewardSets()
        {
            return await _context.SingleModeRewardSets.ToListAsync();
        }

        // GET: api/SingleModeRewardSet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeRewardSet>> GetSingleModeRewardSet(int id)
        {
            var singleModeRewardSet = await _context.SingleModeRewardSets.FindAsync(id);

            if (singleModeRewardSet == null)
            {
                return NotFound();
            }

            return singleModeRewardSet;
        }
    }
}
