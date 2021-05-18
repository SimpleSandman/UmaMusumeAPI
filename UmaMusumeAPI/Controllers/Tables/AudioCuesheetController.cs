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
    public class AudioCuesheetController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public AudioCuesheetController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/AudioCuesheet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AudioCuesheet>>> GetAudioCuesheets()
        {
            return await _context.AudioCuesheets.ToListAsync();
        }

        // GET: api/AudioCuesheet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AudioCuesheet>> GetAudioCuesheet(int id)
        {
            var audioCuesheet = await _context.AudioCuesheets.FindAsync(id);

            if (audioCuesheet == null)
            {
                return NotFound();
            }

            return audioCuesheet;
        }
    }
}
