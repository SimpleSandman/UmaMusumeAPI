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
    public class SingleModeHintGainController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public SingleModeHintGainController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/SingleModeHintGain
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SingleModeHintGain>>> GetSingleModeHintGain()
        {
            return await _context.SingleModeHintGains.ToListAsync();
        }

        // GET: api/SingleModeHintGain/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SingleModeHintGain>> GetSingleModeHintGain(long id)
        {
            var singleModeHintGain = await _context.SingleModeHintGains
                .SingleOrDefaultAsync(c => c.Id == id);

            if (singleModeHintGain == null)
            {
                return NotFound();
            }

            return singleModeHintGain;
        }
    }
}
