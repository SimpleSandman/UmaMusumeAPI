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
    public class RaceTrackController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public RaceTrackController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/RaceTrack
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RaceTrack>>> GetRaceTracks()
        {
            return await _context.RaceTracks.ToListAsync();
        }

        // GET: api/RaceTrack/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RaceTrack>> GetRaceTrack(int id)
        {
            var raceTrack = await _context.RaceTracks.FindAsync(id);

            if (raceTrack == null)
            {
                return NotFound();
            }

            return raceTrack;
        }
    }
}
