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
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeDifficultyMode>> GetSingleModeDifficultyMode(int id)
        {
            var singleModeDifficultyMode = await _context.SingleModeDifficultyModes.FindAsync(id);

            if (singleModeDifficultyMode == null)
            {
                return NotFound();
            }

            return singleModeDifficultyMode;
        }
    }
}
