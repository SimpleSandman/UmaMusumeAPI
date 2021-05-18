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
    public class SuccessionRelationRankController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SuccessionRelationRankController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SuccessionRelationRank
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SuccessionRelationRank>>> GetSuccessionRelationRanks()
        {
            return await _context.SuccessionRelationRanks.ToListAsync();
        }

        // GET: api/SuccessionRelationRank/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SuccessionRelationRank>> GetSuccessionRelationRank(int id)
        {
            var successionRelationRank = await _context.SuccessionRelationRanks.FindAsync(id);

            if (successionRelationRank == null)
            {
                return NotFound();
            }

            return successionRelationRank;
        }
    }
}
