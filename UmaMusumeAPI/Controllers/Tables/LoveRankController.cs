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
    public class LoveRankController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public LoveRankController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/LoveRank
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LoveRank>>> GetLoveRanks()
        {
            return await _context.LoveRanks.ToListAsync();
        }

        // GET: api/LoveRank/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LoveRank>> GetLoveRank(int id)
        {
            var loveRank = await _context.LoveRanks.FindAsync(id);

            if (loveRank == null)
            {
                return NotFound();
            }

            return loveRank;
        }
    }
}
