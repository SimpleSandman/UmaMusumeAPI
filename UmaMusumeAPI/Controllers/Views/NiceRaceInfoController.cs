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
    public class NiceRaceInfoController : ControllerBase
    {
        private readonly UmaMusumeDbContext _context;

        public NiceRaceInfoController(UmaMusumeDbContext context)
        {
            _context = context;
        }

        // GET: api/NiceRaceInfo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NiceRaceInfo>>> GetNiceRaceInfos()
        {
            return await _context.NiceRaceInfos.ToListAsync();
        }

        // GET: api/NiceRaceInfo/5
        [HttpGet("{raceId}")]
        public async Task<ActionResult<NiceRaceInfo>> GetNiceRaceInfo(int raceId)
        {
            // Since views don't have PKs, we need to use .SingleOrDefaultAsync() to best imitate .FindAsync()
            var niceRaceInfo = await _context.NiceRaceInfos.SingleOrDefaultAsync(c => c.RaceId == raceId);

            if (niceRaceInfo == null)
            {
                return NotFound();
            }

            return niceRaceInfo;
        }
    }
}
