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
    public class UltimateRaceContentsChangeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public UltimateRaceContentsChangeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/UltimateRaceContentsChange
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UltimateRaceContentsChange>>> GetUltimateRaceContentsChange()
        {
            return await _context.UltimateRaceContentsChanges.ToListAsync();
        }

        // GET: api/UltimateRaceContentsChange/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<UltimateRaceContentsChange>>> GetUltimateRaceContentsChange(int id)
        {
            var ultimateRaceContentsChange = await _context.UltimateRaceContentsChanges
                .Where(c => c.Id == id)
                .ToListAsync();

            if (ultimateRaceContentsChange == null)
            {
                return NotFound();
            }

            return ultimateRaceContentsChange;
        }
    }
}
