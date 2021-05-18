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
    public class CraneGamePrizePatternController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CraneGamePrizePatternController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CraneGamePrizePattern
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CraneGamePrizePattern>>> GetCraneGamePrizePatterns()
        {
            return await _context.CraneGamePrizePatterns.ToListAsync();
        }

        // GET: api/CraneGamePrizePattern/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CraneGamePrizePattern>> GetCraneGamePrizePattern(int id)
        {
            var craneGamePrizePattern = await _context.CraneGamePrizePatterns.FindAsync(id);

            if (craneGamePrizePattern == null)
            {
                return NotFound();
            }

            return craneGamePrizePattern;
        }
    }
}
