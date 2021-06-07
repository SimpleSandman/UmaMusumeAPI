using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using UmaMusumeAPI.Context;
using UmaMusumeAPI.Models.Views;

namespace UmaMusumeAPI.Controllers.Views
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasicRaceTrackInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public BasicRaceTrackInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/BasicRaceTrackInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BasicRaceTrackInfo>>> GetBasicRaceTrackInfos()
        {
            return await _context.BasicRaceTrackInfos.ToListAsync();
        }

        // GET: api/BasicRaceTrackInfo/5
        [HttpGet("{raceTrackId}")]
        public async Task<ActionResult<BasicRaceTrackInfo>> GetBasicRaceTrackInfo(int raceTrackId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var basicRaceTrackInfo = await _context.BasicRaceTrackInfos.SingleOrDefaultAsync(c => c.RaceTrackId == raceTrackId);

            if (basicRaceTrackInfo == null)
            {
                return NotFound();
            }

            return basicRaceTrackInfo;
        }
    }
}
