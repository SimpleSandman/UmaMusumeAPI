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
    public class ShortEpisodeController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public ShortEpisodeController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/ShortEpisode
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ShortEpisode>>> GetShortEpisodes()
        {
            return await _context.ShortEpisodes.ToListAsync();
        }

        // GET: api/ShortEpisode/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ShortEpisode>> GetShortEpisode(int id)
        {
            var shortEpisode = await _context.ShortEpisodes.FindAsync(id);

            if (shortEpisode == null)
            {
                return NotFound();
            }

            return shortEpisode;
        }
    }
}
