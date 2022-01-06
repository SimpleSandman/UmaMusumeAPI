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
    public class CraneGameCatchResultController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CraneGameCatchResultController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CraneGameCatchResult
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CraneGameCatchResult>>> GetCraneGameCatchResults()
        {
            return await _context.CraneGameCatchResults.ToListAsync();
        }

        // GET: api/CraneGameCatchResult/5
        [HttpGet("{oddsId}")]
        public async Task<ActionResult<IEnumerable<CraneGameCatchResult>>> GetCraneGameCatchResult(int oddsId)
        {
            var craneGameCatchResult = await _context.CraneGameCatchResults
                .Where(c => c.OddsId == oddsId)
                .ToListAsync();

            if (craneGameCatchResult == null)
            {
                return NotFound();
            }

            return craneGameCatchResult;
        }
    }
}
