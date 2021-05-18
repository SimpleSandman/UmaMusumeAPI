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
    public class CraneGameHiddenOddController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public CraneGameHiddenOddController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/CraneGameHiddenOdd
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CraneGameHiddenOdd>>> GetCraneGameHiddenOdds()
        {
            return await _context.CraneGameHiddenOdds.ToListAsync();
        }

        // GET: api/CraneGameHiddenOdd/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CraneGameHiddenOdd>> GetCraneGameHiddenOdd(int id)
        {
            var craneGameHiddenOdd = await _context.CraneGameHiddenOdds.FindAsync(id);

            if (craneGameHiddenOdd == null)
            {
                return NotFound();
            }

            return craneGameHiddenOdd;
        }
    }
}
