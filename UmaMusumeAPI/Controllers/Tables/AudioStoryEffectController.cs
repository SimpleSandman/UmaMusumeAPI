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
    public class AudioStoryEffectController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public AudioStoryEffectController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/AudioStoryEffect
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AudioStoryEffect>>> GetAudioStoryEffects()
        {
            return await _context.AudioStoryEffects.ToListAsync();
        }

        // GET: api/AudioStoryEffect/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AudioStoryEffect>> GetAudioStoryEffect(int id)
        {
            var audioStoryEffect = await _context.AudioStoryEffects.FindAsync(id);

            if (audioStoryEffect == null)
            {
                return NotFound();
            }

            return audioStoryEffect;
        }
    }
}
