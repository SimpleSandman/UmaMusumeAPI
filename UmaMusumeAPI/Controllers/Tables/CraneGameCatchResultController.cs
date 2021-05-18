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
        [HttpGet("{id}")]
        public async Task<ActionResult<CraneGameCatchResult>> GetCraneGameCatchResult(int id)
        {
            var craneGameCatchResult = await _context.CraneGameCatchResults.FindAsync(id);

            if (craneGameCatchResult == null)
            {
                return NotFound();
            }

            return craneGameCatchResult;
        }
    }
}
