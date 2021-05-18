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
    public class AudioIgnoredCueOnHighspeedController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public AudioIgnoredCueOnHighspeedController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/AudioIgnoredCueOnHighspeed
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AudioIgnoredCueOnHighspeed>>> GetAudioIgnoredCueOnHighspeeds()
        {
            return await _context.AudioIgnoredCueOnHighspeeds.ToListAsync();
        }

        // GET: api/AudioIgnoredCueOnHighspeed/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AudioIgnoredCueOnHighspeed>> GetAudioIgnoredCueOnHighspeed(int id)
        {
            var audioIgnoredCueOnHighspeed = await _context.AudioIgnoredCueOnHighspeeds.FindAsync(id);

            if (audioIgnoredCueOnHighspeed == null)
            {
                return NotFound();
            }

            return audioIgnoredCueOnHighspeed;
        }
    }
}
