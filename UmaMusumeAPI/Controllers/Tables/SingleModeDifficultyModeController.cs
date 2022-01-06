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
    public class SingleModeDifficultyModeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeDifficultyModeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeDifficultyMode
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeDifficultyMode>>> GetSingleModeDifficultyModes()
        {
            return await _context.SingleModeDifficultyModes.ToListAsync();
        }

        // GET: api/SingleModeDifficultyMode/5
        [HttpGet("{difficultyId}")]
        public async Task<ActionResult<IEnumerable<SingleModeDifficultyMode>>> GetSingleModeDifficultyMode(int difficultyId)
        {
            var singleModeDifficultyMode = await _context.SingleModeDifficultyModes
                .Where(c => c.DifficultyId == difficultyId)
                .ToListAsync();

            if (singleModeDifficultyMode == null)
            {
                return NotFound();
            }

            return singleModeDifficultyMode;
        }
    }
}
