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
    public class SingleModeMemberRankController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeMemberRankController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeMemberRank
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeMemberRank>>> GetSingleModeMemberRanks()
        {
            return await _context.SingleModeMemberRanks.ToListAsync();
        }

        // GET: api/SingleModeMemberRank/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeMemberRank>> GetSingleModeMemberRank(int id)
        {
            var singleModeMemberRank = await _context.SingleModeMemberRanks.FindAsync(id);

            if (singleModeMemberRank == null)
            {
                return NotFound();
            }

            return singleModeMemberRank;
        }
    }
}
