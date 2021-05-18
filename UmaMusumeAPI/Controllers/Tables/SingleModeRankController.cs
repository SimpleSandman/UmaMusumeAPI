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
    public class SingleModeRankController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeRankController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeRank
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeRank>>> GetSingleModeRanks()
        {
            return await _context.SingleModeRanks.ToListAsync();
        }

        // GET: api/SingleModeRank/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeRank>> GetSingleModeRank(int id)
        {
            var singleModeRank = await _context.SingleModeRanks.FindAsync(id);

            if (singleModeRank == null)
            {
                return NotFound();
            }

            return singleModeRank;
        }
    }
}
